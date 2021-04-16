using System.ComponentModel;

namespace filmhub.Views
{
    partial class ListMoviesUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.search = new System.Windows.Forms.Label();
            this.Movies = new System.Windows.Forms.ColumnHeader();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.listViewSearch = new System.Windows.Forms.ListView();
            this.button = new System.Windows.Forms.ColumnHeader();
            this.menu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.menu)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(68, 21);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(258, 44);
            this.search.TabIndex = 0;
            this.search.Text = "windowType";
            // 
            // Movies
            // 
            this.Movies.Text = "Image";
            this.Movies.Width = 394;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 352;
            // 
            // listViewSearch
            // 
            this.listViewSearch.BackColor = System.Drawing.Color.White;
            this.listViewSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.Movies, this.Title, this.button});
            this.listViewSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.listViewSearch.Location = new System.Drawing.Point(72, 106);
            this.listViewSearch.Name = "listViewSearch";
            this.listViewSearch.Size = new System.Drawing.Size(1117, 422);
            this.listViewSearch.TabIndex = 2;
            this.listViewSearch.UseCompatibleStateImageBehavior = false;
            this.listViewSearch.View = System.Windows.Forms.View.Details;
            // 
            // button
            // 
            this.button.Text = "Button";
            this.button.Width = 413;
            // 
            // menu
            // 
            this.menu.Image = global::filmhub.Properties.Resources.menu;
            this.menu.Location = new System.Drawing.Point(14, 21);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(57, 46);
            this.menu.TabIndex = 3;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            this.menu.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.menu.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // ListMoviesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.menu);
            this.Controls.Add(this.listViewSearch);
            this.Controls.Add(this.search);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ListMoviesUserControl";
            this.Size = new System.Drawing.Size(1264, 595);
            ((System.ComponentModel.ISupportInitialize) (this.menu)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox menu;

        private System.Windows.Forms.ColumnHeader button;

        private System.Windows.Forms.ListView listViewSearch;
        private System.Windows.Forms.ColumnHeader Movies;
        private System.Windows.Forms.ColumnHeader Title;

        private System.Windows.Forms.Label search;

        #endregion
    }
}