using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using filmhub.Controllers;
using filmhub.Models;
using Imgur.API.Authentication;
using Imgur.API.Endpoints;
using Npgsql;
using NpgsqlTypes;

namespace filmhub.Views
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
            InitializeColors();
            InitializeUserImage();
        }

        #region Methods

        private void InitializeColors()
        {
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

        private void InitializeUserImage()
        {
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
                con.Open();

                var query = "UPDATE account SET picture = @link WHERE id = @id";
                
                using var cmd = new NpgsqlCommand(query, con);
                var link = cmd.Parameters.Add("link", NpgsqlDbType.Text);
                var id = cmd.Parameters.Add("id", NpgsqlDbType.Integer);
                
                await cmd.PrepareAsync();

                link.Value = imageUpload.Link;
                id.Value = Account.GetAccountInstance().Id;
                
                cmd.ExecuteNonQuery();
                
                await con.CloseAsync();
            }
            catch
            {
                MessageBox.Show(@"Something went wrong, please try again.");
            }
        }

        #endregion
    }
}