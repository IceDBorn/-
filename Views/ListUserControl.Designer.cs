using System.ComponentModel;

namespace filmhub.Views
{
    partial class ListUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUserControl));
            this.window = new System.Windows.Forms.Label();
            this.moviesList = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.menu = new System.Windows.Forms.PictureBox();
            this.categoriesPanel = new System.Windows.Forms.UserControl();
            ((System.ComponentModel.ISupportInitialize) (this.menu)).BeginInit();
            this.SuspendLayout();
            // 
            // window
            // 
            this.window.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.window.ForeColor = System.Drawing.Color.White;
            this.window.Location = new System.Drawing.Point(75, 22);
            this.window.Name = "window";
            this.window.Size = new System.Drawing.Size(911, 49);
            this.window.TabIndex = 0;
            this.window.Text = "Window\r\n\r\n";
            // 
            // moviesList
            // 
            this.moviesList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.moviesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moviesList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.moviesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.moviesList.Location = new System.Drawing.Point(75, 114);
            this.moviesList.Name = "moviesList";
            this.moviesList.Size = new System.Drawing.Size(1189, 480);
            this.moviesList.SmallImageList = this.imageList;
            this.moviesList.TabIndex = 1;
            this.moviesList.UseCompatibleStateImageBehavior = false;
            this.moviesList.View = System.Windows.Forms.View.Details;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "account.png");
            this.imageList.Images.SetKeyName(1, "account_hover.png");
            this.imageList.Images.SetKeyName(2, "back.png");
            this.imageList.Images.SetKeyName(3, "back_hover.png");
            this.imageList.Images.SetKeyName(4, "background.jpg");
            this.imageList.Images.SetKeyName(5, "background_slogan.jpg");
            this.imageList.Images.SetKeyName(6, "close.png");
            this.imageList.Images.SetKeyName(7, "close_hover.png");
            this.imageList.Images.SetKeyName(8, "home.png");
            this.imageList.Images.SetKeyName(9, "home_hover.png");
            this.imageList.Images.SetKeyName(10, "icon.ico");
            this.imageList.Images.SetKeyName(11, "logo.png");
            this.imageList.Images.SetKeyName(12, "menu.png");
            this.imageList.Images.SetKeyName(13, "menu_hover.png");
            this.imageList.Images.SetKeyName(14, "minimize.png");
            this.imageList.Images.SetKeyName(15, "minimize_hover.png");
            this.imageList.Images.SetKeyName(16, "search.png");
            this.imageList.Images.SetKeyName(17, "search_hover.png");
            this.imageList.Images.SetKeyName(18, "star.png");
            this.imageList.Images.SetKeyName(19, "star_empty.png");
            this.imageList.Images.SetKeyName(20, "star_hover.png");
            // 
            // menu
            // 
            this.menu.Image = global::filmhub.Properties.Resources.menu;
            this.menu.Location = new System.Drawing.Point(17, 22);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(52, 49);
            this.menu.TabIndex = 2;
            this.menu.TabStop = false;
            this.menu.Visible = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            this.menu.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.menu.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // categoriesPanel
            // 
            this.categoriesPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.categoriesPanel.Location = new System.Drawing.Point(0, 0);
            this.categoriesPanel.Name = "categoriesPanel";
            this.categoriesPanel.Size = new System.Drawing.Size(248, 592);
            this.categoriesPanel.TabIndex = 3;
            this.categoriesPanel.Visible = false;
            // 
            // ListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.categoriesPanel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.moviesList);
            this.Controls.Add(this.window);
            this.Name = "ListUserControl";
            this.Size = new System.Drawing.Size(1264, 595);
            ((System.ComponentModel.ISupportInitialize) (this.menu)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ImageList imageList;

        private System.Windows.Forms.UserControl categoriesPanel;

        private System.Windows.Forms.PictureBox menu;

        private System.Windows.Forms.Label window;
        private System.Windows.Forms.ListView moviesList;

        #endregion
    }
}