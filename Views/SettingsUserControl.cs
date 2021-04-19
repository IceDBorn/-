using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imgur.API.Authentication;
using Imgur.API.Endpoints;

namespace filmhub.Views
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }

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
        }

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
                MessageBox.Show(imageUpload.Link);
            }
            catch
            {
                MessageBox.Show(@"Something went wrong, please try again.");
            }
        }
    }
}