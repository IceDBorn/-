using System.ComponentModel;

namespace filmhub.Views
{
    partial class MainPageUserControl
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
            this.featuredImage1 = new System.Windows.Forms.PictureBox();
            this.featured = new System.Windows.Forms.Label();
            this.comingSoon = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.categoriesPanel = new System.Windows.Forms.UserControl();
            this.featuredImage2 = new System.Windows.Forms.PictureBox();
            this.featuredImage3 = new System.Windows.Forms.PictureBox();
            this.featuredImage4 = new System.Windows.Forms.PictureBox();
            this.featuredImage5 = new System.Windows.Forms.PictureBox();
            this.comingSoonImage1 = new System.Windows.Forms.PictureBox();
            this.comingSoonImage2 = new System.Windows.Forms.PictureBox();
            this.comingSoonImage3 = new System.Windows.Forms.PictureBox();
            this.comingSoonImage4 = new System.Windows.Forms.PictureBox();
            this.comingSoonImage5 = new System.Windows.Forms.PictureBox();
            this.moviesList = new System.Windows.Forms.ImageList(this.components);
            this.loadingLabel = new System.Windows.Forms.Label();
            this.loadingLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.comingSoonImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.comingSoonImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.comingSoonImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.comingSoonImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.comingSoonImage5)).BeginInit();
            this.SuspendLayout();
            // 
            // featuredImage1
            // 
            this.featuredImage1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.featuredImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featuredImage1.Location = new System.Drawing.Point(78, 96);
            this.featuredImage1.Name = "featuredImage1";
            this.featuredImage1.Size = new System.Drawing.Size(150, 200);
            this.featuredImage1.TabIndex = 0;
            this.featuredImage1.TabStop = false;
            this.featuredImage1.Tag = "0";
            this.featuredImage1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.featuredImage1_MouseClick);
            // 
            // featured
            // 
            this.featured.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.featured.ForeColor = System.Drawing.Color.White;
            this.featured.Location = new System.Drawing.Point(68, 21);
            this.featured.Name = "featured";
            this.featured.Size = new System.Drawing.Size(287, 58);
            this.featured.TabIndex = 1;
            this.featured.Text = "Featured";
            // 
            // comingSoon
            // 
            this.comingSoon.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.comingSoon.ForeColor = System.Drawing.Color.White;
            this.comingSoon.Location = new System.Drawing.Point(68, 305);
            this.comingSoon.Name = "comingSoon";
            this.comingSoon.Size = new System.Drawing.Size(287, 58);
            this.comingSoon.TabIndex = 6;
            this.comingSoon.Text = "Coming soon";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.Image = global::filmhub.Properties.Resources.menu;
            this.menu.Location = new System.Drawing.Point(15, 20);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(46, 44);
            this.menu.TabIndex = 14;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            this.menu.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.menu.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // categoriesPanel
            // 
            this.categoriesPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.categoriesPanel.Location = new System.Drawing.Point(0, 0);
            this.categoriesPanel.Name = "categoriesPanel";
            this.categoriesPanel.Size = new System.Drawing.Size(248, 595);
            this.categoriesPanel.TabIndex = 15;
            this.categoriesPanel.Visible = false;
            // 
            // featuredImage2
            // 
            this.featuredImage2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.featuredImage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featuredImage2.Location = new System.Drawing.Point(315, 96);
            this.featuredImage2.Name = "featuredImage2";
            this.featuredImage2.Size = new System.Drawing.Size(150, 200);
            this.featuredImage2.TabIndex = 16;
            this.featuredImage2.TabStop = false;
            this.featuredImage2.Tag = "0";
            this.featuredImage2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.featuredImage2_MouseClick);
            // 
            // featuredImage3
            // 
            this.featuredImage3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.featuredImage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featuredImage3.Location = new System.Drawing.Point(557, 96);
            this.featuredImage3.Name = "featuredImage3";
            this.featuredImage3.Size = new System.Drawing.Size(150, 200);
            this.featuredImage3.TabIndex = 17;
            this.featuredImage3.TabStop = false;
            this.featuredImage3.Tag = "0";
            this.featuredImage3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.featuredImage3_MouseClick);
            // 
            // featuredImage4
            // 
            this.featuredImage4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.featuredImage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featuredImage4.Location = new System.Drawing.Point(796, 96);
            this.featuredImage4.Name = "featuredImage4";
            this.featuredImage4.Size = new System.Drawing.Size(150, 200);
            this.featuredImage4.TabIndex = 18;
            this.featuredImage4.TabStop = false;
            this.featuredImage4.Tag = "0";
            this.featuredImage4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.featuredImage4_MouseClick);
            // 
            // featuredImage5
            // 
            this.featuredImage5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.featuredImage5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featuredImage5.Location = new System.Drawing.Point(1036, 96);
            this.featuredImage5.Name = "featuredImage5";
            this.featuredImage5.Size = new System.Drawing.Size(150, 200);
            this.featuredImage5.TabIndex = 19;
            this.featuredImage5.TabStop = false;
            this.featuredImage5.Tag = "0";
            this.featuredImage5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.featuredImage5_MouseClick);
            // 
            // comingSoonImage1
            // 
            this.comingSoonImage1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comingSoonImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comingSoonImage1.Location = new System.Drawing.Point(78, 366);
            this.comingSoonImage1.Name = "comingSoonImage1";
            this.comingSoonImage1.Size = new System.Drawing.Size(150, 200);
            this.comingSoonImage1.TabIndex = 20;
            this.comingSoonImage1.TabStop = false;
            this.comingSoonImage1.Tag = "0";
            this.comingSoonImage1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comingSoonImage1_MouseClick);
            // 
            // comingSoonImage2
            // 
            this.comingSoonImage2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comingSoonImage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comingSoonImage2.Location = new System.Drawing.Point(315, 366);
            this.comingSoonImage2.Name = "comingSoonImage2";
            this.comingSoonImage2.Size = new System.Drawing.Size(150, 200);
            this.comingSoonImage2.TabIndex = 21;
            this.comingSoonImage2.TabStop = false;
            this.comingSoonImage2.Tag = "0";
            this.comingSoonImage2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comingSoonImage2_MouseClick);
            // 
            // comingSoonImage3
            // 
            this.comingSoonImage3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comingSoonImage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comingSoonImage3.Location = new System.Drawing.Point(557, 366);
            this.comingSoonImage3.Name = "comingSoonImage3";
            this.comingSoonImage3.Size = new System.Drawing.Size(150, 200);
            this.comingSoonImage3.TabIndex = 22;
            this.comingSoonImage3.TabStop = false;
            this.comingSoonImage3.Tag = "0";
            this.comingSoonImage3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comingSoonImage3_MouseClick);
            // 
            // comingSoonImage4
            // 
            this.comingSoonImage4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comingSoonImage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comingSoonImage4.Location = new System.Drawing.Point(796, 366);
            this.comingSoonImage4.Name = "comingSoonImage4";
            this.comingSoonImage4.Size = new System.Drawing.Size(150, 200);
            this.comingSoonImage4.TabIndex = 23;
            this.comingSoonImage4.TabStop = false;
            this.comingSoonImage4.Tag = "0";
            this.comingSoonImage4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comingSoonImage4_MouseClick);
            // 
            // comingSoonImage5
            // 
            this.comingSoonImage5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comingSoonImage5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comingSoonImage5.Location = new System.Drawing.Point(1036, 366);
            this.comingSoonImage5.Name = "comingSoonImage5";
            this.comingSoonImage5.Size = new System.Drawing.Size(150, 200);
            this.comingSoonImage5.TabIndex = 24;
            this.comingSoonImage5.TabStop = false;
            this.comingSoonImage5.Tag = "0";
            this.comingSoonImage5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comingSoonImage5_MouseClick);
            // 
            // moviesList
            // 
            this.moviesList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.moviesList.ImageSize = new System.Drawing.Size(150, 200);
            this.moviesList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // loadingLabel
            // 
            this.loadingLabel.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.loadingLabel.ForeColor = System.Drawing.Color.White;
            this.loadingLabel.Location = new System.Drawing.Point(557, 172);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(150, 58);
            this.loadingLabel.TabIndex = 25;
            this.loadingLabel.Text = "Loading";
            this.loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingLabel2
            // 
            this.loadingLabel2.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.loadingLabel2.ForeColor = System.Drawing.Color.White;
            this.loadingLabel2.Location = new System.Drawing.Point(557, 437);
            this.loadingLabel2.Name = "loadingLabel2";
            this.loadingLabel2.Size = new System.Drawing.Size(150, 58);
            this.loadingLabel2.TabIndex = 26;
            this.loadingLabel2.Text = "Loading";
            this.loadingLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.loadingLabel2);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.comingSoonImage5);
            this.Controls.Add(this.comingSoonImage4);
            this.Controls.Add(this.comingSoonImage3);
            this.Controls.Add(this.comingSoonImage2);
            this.Controls.Add(this.comingSoonImage1);
            this.Controls.Add(this.featuredImage5);
            this.Controls.Add(this.featuredImage4);
            this.Controls.Add(this.featuredImage3);
            this.Controls.Add(this.featuredImage2);
            this.Controls.Add(this.categoriesPanel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.featuredImage1);
            this.Controls.Add(this.comingSoon);
            this.Controls.Add(this.featured);
            this.Name = "MainPageUserControl";
            this.Size = new System.Drawing.Size(1264, 595);
            this.Click += new System.EventHandler(this.MainPageUserControl_Click);
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.comingSoonImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.comingSoonImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.comingSoonImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.comingSoonImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.comingSoonImage5)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label loadingLabel2;

        private System.Windows.Forms.Label loadingLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ImageList moviesList;

        private System.Windows.Forms.PictureBox comingSoonImage1;
        private System.Windows.Forms.PictureBox comingSoonImage2;
        private System.Windows.Forms.PictureBox comingSoonImage3;
        private System.Windows.Forms.PictureBox comingSoonImage4;
        private System.Windows.Forms.PictureBox comingSoonImage5;

        private System.Windows.Forms.PictureBox featuredImage2;
        private System.Windows.Forms.PictureBox featuredImage3;
        private System.Windows.Forms.PictureBox featuredImage4;
        private System.Windows.Forms.PictureBox featuredImage5;

        private System.Windows.Forms.UserControl categoriesPanel;

        private System.Windows.Forms.PictureBox menu;

        private System.Windows.Forms.Label comingSoon;

        private System.Windows.Forms.Label featured;

        private System.Windows.Forms.PictureBox featuredImage1;

        #endregion
    }
}