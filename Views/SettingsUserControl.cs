using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using filmhub.Controllers;
using filmhub.Models;
using filmhub.Properties;
using Imgur.API.Authentication;
using Imgur.API.Endpoints;
using Npgsql;
using NpgsqlTypes;

namespace filmhub.Views
{
    public partial class SettingsUserControl : UserControl
    {
        #region Fields

        private Image _dark;
        private Image _darkHover;
        private Image _light;
        private Image _lightHover;

        #endregion

        #region Constructor

        public SettingsUserControl()
        {
            InitializeComponent();
            InitializeColors();
            InitializeImages();
            InitializeUser();
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            settingsLabel.ForeColor = Program.Colors.ForeColor;
            usernameLabel.ForeColor = Program.Colors.ForeColor;
            usernameValueLabel.ForeColor = Program.Colors.ForeColor;
            changeLabel.ForeColor = Program.Colors.ForeColor;
            confirmLabel.ForeColor = Program.Colors.ForeColor;
            BackColor = Program.Colors.BackgroundColor;
            saveButton.BackColor = Program.Colors.AccentColor;
            saveButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            resetButton.BackColor = Program.Colors.AccentColor;
            resetButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            uploadButton.BackColor = Program.Colors.AccentColor;
            uploadButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            changeTextBox.BackColor = Program.Colors.FieldColor;
            changeTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
            confirmTextBox.BackColor = Program.Colors.FieldColor;
            confirmTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
            userProfileImage.BackColor = Program.Colors.BackgroundColor;
        }

        private void InitializeImages()
        {
            _dark = Resources.dark;
            _light = Resources.light;
            
            themeImage.Image = Properties.Settings.Default.Theme == 0 ? _dark : _light;
            
            _darkHover = Resources.dark_hover;
            _lightHover = Resources.light_hover;
        }
        
        private static Image DownloadImageFromUrl(string imageUrl)
        {
            Image image;

            try
            {
                var webRequest = (HttpWebRequest) WebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                var webResponse = webRequest.GetResponse();

                var stream = webResponse.GetResponseStream();

                image = Image.FromStream(stream ?? throw new InvalidOperationException());

                webResponse.Close();
            }
            catch
            {
                return null;
            }

            return image;
        }

        private void InitializeUser()
        {
            usernameValueLabel.Text = Account.GetAccountInstance().Username;
            if (Account.GetAccountInstance().Picture == null) return;
            imageList.Images.Clear();
            imageList.Images.Add(DownloadImageFromUrl(Account.GetAccountInstance().Picture));
            userProfileImage.Image = imageList.Images[0];
        }

        #endregion

        #region Events

        private void resetButton_Click(object sender, EventArgs e)
        {
            changeTextBox.Text = "";
            confirmTextBox.Text = "";
        }

        private async void uploadButton_Click(object sender, EventArgs e)
        {
            photoBrowser.FileName = "";
            photoBrowser.Title = @"Select photo to upload";
            photoBrowser.Filter = @"Image Files(*.BMP;*.JPG;*.GIF,.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            photoBrowser.ShowDialog();

            if (string.IsNullOrEmpty(photoBrowser.FileName)) return;
            imageList.Images.Clear();
            imageList.Images.Add(Image.FromFile(photoBrowser.FileName));
            userProfileImage.Image = imageList.Images[0];
            var task = UploadImageToImgur();
            await task;
        }

        private async Task UploadImageToImgur()
        {
            try
            {
                // Create connection to API
                var apiClient = new ApiClient("21d68b39c14c68e");
                var httpClient = new HttpClient();

                // Select image for upload
                var filePath = photoBrowser.FileName;
                using var fileStream = File.OpenRead(filePath);

                // Create end point and upload image
                var imageEndpoint = new ImageEndpoint(apiClient, httpClient);
                var imageUpload = await imageEndpoint.UploadImageAsync(fileStream);
                
                var con = DatabaseController.GetConnection();

                var query = "UPDATE account SET picture = @link WHERE id = @id";
                
                using var cmd = new NpgsqlCommand(query, con);
                var link = cmd.Parameters.Add("link", NpgsqlDbType.Text);
                var id = cmd.Parameters.Add("id", NpgsqlDbType.Integer);
                
                await cmd.PrepareAsync();

                link.Value = imageUpload.Link;
                id.Value = Account.GetAccountInstance().Id;
                
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show(@"Something went wrong, please try again.");
            }
        }
        
        private void themeImage_MouseHover(object sender, EventArgs e)
        {
            themeImage.Image = Properties.Settings.Default.Theme == 0 ? _darkHover : _lightHover;
        }

        private void themeImage_MouseLeave(object sender, EventArgs e)
        {
            themeImage.Image = Properties.Settings.Default.Theme == 0 ? _dark : _light;
        }

        #endregion

        private void themeImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.Theme == 0)
            {
                Program.Colors.LightTheme();
            }
            else
            {
                Program.Colors.DarkTheme();
                
            }
            
            Program.MainForm.RefreshUi();
        }
    }
}