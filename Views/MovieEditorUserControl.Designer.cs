using System.ComponentModel;
using System.Windows.Forms;
using filmhub.Controls;

namespace filmhub.Views
{
    partial class MovieEditorUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieEditorUserControl));
            this.movieImage = new System.Windows.Forms.PictureBox();
            this.descriptionValueLabel = new filmhub.Controls.RoundTextBox();
            this.directorLabel = new System.Windows.Forms.Label();
            this.writerLabel = new System.Windows.Forms.Label();
            this.starsLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.directorValueLabel = new filmhub.Controls.RoundTextBox();
            this.starsValueLabel = new filmhub.Controls.RoundTextBox();
            this.writerValueLabel = new filmhub.Controls.RoundTextBox();
            this.titleValueLabel = new filmhub.Controls.RoundTextBox();
            this.saveButton = new filmhub.Controls.RoundButton();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuTitleLabel = new System.Windows.Forms.Label();
            this.uploadButton = new filmhub.Controls.RoundButton();
            this.genreValue = new filmhub.Controls.RoundComboBox();
            this.dateValue = new filmhub.Controls.RoundDateTimePicker();
            this.photoBrowser = new System.Windows.Forms.OpenFileDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.uploadingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.movieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // movieImage
            // 
            this.movieImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.movieImage.Location = new System.Drawing.Point(79, 100);
            this.movieImage.Name = "movieImage";
            this.movieImage.Size = new System.Drawing.Size(150, 200);
            this.movieImage.TabIndex = 1;
            this.movieImage.TabStop = false;
            // 
            // descriptionValueLabel
            // 
            this.descriptionValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.descriptionValueLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionValueLabel.Location = new System.Drawing.Point(396, 400);
            this.descriptionValueLabel.Multiline = true;
            this.descriptionValueLabel.Name = "descriptionValueLabel";
            this.descriptionValueLabel.Size = new System.Drawing.Size(790, 126);
            this.descriptionValueLabel.TabIndex = 3;
            this.descriptionValueLabel.TabStop = false;
            this.descriptionValueLabel.Text = resources.GetString("descriptionValueLabel.Text");
            // 
            // directorLabel
            // 
            this.directorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.directorLabel.ForeColor = System.Drawing.Color.White;
            this.directorLabel.Location = new System.Drawing.Point(269, 153);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(98, 27);
            this.directorLabel.TabIndex = 5;
            this.directorLabel.Text = "Directors:";
            // 
            // writerLabel
            // 
            this.writerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.writerLabel.ForeColor = System.Drawing.Color.White;
            this.writerLabel.Location = new System.Drawing.Point(269, 203);
            this.writerLabel.Name = "writerLabel";
            this.writerLabel.Size = new System.Drawing.Size(82, 27);
            this.writerLabel.TabIndex = 6;
            this.writerLabel.Text = "Writers:";
            // 
            // starsLabel
            // 
            this.starsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.starsLabel.ForeColor = System.Drawing.Color.White;
            this.starsLabel.Location = new System.Drawing.Point(269, 253);
            this.starsLabel.Name = "starsLabel";
            this.starsLabel.Size = new System.Drawing.Size(77, 27);
            this.starsLabel.TabIndex = 7;
            this.starsLabel.Text = "Stars:";
            // 
            // genreLabel
            // 
            this.genreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.genreLabel.ForeColor = System.Drawing.Color.White;
            this.genreLabel.Location = new System.Drawing.Point(269, 303);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(79, 27);
            this.genreLabel.TabIndex = 8;
            this.genreLabel.Text = "Genres:";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(269, 353);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(59, 27);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date:";
            // 
            // directorValueLabel
            // 
            this.directorValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.directorValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.directorValueLabel.ForeColor = System.Drawing.Color.White;
            this.directorValueLabel.Location = new System.Drawing.Point(396, 150);
            this.directorValueLabel.Name = "directorValueLabel";
            this.directorValueLabel.Size = new System.Drawing.Size(790, 33);
            this.directorValueLabel.TabIndex = 12;
            this.directorValueLabel.TabStop = false;
            this.directorValueLabel.Text = "directors";
            // 
            // starsValueLabel
            // 
            this.starsValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.starsValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.starsValueLabel.ForeColor = System.Drawing.Color.White;
            this.starsValueLabel.Location = new System.Drawing.Point(396, 250);
            this.starsValueLabel.Name = "starsValueLabel";
            this.starsValueLabel.Size = new System.Drawing.Size(790, 33);
            this.starsValueLabel.TabIndex = 13;
            this.starsValueLabel.TabStop = false;
            this.starsValueLabel.Text = "stars";
            // 
            // writerValueLabel
            // 
            this.writerValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.writerValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.writerValueLabel.ForeColor = System.Drawing.Color.White;
            this.writerValueLabel.Location = new System.Drawing.Point(396, 200);
            this.writerValueLabel.Name = "writerValueLabel";
            this.writerValueLabel.Size = new System.Drawing.Size(790, 33);
            this.writerValueLabel.TabIndex = 14;
            this.writerValueLabel.TabStop = false;
            this.writerValueLabel.Text = "writers";
            // 
            // titleValueLabel
            // 
            this.titleValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.titleValueLabel.ForeColor = System.Drawing.Color.White;
            this.titleValueLabel.Location = new System.Drawing.Point(396, 100);
            this.titleValueLabel.Name = "titleValueLabel";
            this.titleValueLabel.Size = new System.Drawing.Size(790, 33);
            this.titleValueLabel.TabIndex = 17;
            this.titleValueLabel.TabStop = false;
            this.titleValueLabel.Text = "title";
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(690, 540);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(190, 40);
            this.saveButton.TabIndex = 18;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(269, 403);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(121, 27);
            this.descriptionLabel.TabIndex = 19;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(269, 103);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 27);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "Title:";
            // 
            // menuTitleLabel
            // 
            this.menuTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.menuTitleLabel.ForeColor = System.Drawing.Color.White;
            this.menuTitleLabel.Location = new System.Drawing.Point(68, 21);
            this.menuTitleLabel.Name = "menuTitleLabel";
            this.menuTitleLabel.Size = new System.Drawing.Size(187, 58);
            this.menuTitleLabel.TabIndex = 21;
            this.menuTitleLabel.Text = "Menu Title";
            // 
            // uploadButton
            // 
            this.uploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.uploadButton.ForeColor = System.Drawing.Color.White;
            this.uploadButton.Location = new System.Drawing.Point(79, 322);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(150, 28);
            this.uploadButton.TabIndex = 22;
            this.uploadButton.TabStop = false;
            this.uploadButton.Text = "Upload a photo";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // genreValue
            // 
            this.genreValue.BackColor = System.Drawing.SystemColors.WindowText;
            this.genreValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genreValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.genreValue.FormattingEnabled = true;
            this.genreValue.Location = new System.Drawing.Point(396, 300);
            this.genreValue.Margin = new System.Windows.Forms.Padding(0);
            this.genreValue.Name = "genreValue";
            this.genreValue.Size = new System.Drawing.Size(790, 33);
            this.genreValue.TabIndex = 23;
            this.genreValue.TabStop = false;
            // 
            // dateValue
            // 
            this.dateValue.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.dateValue.CustomFormat = "yyyy-MM-dd";
            this.dateValue.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateValue.Location = new System.Drawing.Point(396, 350);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(790, 33);
            this.dateValue.TabIndex = 24;
            this.dateValue.TabStop = false;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(150, 200);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // uploadingLabel
            // 
            this.uploadingLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.uploadingLabel.ForeColor = System.Drawing.Color.White;
            this.uploadingLabel.Location = new System.Drawing.Point(79, 186);
            this.uploadingLabel.Name = "uploadingLabel";
            this.uploadingLabel.Size = new System.Drawing.Size(150, 27);
            this.uploadingLabel.TabIndex = 25;
            this.uploadingLabel.Text = "Uploading...";
            this.uploadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadingLabel.Visible = false;
            // 
            // MovieEditorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.uploadingLabel);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.genreValue);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.menuTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.titleValueLabel);
            this.Controls.Add(this.writerValueLabel);
            this.Controls.Add(this.starsValueLabel);
            this.Controls.Add(this.directorValueLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.starsLabel);
            this.Controls.Add(this.writerLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.descriptionValueLabel);
            this.Controls.Add(this.movieImage);
            this.Name = "MovieEditorUserControl";
            this.Size = new System.Drawing.Size(1264, 581);
            ((System.ComponentModel.ISupportInitialize) (this.movieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label uploadingLabel;

        private System.Windows.Forms.ImageList imageList;

        private System.Windows.Forms.OpenFileDialog photoBrowser;

        private filmhub.Controls.RoundDateTimePicker dateValue;

        private filmhub.Controls.RoundComboBox genreValue;

        private RoundButton uploadButton;

        private System.Windows.Forms.Label menuTitleLabel;

        private RoundButton saveButton;

        private RoundTextBox titleValueLabel;

        private System.Windows.Forms.Label titleLabel;

        private RoundTextBox writerValueLabel;

        private RoundTextBox starsValueLabel;
        private RoundTextBox directorValueLabel;

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label starsLabel;
        private System.Windows.Forms.Label writerLabel;

        private System.Windows.Forms.Label directorLabel;

        private RoundTextBox descriptionValueLabel;

        private System.Windows.Forms.Label descriptionLabel;

        private System.Windows.Forms.PictureBox movieImage;

        #endregion
    }
}