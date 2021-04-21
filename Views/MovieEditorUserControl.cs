using System.Drawing;
using System.Windows.Forms;

namespace filmhub.Views
{
    public partial class MovieEditorUserControl : UserControl
    {
        #region Fields

        private readonly int _movieId;
        private string _title;
        private string _directors;
        private string _writers;
        private string _stars;
        private string _genre;
        private string _date;
        private string _description;

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
            genreValueLabel.ForeColor = Program.Colors.FieldDarkTextColor;
            genreValueLabel.BackColor = Program.Colors.FieldColor;
            dateLabel.ForeColor = Program.Colors.ForeColor;
            dateValueLabel.ForeColor = Program.Colors.FieldDarkTextColor;
            dateValueLabel.BackColor = Program.Colors.FieldColor;
            descriptionLabel.ForeColor = Program.Colors.ForeColor;
            descriptionValueLabel.ForeColor = Program.Colors.FieldDarkTextColor;
            descriptionValueLabel.BackColor = Program.Colors.FieldColor;
            saveButton.BackColor = Program.Colors.AccentColor;
            saveButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            uploadButton.BackColor = Program.Colors.AccentColor;
            uploadButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
        }

        private void InitializeMovie(string title, string directors, string writers, string stars, string genre,
            string date, string description)
        {
            _title = title;
            titleValueLabel.Text = _title;

            _directors = directors;
            directorValueLabel.Text = _directors;
            
            _writers = writers;
            writerValueLabel.Text = _writers;

            _stars = stars;
            starsValueLabel.Text = _stars;

            _genre = genre;
            genreValueLabel.Text = _genre;

            _date = date;
            dateValueLabel.Text = _date;

            _description = description;
            descriptionValueLabel.Text = _description;
        }

        #endregion
    }
}