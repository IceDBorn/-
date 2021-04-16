using System;
using System.Windows.Forms;
using filmhub.Properties;

namespace filmhub.Views
{
    public partial class MovieViewer : UserControl
    {
        #region Fields

        // Save star tags
        private int[] _tags;

        #endregion
        
        #region Constructor

        public MovieViewer()
        {
            InitializeComponent();
            InitializeColors();
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
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
            else
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
            SwitchStarImage(3,false);
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