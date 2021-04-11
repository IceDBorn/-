namespace filmhub
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navBar = new System.Windows.Forms.Panel();
            this.searchBar = new filmhub.RoundedTextBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.accountButton = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPage = new System.Windows.Forms.UserControl();
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.accountButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.navBar.Controls.Add(this.searchBar);
            this.navBar.Controls.Add(this.searchButton);
            this.navBar.Controls.Add(this.accountButton);
            this.navBar.Controls.Add(this.logoPictureBox);
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(1264, 100);
            this.navBar.TabIndex = 0;
            // 
            // searchBar
            // 
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.searchBar.Location = new System.Drawing.Point(660, 28);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(450, 43);
            this.searchBar.TabIndex = 3;
            this.searchBar.TabStop = false;
            this.searchBar.Text = " Enter your search";
            this.searchBar.Enter += new System.EventHandler(this.searchBar_Enter);
            this.searchBar.Leave += new System.EventHandler(this.searchBar_Leave);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Image = global::filmhub.Properties.Resources.search_button;
            this.searchButton.Location = new System.Drawing.Point(1130, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(43, 43);
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = false;
            // 
            // accountButton
            // 
            this.accountButton.Image = global::filmhub.Properties.Resources.account_button;
            this.accountButton.Location = new System.Drawing.Point(1199, 28);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(43, 43);
            this.accountButton.TabIndex = 1;
            this.accountButton.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::filmhub.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(356, 77);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPage.Location = new System.Drawing.Point(0, 100);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(1264, 581);
            this.mainPage.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainPage);
            this.Controls.Add(this.navBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmHub";
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.accountButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private filmhub.RoundedTextBox searchBar;

        private System.Windows.Forms.UserControl mainPage;

        private System.Windows.Forms.PictureBox accountButton;
        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        #endregion
    }
}