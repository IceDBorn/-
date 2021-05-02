using System.Drawing;
using System.Windows.Forms;
using filmhub.Controllers;

namespace filmhub.Views
{
    public partial class MovieEditorUserControl : UserControl
    {
        #region Fields

        private readonly int _movieId;
        private readonly Image _image;

        private class ComboItem
        {
            public int Id { get; set; }
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
            
            genreValue.DataSource = new ComboItem[] {
                new() { Id = 1, Text = "Action" },
                new() { Id = 2, Text = "Comedy" },
                new() { Id = 3, Text = "Crime" },
                new() { Id = 4, Text = "Documentary" },
                new() { Id = 5, Text = "Drama" },
                new() { Id = 6, Text = "Fantasy" },
                new() { Id = 7, Text = "Horror" },
                new() { Id = 8, Text = "Mystery" },
                new() { Id = 9, Text = "Romance" },
                new() { Id = 10, Text = "Sci-Fi" },
                new() { Id = 11, Text = "Western" }
            };
            
            InitializeMovie(title, directors, writers, stars, genre, date, description);
            movieImage.Image = image;
            _movieId = movieId;
            _image = image;
            
            
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            editMovieLabel.ForeColor = Program.Colors.ForeColor;
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
        }

        private void InitializeMovie(string title, string directors, string writers, string stars, string genre,
            string date, string description)
        {
            titleValueLabel.Text = title;
            directorValueLabel.Text = directors;
            writerValueLabel.Text = writers;
            starsValueLabel.Text = stars;
            descriptionValueLabel.Text = description;

            for (var i = 0; i < genreValue.Items.Count; i++)
            {
                if (genre.Equals(genreValue.Items[i].ToString()))
                {
                    genreValue.SelectedIndex = i;
                }
            }
        }

        #endregion

        private void saveButton_MouseClick(object sender, MouseEventArgs e)
        {
            MovieController.UpdateMovie(
                _movieId,
                titleValueLabel.Text,
                directorValueLabel.Text,
                writerValueLabel.Text,
                starsValueLabel.Text,
                dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                descriptionValueLabel.Text
            );
            Program.MainForm.UserControlSelector(new MovieViewerUserControl(_image, _movieId), true);
        }
    }
}