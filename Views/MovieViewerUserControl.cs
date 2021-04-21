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

        private readonly int _movieId;
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

        #endregion

        #region Constructor

        public MovieViewerUserControl(Image image, int id)
        {
            InitializeComponent();
            InitializeColors();
            InitializeImages();
            InitializeMovie(image, id);
            _movieId = id;
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
            }
            else
            {
                _favoriteEmpty = Resources.favorite_empty_black;
                _watchedEmpty = Resources.watched_empty_black;
                _watchlistEmpty = Resources.watchlist_empty_black;
                _starEmpty = Resources.star_empty_black;
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
        }

        private void InitializeMovie(Image image, int id)
        {
            movieImage.Image = image;

            var con = DatabaseController.GetConnection();

            var query =
                "SELECT movie.name, description, director, writer, stars, release_date, genre.name " +
                "FROM movie " +
                "JOIN genre ON genre_id = genre.id " +
                "WHERE movie.id = " + id;

            var cmd = new NpgsqlCommand(query, con);
            var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                try
                {
                    titleLabel.Text = rdr.GetString(0);
                    descriptionText.Text = rdr.GetString(1);
                    directorValueLabel.Text = rdr.GetString(2);
                    writerValueLabel.Text = rdr.GetString(3);
                    starsValueLabel.Text = rdr.GetString(4);
                    dateValueLabel.Text = rdr.GetDate(5).ToString();
                    genreValueLabel.Text = rdr.GetString(6);
                }
                catch
                {
                    MessageBox.Show(@"Something went wrong.");
                }
            }
            rdr.Close();

            query =
                "SELECT value " +
                "FROM rating " +
                "WHERE movie_id = " + id + " " +
                "AND user_id = " + Account.GetAccountInstance().Id;

            cmd = new NpgsqlCommand(query, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                try
                {
                    SetStars(rdr.GetInt32(0));
                    _starsCount = rdr.GetInt32(0);
                }
                catch
                {
                    MessageBox.Show(@"Something went wrong.");
                }
            }
            rdr.Close();

            if (QueryController.Activity("favorite", Account.GetAccountInstance().Id, id))
            {
                FillImage(favoriteImage, _favorite);
            }
            if (QueryController.Activity("history", Account.GetAccountInstance().Id, id))
            {
                FillImage(watchedImage, _watched);
            }
            if (QueryController.Activity("watchlist", Account.GetAccountInstance().Id, id))
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
            var con = DatabaseController.GetConnection();

            if (int.Parse(pb.Tag.ToString()) == 0)
            {
                var query = "INSERT INTO " + tableName + "(movie_id, user_id) VALUES (" + _movieId + ", " +
                            Account.GetAccountInstance().Id + ")";
                using var cmd = new NpgsqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                var query = "DELETE FROM " + tableName + " WHERE movie_id = " + _movieId + " AND user_id = " +
                            Account.GetAccountInstance().Id;
                using var cmd = new NpgsqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }

        private void Rate(int rate)
        {
            var con = DatabaseController.GetConnection();

            if (int.Parse(star1.Tag.ToString()) == 0)
            {
                var query = "INSERT INTO rating(value,movie_id,user_id) VALUES (" + rate + ", " + _movieId + ", " +
                            Account.GetAccountInstance().Id + ")";
                using var cmd = new NpgsqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                var query = "UPDATE rating SET value = " + rate + " WHERE movie_id = " + _movieId + " AND user_id = " +
                            Account.GetAccountInstance().Id;
                using var cmd = new NpgsqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }

            SetStars(rate);

            _starsCount = rate;
        }

        private void SetStars(int count)
        {
            var stars = new[] {star1, star2, star3, star4, star5};

            for (var i = 0; i < stars.Length; i++)
            {
                if (i < count)
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
            SetStars(_starsCount);
        }

        private void star2_MouseHover(object sender, EventArgs e)
        {
            StarsHover(2);
        }

        private void star2_MouseLeave(object sender, EventArgs e)
        {
            SetStars(_starsCount);
        }

        private void star3_MouseHover(object sender, EventArgs e)
        {
            StarsHover(3);
        }

        private void star3_MouseLeave(object sender, EventArgs e)
        {
            SetStars(_starsCount);
        }

        private void star4_MouseHover(object sender, EventArgs e)
        {
            StarsHover(4);
        }

        private void star4_MouseLeave(object sender, EventArgs e)
        {
            SetStars(_starsCount);
        }

        private void star5_MouseHover(object sender, EventArgs e)
        {
            StarsHover(5);
        }

        private void star5_MouseLeave(object sender, EventArgs e)
        {
            SetStars(_starsCount);
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

        #endregion
    }
}