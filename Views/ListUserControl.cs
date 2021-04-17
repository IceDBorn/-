using System;
using System.Collections.Generic;
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
            SearchEngine.createIndex();
            var sE = new SearchEngine("./IndexedDatabase");
            var list = new List<int>(sE.SearchIdResults(result));
            
            try
            {
                var con = DatabaseController.getConnection();
                con.Open();
                foreach (var i in list)
                {
                    var query = "SELECT name FROM movie WHERE id = " + i;
                    using var cmd = new NpgsqlCommand(query, con);
                    using var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listView1.Items.Add(rdr.GetString(0));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
            listView1.BackColor = Program.Colors.BackgroundColor;
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
    }
}