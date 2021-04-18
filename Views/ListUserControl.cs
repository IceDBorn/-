using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using filmhub.Controllers;
using filmhub.Properties;
using Npgsql;

namespace filmhub.Views
{
    public partial class ListUserControl : UserControl
    {
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

        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            moviesList.BackColor = Program.Colors.BackgroundColor;
            moviesList.ForeColor = Color.White;
        }

        private void Search(string result)
        {
            var sE = new SearchController("./IndexedDatabase");
            if (!Directory.Exists("./IndexedDatabase") || IsDirectoryEmpty("./IndexedDatabase")) SearchController.createIndex();
            var list = new List<int>(SearchController.SearchIdResults(result));
            
            try
            {
                var con = DatabaseController.getConnection();
                con.Open();
                
                moviesList.Columns.Add("", -2, HorizontalAlignment.Left);
                
                foreach (var query in list.Select(i => "SELECT name FROM movie WHERE id = " + i))
                {
                    using var cmd = new NpgsqlCommand(query, con);
                    using var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        var rand = new Random();
                        var index = rand.Next(0, 20);
                        var item = new ListViewItem(new[] {"     " +rdr.GetString(0)}) {ImageIndex = index};
                        moviesList.Items.Add(item);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

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

        private static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }
    }
}