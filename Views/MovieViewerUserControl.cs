using System;
using System.Drawing;
using System.Windows.Forms;
using filmhub.Controllers;
using filmhub.Models;
using filmhub.Properties;
using Npgsql;

namespace filmhub.Views
{
    public partial class MovieViewerUserControl : UserControl
    {
        #region Fields
        
        private static readonly NpgsqlConnection Con = DatabaseController.GetConnection();
        
        private int _starsCount;

        private Image _favoriteEmpty;
        private Image _favoriteEmptyHover;
        private Image _favorite;
        private Image _favoriteHover;

        private Image _watchedEmpty;
        private Image _watchedEmptyHover;
        private Image _watched;
        private Image _watchedHover;

        private Image _watchlistEmpty;
        private Image _watchlistEmptyHover;
        private Image _watchlist;
        private Image _watchlistHover;

        private Image _starEmpty;
        private Image _star;
        private Image _starHover;

        private Image _editMovie;
        private Image _editMovieHover;

        private Movie _movie;
        private readonly Image _movieImage;

        #endregion

        #region Constructor

        public MovieViewerUserControl(Image image, int id)
        {
            InitializeComponent();
            InitializeColors();
            InitializeImages();
            InitializeMovie(image, id);
            _movieImage = image;
            _movie.Id = id;
            if (Account.GetAccountInstance().Admin)
            {
                editPictureBox.Visible = true;
            }
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            titleLabel.ForeColor = Program.Colors.ForeColor;
            directorLabel.ForeColor = Program.Colors.ForeColor;
            directorValueLabel.ForeColor = Program.Colors.ForeColor;
            writerLabel.ForeColor = Program.Colors.ForeColor;
            writerValueLabel.ForeColor = Program.Colors.ForeColor;
            starsLabel.ForeColor = Program.Colors.ForeColor;
            starsValueLabel.ForeColor = Program.Colors.ForeColor;
            genreLabel.ForeColor = Program.Colors.ForeColor;
            genreValueLabel.ForeColor = Program.Colors.ForeColor;
            dateLabel.ForeColor = Program.Colors.ForeColor;
            dateValueLabel.ForeColor = Program.Colors.ForeColor;
            ratingLabel.ForeColor = Program.Colors.ForeColor;
            descriptionLabel.ForeColor = Program.Colors.ForeColor;
            descriptionText.ForeColor = Program.Colors.ForeColor;
        }

        private void InitializeImages()
        {
            if (Settings.Default.Theme == 0)
            {
                _favoriteEmpty = Resources.favorite_empty;
                _watchedEmpty = Resources.watched_empty;
                _watchlistEmpty = Resources.watchlist_empty;
                _starEmpty = Resources.star_empty;
                _editMovie = Resources.edit;
            }
            else
            {
                _favoriteEmpty = Resources.favorite_empty_black;
                _watchedEmpty = Resources.watched_empty_black;
                _watchlistEmpty = Resources.watchlist_empty_black;
                _starEmpty = Resources.star_empty_black;
                _editMovie = Resources.edit_black;
            }

            favoriteImage.Image = _favoriteEmpty;
            _favoriteEmptyHover = Resources.favorite_empty_hover;
            _favorite = Resources.favorite;
            _favoriteHover = Resources.favorite_hover;


            watchedImage.Image = _watchedEmpty;
            _watchedEmptyHover = Resources.watched_empty_hover;
            _watched = Resources.watched;
            _watchedHover = Resources.watched_hover;


            watchlistImage.Image = _watchlistEmpty;
            _watchlistEmptyHover = Resources.watchlist_empty_hover;
            _watchlist = Resources.watchlist;
            _watchlistHover = Resources.watchlist_hover;


            star1.Image = _starEmpty;
            star2.Image = _starEmpty;
            star3.Image = _starEmpty;
            star4.Image = _starEmpty;
            star5.Image = _starEmpty;
            _star = Resources.star;
            _starHover = Resources.star_hover;

            editPictureBox.Image = _editMovie;
            _editMovieHover = Resources.edit_hover;
        }

        private void InitializeMovie(Image image, int id)
        {
            movieImage.Image = image;

            _movie = MovieController.MovieViewerQuery(id);
            
            titleLabel.Text = _movie.Name;
            descriptionText.Text = _movie.Description;
            directorValueLabel.Text = _movie.Director;
            writerValueLabel.Text = _movie.Writer;
            starsValueLabel.Text = _movie.Stars;
            dateValueLabel.Text = _movie.ReleaseDate;
            genreValueLabel.Text = _movie.Genre;
            
            _starsCount = _movie.Rating;
            SetStars();
            
            if (ActivityController.IsActivityType("favorite", id))
            {
                FillImage(favoriteImage, _favorite);
            }

            if (ActivityController.IsActivityType("history", id))
            {
                FillImage(watchedImage, _watched);
            }

            if (ActivityController.IsActivityType("watchlist", id))
            {
                FillImage(watchlistImage, _watchlist);
            }
        }

        private static void FillImage(PictureBox pb, Image filled)
        {
            pb.Image = filled;
            pb.Tag = 1;
        }

        private void ActivityInsert(Control pb, string tableName)
        {
            if (int.Parse(pb.Tag.ToString()) == 0)
            {
                var query = "INSERT INTO " + tableName + "(movie_id, user_id) VALUES (" + _movie.Id + ", " +
                            Account.GetAccountInstance().Id + ")";
                using var cmd = new NpgsqlCommand(query, Con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                var query = "DELETE FROM " + tableName + " WHERE movie_id = " + _movie.Id + " AND user_id = " +
                            Account.GetAccountInstance().Id;
                using var cmd = new NpgsqlCommand(query, Con);
                cmd.ExecuteNonQuery();
            }
        }

        private void Rate(int rate)
        {
            if (int.Parse(star1.Tag.ToString()) == 0)
            {
                var query = "INSERT INTO rating(value,movie_id,user_id) VALUES (" + rate + ", " + _movie.Id + ", " +
                            Account.GetAccountInstance().Id + ")";
                using var cmd = new NpgsqlCommand(query, Con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                if (rate == _starsCount)
                {
                    
                    var query = "DELETE FROM rating WHERE movie_id = " + _movie.Id + " AND user_id = " +
                                Account.GetAccountInstance().Id;
                    using var cmd = new NpgsqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    rate = 0;
                }
                else
                {
                    var query = "UPDATE rating SET value = " + rate + " WHERE movie_id = " + _movie.Id + " AND user_id = " +
                                Account.GetAccountInstance().Id;
                    using var cmd = new NpgsqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                }
            }

            _starsCount = rate;
            SetStars();
        }

        private void SetStars()
        {
            var stars = new[] {star1, star2, star3, star4, star5};

            for (var i = 0; i < stars.Length; i++)
            {
                if (i < _starsCount)
                {
                    stars[i].Image = _star;
                    stars[i].Tag = 1;
                }
                else
                {
                    stars[i].Image = _starEmpty;
                    stars[i].Tag = 0;
                }
            }
        }

        private void StarsHover(int count)
        {
            var stars = new[] {star1, star2, star3, star4, star5};

            for (var i = 0; i < stars.Length; i++)
            {
                stars[i].Image = i < count ? _starHover : _starEmpty;
            }
        }

        private static void SetImageOnMouseMovement(PictureBox pictureBox, Image empty, Image filled)
        {
            pictureBox.Image = int.Parse(pictureBox.Tag.ToString()) == 0 ? empty : filled;
        }

        private static void SetImageOnMouseClick(PictureBox pictureBox, Image empty, Image filled)
        {
            if (int.Parse(pictureBox.Tag.ToString()) == 0)
            {
                pictureBox.Image = filled;
                pictureBox.Tag = 1;
            }
            else
            {
                pictureBox.Image = empty;
                pictureBox.Tag = 0;
            }
        }

        #endregion

        #region Events

        private void star1_MouseHover(object sender, EventArgs e)
        {
            StarsHover(1);
        }

        private void star1_MouseLeave(object sender, EventArgs e)
        {
            SetStars();
        }

        private void star2_MouseHover(object sender, EventArgs e)
        {
            StarsHover(2);
        }

        private void star2_MouseLeave(object sender, EventArgs e)
        {
            SetStars();
        }

        private void star3_MouseHover(object sender, EventArgs e)
        {
            StarsHover(3);
        }

        private void star3_MouseLeave(object sender, EventArgs e)
        {
            SetStars();
        }

        private void star4_MouseHover(object sender, EventArgs e)
        {
            StarsHover(4);
        }

        private void star4_MouseLeave(object sender, EventArgs e)
        {
            SetStars();
        }

        private void star5_MouseHover(object sender, EventArgs e)
        {
            StarsHover(5);
        }

        private void star5_MouseLeave(object sender, EventArgs e)
        {
            SetStars();
        }

        private void star1_MouseClick(object sender, MouseEventArgs e)
        {
            Rate(1);
        }

        private void star2_MouseClick(object sender, MouseEventArgs e)
        {
            Rate(2);
        }

        private void star3_MouseClick(object sender, MouseEventArgs e)
        {
            Rate(3);
        }

        private void star4_MouseClick(object sender, MouseEventArgs e)
        {
            Rate(4);
        }

        private void star5_MouseClick(object sender, MouseEventArgs e)
        {
            Rate(5);
        }

        private void favoriteImage_MouseHover(object sender, EventArgs e)
        {
            SetImageOnMouseMovement(favoriteImage, _favoriteEmptyHover, _favoriteHover);
        }

        private void favoriteImage_MouseLeave(object sender, EventArgs e)
        {
            SetImageOnMouseMovement(favoriteImage, _favoriteEmpty, _favorite);
        }

        private void favoriteImage_MouseClick(object sender, MouseEventArgs e)
        {
            ActivityInsert(favoriteImage, "favorite");
            SetImageOnMouseClick(favoriteImage, _favoriteEmpty, _favorite);
        }

        private void watchedImage_MouseHover(object sender, EventArgs e)
        {
            SetImageOnMouseMovement(watchedImage, _watchedEmptyHover, _watchedHover);
        }

        private void watchedImage_MouseLeave(object sender, EventArgs e)
        {
            SetImageOnMouseMovement(watchedImage, _watchedEmpty, _watched);
        }

        private void watchedImage_MouseClick(object sender, MouseEventArgs e)
        {
            ActivityInsert(watchedImage, "history");
            SetImageOnMouseClick(watchedImage, _watchedEmpty, _watched);
        }

        private void watchlistImage_MouseHover(object sender, EventArgs e)
        {
            SetImageOnMouseMovement(watchlistImage, _watchlistEmptyHover, _watchlistHover);
        }

        private void watchlistImage_MouseLeave(object sender, EventArgs e)
        {
            SetImageOnMouseMovement(watchlistImage, _watchlistEmpty, _watchlist);
        }

        private void watchlistImage_MouseClick(object sender, MouseEventArgs e)
        {
            ActivityInsert(watchlistImage, "watchlist");
            SetImageOnMouseClick(watchlistImage, _watchlistEmpty, _watchlist);
        }
        
        private void editPictureBox_MouseHover(object sender, EventArgs e)
        {
            editPictureBox.Image = _editMovieHover;
        }


        private void editPictureBox_MouseLeave(object sender, EventArgs e)
        {
            editPictureBox.Image = _editMovie;
        }

        private void editPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new MovieEditorUserControl(_movie, _movieImage), true);
        }

        #endregion
    }
}