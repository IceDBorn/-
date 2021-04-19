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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.moviesList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.featuredImage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // featuredImage1
            // 
            this.featuredImage1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.featuredImage1.Location = new System.Drawing.Point(78, 96);
            this.featuredImage1.Name = "featuredImage1";
            this.featuredImage1.Size = new System.Drawing.Size(150, 200);
            this.featuredImage1.TabIndex = 0;
            this.featuredImage1.TabStop = false;
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
            this.categoriesPanel.Location = new System.Drawing.Point(217, 20);
            this.categoriesPanel.Name = "categoriesPanel";
            this.categoriesPanel.Size = new System.Drawing.Size(248, 592);
            this.categoriesPanel.TabIndex = 15;
            this.categoriesPanel.Visible = false;
            // 
            // featuredImage2
            // 
            this.featuredImage2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.featuredImage2.Location = new System.Drawing.Point(315, 96);
            this.featuredImage2.Name = "featuredImage2";
            this.featuredImage2.Size = new System.Drawing.Size(150, 200);
            this.featuredImage2.TabIndex = 16;
            this.featuredImage2.TabStop = false;
            // 
            // featuredImage3
            // 
            this.featuredImage3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.featuredImage3.Location = new System.Drawing.Point(557, 96);
            this.featuredImage3.Name = "featuredImage3";
            this.featuredImage3.Size = new System.Drawing.Size(150, 200);
            this.featuredImage3.TabIndex = 17;
            this.featuredImage3.TabStop = false;
            // 
            // featuredImage4
            // 
            this.featuredImage4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.featuredImage4.Location = new System.Drawing.Point(796, 96);
            this.featuredImage4.Name = "featuredImage4";
            this.featuredImage4.Size = new System.Drawing.Size(150, 200);
            this.featuredImage4.TabIndex = 18;
            this.featuredImage4.TabStop = false;
            // 
            // featuredImage5
            // 
            this.featuredImage5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.featuredImage5.Location = new System.Drawing.Point(1036, 96);
            this.featuredImage5.Name = "featuredImage5";
            this.featuredImage5.Size = new System.Drawing.Size(150, 200);
            this.featuredImage5.TabIndex = 19;
            this.featuredImage5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(78, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 200);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(315, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 200);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox3.Location = new System.Drawing.Point(557, 366);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 200);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox4.Location = new System.Drawing.Point(796, 366);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 200);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox5.Location = new System.Drawing.Point(1036, 366);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 200);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // moviesList
            // 
            this.moviesList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.moviesList.ImageSize = new System.Drawing.Size(150, 200);
            this.moviesList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ImageList moviesList;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;

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