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
        #region Fields

        private int[] _moviesId;
        
        private Image _menu;
        private Image _menuHover;

        #endregion

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
            InitializeImages();
            this.menu.Visible = menu;
            window.Text = title;
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            moviesList.BackColor = Program.Colors.BackgroundColor;
            moviesList.ForeColor = Program.Colors.ForeColor;
            window.ForeColor = Program.Colors.ForeColor;
        }

        private void InitializeImages()
        {
            _menu = Settings.Default.Theme == 0 ? Resources.menu : Resources.menu_black;
            menu.Image = _menu;
            _menuHover = Resources.menu_hover;
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
                var con = DatabaseController.GetConnection();

                moviesList.Columns.Add("", -2, HorizontalAlignment.Left);
                const string query = "SELECT name,picture FROM movie WHERE id = ";

                var enumerable = list as int[] ?? list.ToArray();

                _moviesId = new int[enumerable.Length];


                for (var i = 0; i < enumerable.Length; i++)
                {
                    using var cmd = new NpgsqlCommand(query + enumerable[i], con);
                    using var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        try
                        {
                            _moviesId[i] = enumerable[i];
                            imageList.Images.Add(DownloadImageFromUrl(rdr.GetString(1)));
                        }
                        catch
                        {
                            // ignored
                        }

                        var item = new ListViewItem(new[] {"     " + rdr.GetString(0)}) {ImageIndex = i};
                        moviesList.Items.Add(item);
                    }
                    rdr.Close();
                }

                if (moviesList.Items.Count == 0) window.Text = @"No search results";
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
            menu.Image = _menu;
            GC.Collect();
        }

        private void menu_MouseHover(object sender, EventArgs e)
        {
            menu.Image = _menuHover;
            GC.Collect();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            categoriesPanel.Controls.Clear();
            categoriesPanel.Controls.Add(new CategoriesUserControl());
            categoriesPanel.Visible = true;
        }

        private void moviesList_ItemActivate(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(
                new MovieViewerUserControl(imageList.Images[moviesList.SelectedItems[0].Index],
                    _moviesId[moviesList.SelectedItems[0].Index]), true);
        }
        
        private void window_MouseClick(object sender, MouseEventArgs e)
        {
            categoriesPanel.Visible = false;
        }

        private void ListUserControl_MouseClick(object sender, MouseEventArgs e)
        {
            categoriesPanel.Visible = false;
        }

        #endregion
    }
}