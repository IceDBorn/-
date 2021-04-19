using System;
using System.Drawing;
using System.Windows.Forms;
using filmhub.Properties;
using Npgsql;

namespace filmhub.Views
{
    public partial class MovieViewerUserControl : UserControl
    {
        #region Fields

        // Save star tags
        private int[] _tags;

        #endregion

        #region Constructor

        public MovieViewerUserControl(Image image, int id)
        {
            InitializeComponent();
            InitializeColors();
            InitializeMovie(image,id);
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
            
            var con = DatabaseController.getConnection();
            con.Open();

            var query =
                "SELECT movie.name, description, director, writer, stars, release_date, genre.name " +
                "FROM movie " +
                "JOIN genre ON genre_id = genre.id " +
                "WHERE movie.id = " +
                id;
            
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
        }

        private void SwitchStarImage(int count, bool flag)
        {
            // Save every star into a pictureBox array
            var stars = new[] {star1, star2, star3, star4, star5};

            // Hover
            if (flag)
            {
                _tags = new int[5];

                for (var i = 0; i < 5; i++)
                {
                    // Save star tag into tags[i]
                    if (i < count)
                    {
                        _tags[i] = int.Parse(stars[i].Tag.ToString());
                        stars[i].Image = Resources.star_hover;
                    }
                    else
                    {
                        _tags[i] = int.Parse(stars[i].Tag.ToString());
                        stars[i].Image = Resources.star_empty;
                    }
                }
            }
            // Leave
            else if (_tags != null)
            {
                for (var i = 0; i < 5; i++)
                {
                    // Reset images back to default using tags (0 = empty star, 1 = filled star)
                    stars[i].Image = _tags[i] switch
                    {
                        0 => Resources.star_empty,
                        1 => Resources.star,
                        _ => stars[i].Image
                    };
                }
            }
        }

        #endregion

        #region Events

        private void star1_MouseHover(object sender, EventArgs e)
        {
            SwitchStarImage(1, true);
        }

        private void star1_MouseLeave(object sender, EventArgs e)
        {
            SwitchStarImage(1, false);
        }

        private void star2_MouseHover(object sender, EventArgs e)
        {
            SwitchStarImage(2, true);
        }

        private void star2_MouseLeave(object sender, EventArgs e)
        {
            SwitchStarImage(2, false);
        }

        private void star3_MouseHover(object sender, EventArgs e)
        {
            SwitchStarImage(3, true);
        }

        private void star3_MouseLeave(object sender, EventArgs e)
        {
            SwitchStarImage(3, false);
        }

        private void star4_MouseHover(object sender, EventArgs e)
        {
            SwitchStarImage(4, true);
        }

        private void star4_MouseLeave(object sender, EventArgs e)
        {
            SwitchStarImage(4, false);
        }

        private void star5_MouseHover(object sender, EventArgs e)
        {
            SwitchStarImage(5, true);
        }

        private void star5_MouseLeave(object sender, EventArgs e)
        {
            SwitchStarImage(5, false);
        }

        #endregion
    }
}