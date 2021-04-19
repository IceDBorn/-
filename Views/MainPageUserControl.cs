using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using filmhub.Properties;
using Npgsql;

namespace filmhub.Views
{
    public partial class MainPageUserControl : UserControl
    {
        #region Fields

        private int[] _featuredMovies;

        #endregion

        #region Constructor
        
        public MainPageUserControl()
        {
            InitializeComponent();
            InitializeColors();
            categoriesPanel.Controls.Clear();
            categoriesPanel.Controls.Add(new CategoriesUserControl());
        }
        
        #endregion

        #region Methods
        
        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            menu.BackColor = Program.Colors.BackgroundColor;
            categoriesPanel.BackColor = Program.Colors.PopOutBackgroundColor;
            FeaturedMovieSelector();
        }
        
        private static Image DownloadImageFromUrl(string imageUrl)
        {
            Image image;

            try
            {
                var webRequest = (HttpWebRequest) WebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                var webResponse = webRequest.GetResponse();

                var stream = webResponse.GetResponseStream();

                image = Image.FromStream(stream ?? throw new InvalidOperationException());

                webResponse.Close();
            }
            catch
            {
                return null;
            }

            return image;
        }

        private void FeaturedMovieSelector()
        {
            try
            {
                var con = DatabaseController.getConnection();
                con.Open();

                const string query = "SELECT id,picture FROM movie ORDER BY RANDOM() LIMIT 5";

                using var cmd = new NpgsqlCommand(query, con);
                using var rdr = cmd.ExecuteReader();
                
                var count = 0;
                _featuredMovies = new int[6];

                while (rdr.Read())
                {
                    _featuredMovies[count] = rdr.GetInt32(0);
                    moviesList.Images.Add(DownloadImageFromUrl(rdr.GetString(1)));
                    count++;
                }

                var pictureBoxes = new[]
                    {featuredImage1, featuredImage2, featuredImage3, featuredImage4, featuredImage5};

                for (var i = 0; i < pictureBoxes.Length; i++)
                {
                    pictureBoxes[i].Image = moviesList.Images[i];
                }
            }
            catch
            {
                MessageBox.Show(@"Something went wrong.");
            }
        }

        #endregion

        #region Events

        private void menu_Click(object sender, EventArgs e)
        {
            categoriesPanel.Visible = true;
            Program.MainForm.HideDropDown();
        }

        private void MainPageUserControl_Click(object sender, EventArgs e)
        {
            categoriesPanel.Visible = false;
            Program.MainForm.HideDropDown();
        }

        
        private void menu_MouseHover(object sender, EventArgs e)
        {
            menu.Image = Resources.menu_hover;
            GC.Collect();
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.Image = Resources.menu;
            GC.Collect();
        }
        
        #endregion

        private void featuredImage1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(_featuredMovies[0].ToString());
        }
    }
}