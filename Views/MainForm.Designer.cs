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
            this.navBar = new System.Windows.Forms.Panel();
            this.iconsPanel = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.searchBar = new filmhub.Views.RoundedTextBox();
            this.accountButton = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dropDownPanel = new System.Windows.Forms.Panel();
            this.favoritesLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.watchListLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.mainPage = new System.Windows.Forms.UserControl();
            this.windowBar = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.navBar.SuspendLayout();
            this.iconsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.accountButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.logoPictureBox)).BeginInit();
            this.dropDownPanel.SuspendLayout();
            this.windowBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.navBar.Controls.Add(this.iconsPanel);
            this.navBar.Controls.Add(this.logoPictureBox);
            this.navBar.Location = new System.Drawing.Point(0, 37);
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
            this.iconsPanel.Size = new System.Drawing.Size(689, 88);
            this.iconsPanel.TabIndex = 4;
            this.iconsPanel.Visible = false;
            this.iconsPanel.Click += new System.EventHandler(this.iconsPanel_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.Image = global::filmhub.Properties.Resources.home;
            this.homeButton.Location = new System.Drawing.Point(23, 19);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(47, 43);
            this.homeButton.TabIndex = 4;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.MouseLeave += new System.EventHandler(this.homeButton_MouseLeave);
            this.homeButton.MouseHover += new System.EventHandler(this.homeButton_MouseHover);
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
            this.accountButton.Image = global::filmhub.Properties.Resources.account;
            this.accountButton.Location = new System.Drawing.Point(637, 19);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(43, 43);
            this.accountButton.TabIndex = 1;
            this.accountButton.TabStop = false;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            this.accountButton.MouseLeave += new System.EventHandler(this.accountButton_MouseLeave);
            this.accountButton.MouseHover += new System.EventHandler(this.accountButton_MouseHover);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Image = global::filmhub.Properties.Resources.search;
            this.searchButton.Location = new System.Drawing.Point(568, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(43, 43);
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = false;
            this.searchButton.MouseLeave += new System.EventHandler(this.searchButton_MouseLeave);
            this.searchButton.MouseHover += new System.EventHandler(this.searchButton_MouseHover);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImage = global::filmhub.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(20, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(311, 64);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // dropDownPanel
            // 
            this.dropDownPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dropDownPanel.Controls.Add(this.favoritesLabel);
            this.dropDownPanel.Controls.Add(this.logoutLabel);
            this.dropDownPanel.Controls.Add(this.watchListLabel);
            this.dropDownPanel.Controls.Add(this.settingsLabel);
            this.dropDownPanel.Controls.Add(this.historyLabel);
            this.dropDownPanel.Location = new System.Drawing.Point(1130, 124);
            this.dropDownPanel.Name = "dropDownPanel";
            this.dropDownPanel.Size = new System.Drawing.Size(134, 195);
            this.dropDownPanel.TabIndex = 10;
            this.dropDownPanel.Visible = false;
            // 
            // favoritesLabel
            // 
            this.favoritesLabel.BackColor = System.Drawing.Color.Transparent;
            this.favoritesLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.favoritesLabel.ForeColor = System.Drawing.Color.White;
            this.favoritesLabel.Location = new System.Drawing.Point(0, 10);
            this.favoritesLabel.Name = "favoritesLabel";
            this.favoritesLabel.Size = new System.Drawing.Size(133, 25);
            this.favoritesLabel.TabIndex = 5;
            this.favoritesLabel.Text = "Favorites";
            this.favoritesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.favoritesLabel.Click += new System.EventHandler(this.favoritesLabel_Click);
            this.favoritesLabel.MouseLeave += new System.EventHandler(this.favoritesLabel_MouseLeave);
            this.favoritesLabel.MouseHover += new System.EventHandler(this.favoritesLabel_MouseHover);
            // 
            // logoutLabel
            // 
            this.logoutLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.logoutLabel.ForeColor = System.Drawing.Color.White;
            this.logoutLabel.Location = new System.Drawing.Point(0, 150);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(133, 29);
            this.logoutLabel.TabIndex = 9;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click);
            this.logoutLabel.MouseLeave += new System.EventHandler(this.logoutLabel_MouseLeave);
            this.logoutLabel.MouseHover += new System.EventHandler(this.logoutLabel_MouseHover);
            // 
            // watchListLabel
            // 
            this.watchListLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.watchListLabel.ForeColor = System.Drawing.Color.White;
            this.watchListLabel.Location = new System.Drawing.Point(0, 45);
            this.watchListLabel.Name = "watchListLabel";
            this.watchListLabel.Size = new System.Drawing.Size(133, 25);
            this.watchListLabel.TabIndex = 6;
            this.watchListLabel.Text = "Watchlist";
            this.watchListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.watchListLabel.Click += new System.EventHandler(this.watchListLabel_Click);
            this.watchListLabel.MouseLeave += new System.EventHandler(this.watchListLabel_MouseLeave);
            this.watchListLabel.MouseHover += new System.EventHandler(this.watchListLabel_MouseHover);
            // 
            // settingsLabel
            // 
            this.settingsLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.settingsLabel.ForeColor = System.Drawing.Color.White;
            this.settingsLabel.Location = new System.Drawing.Point(0, 115);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(133, 29);
            this.settingsLabel.TabIndex = 8;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsLabel.Click += new System.EventHandler(this.settingsLabel_Click);
            this.settingsLabel.MouseLeave += new System.EventHandler(this.settingsLabel_MouseLeave);
            this.settingsLabel.MouseHover += new System.EventHandler(this.settingsLabel_MouseHover);
            // 
            // historyLabel
            // 
            this.historyLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.historyLabel.ForeColor = System.Drawing.Color.White;
            this.historyLabel.Location = new System.Drawing.Point(0, 80);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(133, 29);
            this.historyLabel.TabIndex = 7;
            this.historyLabel.Text = "History";
            this.historyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.historyLabel.Click += new System.EventHandler(this.historyLabel_Click);
            this.historyLabel.MouseLeave += new System.EventHandler(this.historyLabel_MouseLeave);
            this.historyLabel.MouseHover += new System.EventHandler(this.historyLabel_MouseHover);
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPage.Location = new System.Drawing.Point(0, 125);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(1264, 595);
            this.mainPage.TabIndex = 1;
            // 
            // windowBar
            // 
            this.windowBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.windowBar.Controls.Add(this.minimize);
            this.windowBar.Controls.Add(this.close);
            this.windowBar.Location = new System.Drawing.Point(0, 0);
            this.windowBar.Name = "windowBar";
            this.windowBar.Size = new System.Drawing.Size(1264, 37);
            this.windowBar.TabIndex = 11;
            this.windowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowBar_MouseDown);
            this.windowBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowBar_MouseMove);
            this.windowBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.windowBar_MouseUp);
            // 
            // minimize
            // 
            this.minimize.Image = global::filmhub.Properties.Resources.minimize;
            this.minimize.Location = new System.Drawing.Point(1191, 5);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(23, 26);
            this.minimize.TabIndex = 1;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover);
            // 
            // close
            // 
            this.close.Image = global::filmhub.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(1229, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 26);
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 720);
            this.Controls.Add(this.windowBar);
            this.Controls.Add(this.dropDownPanel);
            this.Controls.Add(this.mainPage);
            this.Controls.Add(this.navBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.windowBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.close)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel windowBar;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Panel dropDownPanel;
        private System.Windows.Forms.Panel iconsPanel;
        private System.Windows.Forms.Label watchListLabel;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Label favoritesLabel;
        private filmhub.Views.RoundedTextBox searchBar;
        private System.Windows.Forms.UserControl mainPage;
        private System.Windows.Forms.PictureBox accountButton;
        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        #endregion
    }
}