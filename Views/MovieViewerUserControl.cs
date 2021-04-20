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

        #endregion

        #region Constructor

        public MovieViewerUserControl(Image image, int id)
        {
            InitializeComponent();
            InitializeColors();
            InitializeMovie(image, id);
            _movieId = id;
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
        }

        private void InitializeMovie(Image image, int id)
        {
            movieImage.Image = image;

            var con = DatabaseController.GetConnection();
            con.Open();

            var query =
                "SELECT movie.name, description, director, writer, stars, release_date, genre.name " +
                "FROM movie " +
                "JOIN genre ON genre_id = genre.id " +
                "WHERE movie.id = " + id;

            using var cmd = new NpgsqlCommand(query, con);
            using var rdr = cmd.ExecuteReader();

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

            con.Close();

            con.Open();

            query =
                "SELECT value " +
                "FROM rating " +
                "WHERE movie_id = " + id + " " +
                "AND user_id = " + Account.GetAccountInstance().Id;

            using var cmd2 = new NpgsqlCommand(query, con);
            using var rdr2 = cmd2.ExecuteReader();

            while (rdr2.Read())
            {
                try
                {
                    SetStars(rdr2.GetInt32(0));
                    _starsCount = rdr2.GetInt32(0);
                }
                catch
                {
                    MessageBox.Show(@"Something went wrong.");
                }
            }

            con.Close();
        }

        private void Activity(PictureBox pb, string tableName)
        {
            var con = DatabaseController.GetConnection();
            con.Open();

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

            con.Close();
        }

        private void Rate(int rate)
        {
            var con = DatabaseController.GetConnection();
            con.Open();

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

            con.Close();

            _starsCount = rate;
        }

        private void SetStars(int count)
        {
            var stars = new[] {star1, star2, star3, star4, star5};

            for (var i = 0; i < stars.Length; i++)
            {
                if (i < count)
                {
                    stars[i].Image = Resources.star;
                    stars[i].Tag = 1;
                }
                else
                {
                    stars[i].Image = Resources.star_empty;
                    stars[i].Tag = 0;
                }
            }
        }

        private void StarsHover(int count)
        {
            var stars = new[] {star1, star2, star3, star4, star5};

            for (var i = 0; i < stars.Length; i++)
            {
                stars[i].Image = i < count ? Resources.star_hover : Resources.star_empty;
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
            SetImageOnMouseMovement(favoriteImage, Resources.favorite_empty_hover, Resources.favorite_hover);
        }

        private void favoriteImage_MouseLeave(object sender, EventArgs e)
        {
            SetImageOnMouseMovement(favoriteImage, Resources.favorite_empty, Resources.favorite);
        }

        private void favoriteImage_MouseClick(object sender, MouseEventArgs e)
        {
            Activity(favoriteImage, "favorite");
            SetImageOnMouseClick(favoriteImage, Resources.favorite_empty, Resources.favorite);
        }

        private void watchedImage_MouseHover(object sender, EventArgs e)
        {
            SetImageOnMouseMovement(watchedImage, Resources.watched_empty_hover, Resources.watched_hover);
        }

        private void watchedImage_MouseLeave(object sender, EventArgs e)
        {
            SetImageOnMouseMovement(watchedImage, Resources.watched_empty, Resources.watched);
        }

        private void watchedImage_MouseClick(object sender, MouseEventArgs e)
        {
            Activity(watchedImage, "history");
            SetImageOnMouseClick(watchedImage, Resources.watched_empty, Resources.watched);
        }

        private void watchlistImage_MouseHover(object sender, EventArgs e)
        {
            SetImageOnMouseMovement(watchlistImage, Resources.watchlist_empty_hover, Resources.watchlist_hover);
        }

        private void watchlistImage_MouseLeave(object sender, EventArgs e)
        {
            SetImageOnMouseMovement(watchlistImage, Resources.watchlist_empty, Resources.watchlist);
        }

        private void watchlistImage_MouseClick(object sender, MouseEventArgs e)
        {
            Activity(watchlistImage, "watchlist");
            SetImageOnMouseClick(watchlistImage, Resources.watchlist_empty, Resources.watchlist);
        }
        
        #endregion
    }
}