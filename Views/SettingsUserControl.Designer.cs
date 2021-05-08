using System.ComponentModel;
using filmhub.Controls;

namespace filmhub.Views
{
    partial class SettingsUserControl
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
            this.settingsLabel = new System.Windows.Forms.Label();
            this.userProfileImage = new System.Windows.Forms.PictureBox();
            this.uploadButton = new filmhub.Controls.RoundButton();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.saveButton = new filmhub.Controls.RoundButton();
            this.resetButton = new filmhub.Controls.RoundButton();
            this.passwordTextBox = new filmhub.Controls.RoundTextBox();
            this.confirmPasswordTextBox = new filmhub.Controls.RoundTextBox();
            this.usernameValueLabel = new System.Windows.Forms.Label();
            this.photoBrowser = new System.Windows.Forms.OpenFileDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.themeImage = new System.Windows.Forms.PictureBox();
            this.uploadingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.userProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.themeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            this.settingsLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.settingsLabel.ForeColor = System.Drawing.Color.White;
            this.settingsLabel.Location = new System.Drawing.Point(68, 21);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(178, 58);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.Text = "Settings";
            // 
            // userProfileImage
            // 
            this.userProfileImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.userProfileImage.Image = global::filmhub.Properties.Resources.default_user;
            this.userProfileImage.Location = new System.Drawing.Point(78, 169);
            this.userProfileImage.Name = "userProfileImage";
            this.userProfileImage.Size = new System.Drawing.Size(150, 200);
            this.userProfileImage.TabIndex = 2;
            this.userProfileImage.TabStop = false;
            // 
            // uploadButton
            // 
            this.uploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.uploadButton.ForeColor = System.Drawing.Color.White;
            this.uploadButton.Location = new System.Drawing.Point(78, 393);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(150, 28);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.TabStop = false;
            this.uploadButton.Text = "Upload a photo";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(300, 160);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(169, 39);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(300, 250);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(250, 39);
            this.changeLabel.TabIndex = 6;
            this.changeLabel.Text = "Change password:";
            // 
            // confirmLabel
            // 
            this.confirmLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.confirmLabel.ForeColor = System.Drawing.Color.White;
            this.confirmLabel.Location = new System.Drawing.Point(300, 340);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(258, 39);
            this.confirmLabel.TabIndex = 7;
            this.confirmLabel.Text = "Confirm password:";
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(564, 427);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(190, 40);
            this.saveButton.TabIndex = 9;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseClick);
            // 
            // resetButton
            // 
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(787, 427);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(190, 40);
            this.resetButton.TabIndex = 10;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.passwordTextBox.Location = new System.Drawing.Point(564, 249);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(413, 43);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(564, 339);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(413, 43);
            this.confirmPasswordTextBox.TabIndex = 12;
            this.confirmPasswordTextBox.TabStop = false;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameValueLabel
            // 
            this.usernameValueLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.usernameValueLabel.ForeColor = System.Drawing.Color.White;
            this.usernameValueLabel.Location = new System.Drawing.Point(564, 160);
            this.usernameValueLabel.Name = "usernameValueLabel";
            this.usernameValueLabel.Size = new System.Drawing.Size(1067, 39);
            this.usernameValueLabel.TabIndex = 13;
            this.usernameValueLabel.Text = "username";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(150, 200);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // themeImage
            // 
            this.themeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themeImage.Image = global::filmhub.Properties.Resources.dark;
            this.themeImage.Location = new System.Drawing.Point(1183, 30);
            this.themeImage.Name = "themeImage";
            this.themeImage.Size = new System.Drawing.Size(47, 49);
            this.themeImage.TabIndex = 14;
            this.themeImage.TabStop = false;
            this.themeImage.Tag = "";
            this.themeImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.themeImage_MouseClick);
            this.themeImage.MouseLeave += new System.EventHandler(this.themeImage_MouseLeave);
            this.themeImage.MouseHover += new System.EventHandler(this.themeImage_MouseHover);
            // 
            // uploadingLabel
            // 
            this.uploadingLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.uploadingLabel.ForeColor = System.Drawing.Color.White;
            this.uploadingLabel.Location = new System.Drawing.Point(78, 259);
            this.uploadingLabel.Name = "uploadingLabel";
            this.uploadingLabel.Size = new System.Drawing.Size(150, 27);
            this.uploadingLabel.TabIndex = 26;
            this.uploadingLabel.Text = "Uploading...";
            this.uploadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadingLabel.Visible = false;
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.uploadingLabel);
            this.Controls.Add(this.themeImage);
            this.Controls.Add(this.usernameValueLabel);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.userProfileImage);
            this.Controls.Add(this.settingsLabel);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(1264, 581);
            this.MouseHover += new System.EventHandler(this.SettingsUserControl_MouseHover);
            ((System.ComponentModel.ISupportInitialize) (this.userProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.themeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label uploadingLabel;

        private System.Windows.Forms.PictureBox themeImage;

        private System.Windows.Forms.ImageList imageList;

        private System.Windows.Forms.OpenFileDialog photoBrowser;

        private RoundTextBox passwordTextBox;

        private RoundTextBox confirmPasswordTextBox;

        private System.Windows.Forms.Label usernameValueLabel;

        private RoundButton saveButton;
        
        private RoundButton resetButton;

        private System.Windows.Forms.Label confirmLabel;

        private System.Windows.Forms.Label changeLabel;

        private System.Windows.Forms.Label usernameLabel;

        private RoundButton uploadButton;

        private System.Windows.Forms.PictureBox userProfileImage;

        private System.Windows.Forms.Label settingsLabel;

        #endregion
    }
}