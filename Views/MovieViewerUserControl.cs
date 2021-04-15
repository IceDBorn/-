using System;
using System.Windows.Forms;
using filmhub.Properties;

namespace filmhub.Views
{
    public partial class MovieViewer : UserControl
    {
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

        private static void SwitchStarImage(PictureBox star)
        {
            switch (int.Parse(star.Tag.ToString()))
            {
                case 0:
                {
                    star.Image = Resources.star_empty_hover;
                    star.Tag = 1;
                    break;
                }
                case 1:
                {
                    star.Image = Resources.star_empty;
                    star.Tag = 0;
                    break;
                }
                case 2:
                {
                    star.Image = Resources.star_hover;
                    star.Tag = 3;
                    break;
                }
                case 3:
                {
                    star.Image = Resources.star;
                    star.Tag = 2;
                    break;
                }
            }
        }

        #endregion

        #region Events

        private void star1_MouseHover(object sender, EventArgs e)
        {
            SwitchStarImage(star1);
        }

        private void star1_MouseLeave(object sender, EventArgs e)
        {
            SwitchStarImage(star1);
        }

        private void star2_MouseHover(object sender, EventArgs e)
        {
            SwitchStarImage(star2);
        }

        private void star2_MouseLeave(object sender, EventArgs e)
        {
            SwitchStarImage(star2);
        }

        private void star3_MouseHover(object sender, EventArgs e)
        {
            SwitchStarImage(star3);
        }

        private void star3_MouseLeave(object sender, EventArgs e)
        {
            SwitchStarImage(star3);
        }

        private void star4_MouseHover(object sender, EventArgs e)
        {
            SwitchStarImage(star4);
        }

        private void star4_MouseLeave(object sender, EventArgs e)
        {
            SwitchStarImage(star4);
        }

        private void star5_MouseHover(object sender, EventArgs e)
        {
            SwitchStarImage(star5);
        }

        private void star5_MouseLeave(object sender, EventArgs e)
        {
            SwitchStarImage(star5);
        }

        #endregion
    }
}