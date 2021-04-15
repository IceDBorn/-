namespace filmhub.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navBar = new System.Windows.Forms.Panel();
            this.iconsPanel = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.searchBar = new filmhub.Views.RoundedTextBox();
            this.accountButton = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dropDownPanel = new System.Windows.Forms.Panel();
            this.faves = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.watchlist = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Label();
            this.mainPage = new System.Windows.Forms.UserControl();
            this.navBar.SuspendLayout();
            this.iconsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.accountButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.logoPictureBox)).BeginInit();
            this.dropDownPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.navBar.Controls.Add(this.iconsPanel);
            this.navBar.Controls.Add(this.logoPictureBox);
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(1264, 88);
            this.navBar.TabIndex = 0;
            // 
            // iconsPanel
            // 
            this.iconsPanel.Controls.Add(this.homeButton);
            this.iconsPanel.Controls.Add(this.searchBar);
            this.iconsPanel.Controls.Add(this.accountButton);
            this.iconsPanel.Controls.Add(this.searchButton);
            this.iconsPanel.Location = new System.Drawing.Point(563, 0);
            this.iconsPanel.Name = "iconsPanel";
            this.iconsPanel.Size = new System.Drawing.Size(689, 100);
            this.iconsPanel.TabIndex = 4;
            this.iconsPanel.Visible = false;
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.Image = ((System.Drawing.Image) (resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(23, 19);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(47, 43);
            this.homeButton.TabIndex = 4;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.searchBar.Location = new System.Drawing.Point(98, 19);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(450, 43);
            this.searchBar.TabIndex = 3;
            this.searchBar.TabStop = false;
            this.searchBar.Text = " Enter your search";
            this.searchBar.Enter += new System.EventHandler(this.searchBar_Enter);
            this.searchBar.Leave += new System.EventHandler(this.searchBar_Leave);
            // 
            // accountButton
            // 
            this.accountButton.Image = ((System.Drawing.Image) (resources.GetObject("accountButton.Image")));
            this.accountButton.Location = new System.Drawing.Point(637, 19);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(43, 43);
            this.accountButton.TabIndex = 1;
            this.accountButton.TabStop = false;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Image = ((System.Drawing.Image) (resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(568, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(43, 43);
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(349, 50);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // dropDownPanel
            // 
            this.dropDownPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dropDownPanel.Controls.Add(this.faves);
            this.dropDownPanel.Controls.Add(this.logout);
            this.dropDownPanel.Controls.Add(this.watchlist);
            this.dropDownPanel.Controls.Add(this.settings);
            this.dropDownPanel.Controls.Add(this.history);
            this.dropDownPanel.Location = new System.Drawing.Point(1156, 100);
            this.dropDownPanel.Name = "dropDownPanel";
            this.dropDownPanel.Size = new System.Drawing.Size(108, 149);
            this.dropDownPanel.TabIndex = 10;
            this.dropDownPanel.Visible = false;
            // 
            // faves
            // 
            this.faves.BackColor = System.Drawing.Color.Transparent;
            this.faves.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.faves.ForeColor = System.Drawing.Color.White;
            this.faves.Location = new System.Drawing.Point(20, 0);
            this.faves.Name = "faves";
            this.faves.Size = new System.Drawing.Size(76, 31);
            this.faves.TabIndex = 5;
            this.faves.Text = "Favorites";
            this.faves.Click += new System.EventHandler(this.faves_Click);
            this.faves.MouseLeave += new System.EventHandler(this.faves_MouseLeave);
            this.faves.MouseHover += new System.EventHandler(this.faves_MouseHover);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(20, 118);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(89, 32);
            this.logout.TabIndex = 9;
            this.logout.Text = "Log out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseLeave += new System.EventHandler(this.logout_MouseLeave);
            this.logout.MouseHover += new System.EventHandler(this.logout_MouseHover);
            // 
            // watchlist
            // 
            this.watchlist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.watchlist.ForeColor = System.Drawing.Color.White;
            this.watchlist.Location = new System.Drawing.Point(19, 28);
            this.watchlist.Name = "watchlist";
            this.watchlist.Size = new System.Drawing.Size(86, 33);
            this.watchlist.TabIndex = 6;
            this.watchlist.Text = "Watchlist";
            this.watchlist.Click += new System.EventHandler(this.watchlist_Click);
            this.watchlist.MouseLeave += new System.EventHandler(this.watchlist_MouseLeave);
            this.watchlist.MouseHover += new System.EventHandler(this.watchlist_MouseHover);
            // 
            // settings
            // 
            this.settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.Location = new System.Drawing.Point(20, 90);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(89, 28);
            this.settings.TabIndex = 8;
            this.settings.Text = "Settings";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            this.settings.MouseLeave += new System.EventHandler(this.settings_MouseLeave);
            this.settings.MouseHover += new System.EventHandler(this.settings_MouseHover);
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.history.ForeColor = System.Drawing.Color.White;
            this.history.Location = new System.Drawing.Point(20, 59);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(89, 33);
            this.history.TabIndex = 7;
            this.history.Text = "History";
            this.history.Click += new System.EventHandler(this.history_Click);
            this.history.MouseLeave += new System.EventHandler(this.history_MouseLeave);
            this.history.MouseHover += new System.EventHandler(this.history_MouseHover);
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPage.Location = new System.Drawing.Point(0, 88);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(1264, 595);
            this.mainPage.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dropDownPanel);
            this.Controls.Add(this.mainPage);
            this.Controls.Add(this.navBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmHub";
            this.navBar.ResumeLayout(false);
            this.iconsPanel.ResumeLayout(false);
            this.iconsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.accountButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.logoPictureBox)).EndInit();
            this.dropDownPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Panel dropDownPanel;
        private System.Windows.Forms.Panel iconsPanel;
        private System.Windows.Forms.Label watchlist;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.Label settings;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Label faves;
        private filmhub.Views.RoundedTextBox searchBar;
        private System.Windows.Forms.UserControl mainPage;
        private System.Windows.Forms.PictureBox accountButton;
        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        #endregion
    }
}