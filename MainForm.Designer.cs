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
            this.panel1 = new System.Windows.Forms.Panel();
            this.faves = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.watchlist = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Label();
            this.mainPage = new System.Windows.Forms.UserControl();
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.accountButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.logoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.faves);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.watchlist);
            this.panel1.Controls.Add(this.settings);
            this.panel1.Controls.Add(this.history);
            this.panel1.Location = new System.Drawing.Point(1146, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 162);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // faves
            // 
            this.faves.BackColor = System.Drawing.Color.Transparent;
            this.faves.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.faves.ForeColor = System.Drawing.Color.White;
            this.faves.Location = new System.Drawing.Point(30, 0);
            this.faves.Name = "faves";
            this.faves.Size = new System.Drawing.Size(89, 31);
            this.faves.TabIndex = 5;
            this.faves.Text = "Favorites";
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(33, 120);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(89, 32);
            this.logout.TabIndex = 9;
            this.logout.Text = "Log out";
            // 
            // watchlist
            // 
            this.watchlist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.watchlist.ForeColor = System.Drawing.Color.White;
            this.watchlist.Location = new System.Drawing.Point(33, 31);
            this.watchlist.Name = "watchlist";
            this.watchlist.Size = new System.Drawing.Size(86, 33);
            this.watchlist.TabIndex = 6;
            this.watchlist.Text = "Watchlist";
            // 
            // settings
            // 
            this.settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.Location = new System.Drawing.Point(33, 92);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(89, 28);
            this.settings.TabIndex = 8;
            this.settings.Text = "Settings";
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.history.ForeColor = System.Drawing.Color.White;
            this.history.Location = new System.Drawing.Point(33, 59);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(89, 33);
            this.history.TabIndex = 7;
            this.history.Text = "History";
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
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label watchlist;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.Label settings;
        private System.Windows.Forms.Label logout;

        private System.Windows.Forms.Label faves;

        private filmhub.RoundedTextBox searchBar;

        private System.Windows.Forms.UserControl mainPage;

        private System.Windows.Forms.PictureBox accountButton;
        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        #endregion
    }
}