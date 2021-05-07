using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using filmhub.Controllers;
using Imgur.API.Authentication;
using Imgur.API.Endpoints;

namespace filmhub.Views
{
    public partial class MovieEditorUserControl : UserControl
    {
        #region Fields

        private int _movieId;
        private Image _image;
        private string _imageLink;
        private readonly bool _isNew;
        private bool _isUploaded = true;

        private class ComboItem
        {
            public string Text { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        #endregion

        #region Constructor

        public MovieEditorUserControl(string title, string directors, string writers, string stars, string genre,
            string date, string description, Image image, int movieId)
        {
            InitializeComponent();
            InitializeColors();
            InitializeGenres();
            InitializeMovie(title, directors, writers, stars, genre, date, description, image, movieId);
            menuTitleLabel.Text = @"Edit movie";
            removeButton.Visible = true;
            _isNew = false;
        }

        public MovieEditorUserControl()
        {
            InitializeComponent();
            InitializeColors();
            InitializeGenres();
            menuTitleLabel.Text = @"Add movie";
            saveButton.Text = @"Add movie";
            titleValueLabel.Text = "";
            directorValueLabel.Text = "";
            writerValueLabel.Text = "";
            starsValueLabel.Text = "";
            descriptionValueLabel.Text = "";
            _isNew = true;
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            menuTitleLabel.ForeColor = Program.Colors.ForeColor;
            titleLabel.ForeColor = Program.Colors.ForeColor;
            titleValueLabel.ForeColor = Program.Colors.FieldDarkTextColor;
            titleValueLabel.BackColor = Program.Colors.FieldColor;
            directorLabel.ForeColor = Program.Colors.ForeColor;
            directorValueLabel.ForeColor = Program.Colors.FieldDarkTextColor;
            directorValueLabel.BackColor = Program.Colors.FieldColor;
            writerLabel.ForeColor = Program.Colors.ForeColor;
            writerValueLabel.ForeColor = Program.Colors.FieldDarkTextColor;
            writerValueLabel.BackColor = Program.Colors.FieldColor;
            starsLabel.ForeColor = Program.Colors.ForeColor;
            starsValueLabel.ForeColor = Program.Colors.FieldDarkTextColor;
            starsValueLabel.BackColor = Program.Colors.FieldColor;
            genreLabel.ForeColor = Program.Colors.ForeColor;
            dateLabel.ForeColor = Program.Colors.ForeColor;
            descriptionLabel.ForeColor = Program.Colors.ForeColor;
            descriptionValueLabel.ForeColor = Program.Colors.FieldDarkTextColor;
            descriptionValueLabel.BackColor = Program.Colors.FieldColor;
            saveButton.BackColor = Program.Colors.AccentColor;
            saveButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            uploadButton.BackColor = Program.Colors.AccentColor;
            uploadButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            genreValue.BackColor = Program.Colors.FieldColor;
            genreValue.ForeColor = Program.Colors.FieldDarkTextColor;
            dateValue.BackColor = Program.Colors.FieldColor;
            dateValue.ForeColor = Program.Colors.FieldDarkTextColor;
            movieImage.BackColor = Program.Colors.FieldColor;
            uploadingLabel.BackColor = Program.Colors.FieldColor;
            uploadingLabel.ForeColor = Program.Colors.FieldDarkTextColor;
            removeButton.BackColor = Program.Colors.AccentColor;
            removeButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
        }

        private void InitializeMovie(string title, string directors, string writers, string stars, string genre,
            string date, string description, Image image, int movieId)
        {
            titleValueLabel.Text = title;
            directorValueLabel.Text = directors;
            writerValueLabel.Text = writers;
            starsValueLabel.Text = stars;
            descriptionValueLabel.Text = description;

            for (var i = 0; i < genreValue.Items.Count; i++)
            {
                if (!genre.Equals(genreValue.Items[i].ToString())) continue;
                genreValue.SelectedIndex = i;
                break;
            }

            dateValue.Value = DateTime.Parse(date);
            movieImage.Image = image;
            _movieId = movieId;
            _image = image;
        }

        private void InitializeGenres()
        {
            genreValue.DataSource = new ComboItem[]
            {
                new() {Text = "Action"},
                new() {Text = "Comedy"},
                new() {Text = "Crime"},
                new() {Text = "Documentary"},
                new() {Text = "Drama"},
                new() {Text = "Fantasy"},
                new() {Text = "Horror"},
                new() {Text = "Mystery"},
                new() {Text = "Romance"},
                new() {Text = "Sci-Fi"},
                new() {Text = "Western"}
            };
        }

        private async Task UploadImageToImgur()
        {
            try
            {
                _isUploaded = false;
                uploadingLabel.Visible = true;
                // Create connection to API
                var apiClient = new ApiClient("21d68b39c14c68e");
                var httpClient = new HttpClient();

                // Select image for upload
                var filePath = photoBrowser.FileName;
                using var fileStream = File.OpenRead(filePath);

                // Create end point and upload image
                var imageEndpoint = new ImageEndpoint(apiClient, httpClient);
                var imageUpload = await imageEndpoint.UploadImageAsync(fileStream);
                _imageLink = imageUpload.Link;
                _isUploaded = true;
                uploadingLabel.Visible = false;

                if (_isNew) return;
                // Save the image url to the database
                await SettingController.UpdateImageLink(_imageLink, "movie", _movieId);
            }
            catch
            {
                uploadingLabel.Visible = false;
                MessageBox.Show(@"Something went wrong, please try again.");
            }
        }

        #endregion

        #region Events

        private void saveButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(titleValueLabel.Text.Trim()))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Title is empty.");
            }
            else if (string.IsNullOrEmpty(directorValueLabel.Text.Trim()))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Directors is empty.");
            }
            else if (string.IsNullOrEmpty(writerValueLabel.Text.Trim()))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Writers is empty.");
            }
            else if (string.IsNullOrEmpty(starsValueLabel.Text.Trim()))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Stars is empty.");
            }
            else if (string.IsNullOrEmpty(descriptionValueLabel.Text.Trim()))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Description is empty.");
            }
            else if (_imageLink == null && _isNew)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Photo is empty.");
            }
            else if (_isUploaded)
            {
                if (_isNew)
                {
                    // Create add movie function for MovieController TODO
                }
                else
                {
                    MovieController.UpdateMovie(
                        _movieId,
                        titleValueLabel.Text,
                        directorValueLabel.Text,
                        writerValueLabel.Text,
                        starsValueLabel.Text,
                        dateValue.Value.ToString("yyyy-MM-dd"),
                        descriptionValueLabel.Text
                    );
                }

                Program.MainForm.UserControlSelector(new MovieViewerUserControl(_image, _movieId), true);
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Photo is still uploading...");
            }
        }

        private async void uploadButton_Click(object sender, EventArgs e)
        {
            photoBrowser.FileName = "";
            photoBrowser.Title = @"Select photo to upload";
            photoBrowser.Filter = @"Image Files(*.BMP;*.JPG;*.GIF,.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            photoBrowser.ShowDialog();

            if (string.IsNullOrEmpty(photoBrowser.FileName)) return;
            movieImage.Image = null;
            imageList.Images.Clear();
            imageList.Images.Add(Image.FromFile(photoBrowser.FileName));
            await UploadImageToImgur();
            if (_isUploaded) movieImage.Image = imageList.Images[0];
        }

        #endregion

        private void removeButton_Click(object sender, EventArgs e)
        {
            var dialogResult =
                MessageBox.Show(@"Remove movie " + titleValueLabel.Text + @"?", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // TODO: Remove movie function
                Program.MainForm.UserControlSelector(new MainPageUserControl(), true);
            }
        }
    }
}