using System.ComponentModel;

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
            this.uploadButton = new filmhub.Views.RoundedButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.saveButton = new filmhub.Views.RoundedButton();
            this.resetButton = new filmhub.Views.RoundedButton();
            this.changeTextBox = new filmhub.Views.RoundedTextBox();
            this.confirmTextBox = new filmhub.Views.RoundedTextBox();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.emailValueLabel = new System.Windows.Forms.Label();
            this.photoBrowser = new System.Windows.Forms.OpenFileDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.userProfileImage)).BeginInit();
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
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(300, 169);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 39);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(300, 219);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(107, 39);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "E-mail:";
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(300, 269);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(250, 39);
            this.changeLabel.TabIndex = 6;
            this.changeLabel.Text = "Change password:";
            // 
            // confirmLabel
            // 
            this.confirmLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.confirmLabel.ForeColor = System.Drawing.Color.White;
            this.confirmLabel.Location = new System.Drawing.Point(300, 324);
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
            // changeTextBox
            // 
            this.changeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.changeTextBox.Location = new System.Drawing.Point(564, 267);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.Size = new System.Drawing.Size(413, 43);
            this.changeTextBox.TabIndex = 11;
            this.changeTextBox.TabStop = false;
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.confirmTextBox.Location = new System.Drawing.Point(564, 324);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.Size = new System.Drawing.Size(413, 43);
            this.confirmTextBox.TabIndex = 12;
            this.confirmTextBox.TabStop = false;
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nameValueLabel.ForeColor = System.Drawing.Color.White;
            this.nameValueLabel.Location = new System.Drawing.Point(406, 169);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(83, 39);
            this.nameValueLabel.TabIndex = 13;
            this.nameValueLabel.Text = "name";
            // 
            // emailValueLabel
            // 
            this.emailValueLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.emailValueLabel.ForeColor = System.Drawing.Color.White;
            this.emailValueLabel.Location = new System.Drawing.Point(406, 219);
            this.emailValueLabel.Name = "emailValueLabel";
            this.emailValueLabel.Size = new System.Drawing.Size(83, 39);
            this.emailValueLabel.TabIndex = 14;
            this.emailValueLabel.Text = "email";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(150, 200);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.emailValueLabel);
            this.Controls.Add(this.nameValueLabel);
            this.Controls.Add(this.confirmTextBox);
            this.Controls.Add(this.changeTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.userProfileImage);
            this.Controls.Add(this.settingsLabel);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(1264, 581);
            ((System.ComponentModel.ISupportInitialize) (this.userProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ImageList imageList;

        private System.Windows.Forms.OpenFileDialog photoBrowser;

        private filmhub.Views.RoundedTextBox changeTextBox;

        private filmhub.Views.RoundedTextBox confirmTextBox;

        private System.Windows.Forms.Label nameValueLabel;
        
        private System.Windows.Forms.Label emailValueLabel;
        
        private filmhub.Views.RoundedButton saveButton;
        
        private filmhub.Views.RoundedButton resetButton;

        private System.Windows.Forms.Label confirmLabel;

        private System.Windows.Forms.Label changeLabel;

        private System.Windows.Forms.Label nameLabel;
        
        private System.Windows.Forms.Label emailLabel;

        private filmhub.Views.RoundedButton uploadButton;

        private System.Windows.Forms.PictureBox userProfileImage;

        private System.Windows.Forms.Label settingsLabel;

        #endregion
    }
}