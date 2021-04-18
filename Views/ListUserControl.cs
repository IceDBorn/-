using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using filmhub.Controllers;
using filmhub.Properties;
using Npgsql;

namespace filmhub.Views
{
    public partial class ListUserControl : UserControl
    {
        #region Constructors

        public ListUserControl(string title, bool menu, string result)
        {
            InitializeComponent();
            InitializeColors();
            this.menu.Visible = menu;
            window.Text = title;
            Search(result);
        }

        public ListUserControl(string title, bool menu)
        {
            InitializeComponent();
            InitializeColors();
            this.menu.Visible = menu;
            window.Text = title;
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            moviesList.BackColor = Program.Colors.BackgroundColor;
            moviesList.ForeColor = Color.White;
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

        private void FillListView(IEnumerable<int> list)
        {
            imageList.Images.Clear();
            try
            {
                var con = DatabaseController.getConnection();
                con.Open();

                moviesList.Columns.Add("", -2, HorizontalAlignment.Left);
                var count = 0;

                foreach (var query in list.Select(i => "SELECT name,picture FROM movie WHERE id = " + i))
                {
                    using var cmd = new NpgsqlCommand(query, con);
                    using var rdr = cmd.ExecuteReader();
                    
                    while (rdr.Read())
                    {
                        
                        try
                        {
                            imageList.Images.Add(DownloadImageFromUrl(rdr.GetString(1)));
                        }
                        catch
                        {
                            // ignored
                        }
                        
                        var item = new ListViewItem(new[] {"     " + rdr.GetString(0)}) {ImageIndex = count};
                        moviesList.Items.Add(item);
                    }

                    count++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Search(string result)
        {
            FillListView(SearchController.CreateIndexFolder(result));
        }

        #endregion

        #region Events

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.Image = Resources.menu;
            GC.Collect();
        }

        private void menu_MouseHover(object sender, EventArgs e)
        {
            menu.Image = Resources.menu_hover;
            GC.Collect();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            categoriesPanel.Controls.Clear();
            categoriesPanel.Controls.Add(new CategoriesUserControl());
            categoriesPanel.Visible = true;
        }

        #endregion
    }
}