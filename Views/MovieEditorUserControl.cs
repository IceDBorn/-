using System;
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
            public int ID { get; set; }
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
            InitializeMovie(title, directors, writers, stars, genre, date, description);
            movieImage.Image = image;
            _movieId = movieId;
            _image = image;
            
            comboBox1.DataSource = new ComboItem[] {
                new() { ID = 1, Text = "Action" },
                new() { ID = 2, Text = "Comedy" },
                new() { ID = 3, Text = "Crime" },
                new() { ID = 4, Text = "Documentary" },
                new() { ID = 5, Text = "Drama" },
                new() { ID = 6, Text = "Fantasy" },
                new() { ID = 7, Text = "Horror" },
                new() { ID = 8, Text = "Mystery" },
                new() { ID = 9, Text = "Romance" },
                new() { ID = 10, Text = "Sci-Fi" },
                new() { ID = 11, Text = "Western" }
            };
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
            comboBox1.BackColor = Program.Colors.FieldColor;
            comboBox1.ForeColor = Program.Colors.FieldDarkTextColor;
        }

        private void InitializeMovie(string title, string directors, string writers, string stars, string genre,
            string date, string description)
        {
            titleValueLabel.Text = title;
            directorValueLabel.Text = directors;
            writerValueLabel.Text = writers;
            starsValueLabel.Text = stars;
            descriptionValueLabel.Text = description;
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