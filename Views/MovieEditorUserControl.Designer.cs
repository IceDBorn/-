using System.ComponentModel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieEditorUserControl));
            this.movieImage = new System.Windows.Forms.PictureBox();
            this.descriptionValueLabel = new filmhub.Views.RoundedTextBox();
            this.directorLabel = new System.Windows.Forms.Label();
            this.writerLabel = new System.Windows.Forms.Label();
            this.starsLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.directorValueLabel = new filmhub.Views.RoundedTextBox();
            this.starsValueLabel = new filmhub.Views.RoundedTextBox();
            this.writerValueLabel = new filmhub.Views.RoundedTextBox();
            this.titleValueLabel = new filmhub.Views.RoundedTextBox();
            this.saveButton = new filmhub.Views.RoundedButton();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.editMovieLabel = new System.Windows.Forms.Label();
            this.uploadButton = new filmhub.Views.RoundedButton();
            this.genreValue = new System.Windows.Forms.ComboBox();
            this.dateValue = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize) (this.movieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // movieImage
            // 
            this.movieImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.movieImage.Location = new System.Drawing.Point(79, 170);
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
            this.descriptionValueLabel.Location = new System.Drawing.Point(396, 375);
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
            this.directorLabel.Location = new System.Drawing.Point(269, 182);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(98, 27);
            this.directorLabel.TabIndex = 5;
            this.directorLabel.Text = "Directors:";
            // 
            // writerLabel
            // 
            this.writerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.writerLabel.ForeColor = System.Drawing.Color.White;
            this.writerLabel.Location = new System.Drawing.Point(269, 219);
            this.writerLabel.Name = "writerLabel";
            this.writerLabel.Size = new System.Drawing.Size(82, 27);
            this.writerLabel.TabIndex = 6;
            this.writerLabel.Text = "Writers:";
            // 
            // starsLabel
            // 
            this.starsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.starsLabel.ForeColor = System.Drawing.Color.White;
            this.starsLabel.Location = new System.Drawing.Point(269, 258);
            this.starsLabel.Name = "starsLabel";
            this.starsLabel.Size = new System.Drawing.Size(77, 27);
            this.starsLabel.TabIndex = 7;
            this.starsLabel.Text = "Stars:";
            // 
            // genreLabel
            // 
            this.genreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.genreLabel.ForeColor = System.Drawing.Color.White;
            this.genreLabel.Location = new System.Drawing.Point(269, 297);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(79, 27);
            this.genreLabel.TabIndex = 8;
            this.genreLabel.Text = "Genres:";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(269, 335);
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
            this.directorValueLabel.Location = new System.Drawing.Point(396, 182);
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
            this.starsValueLabel.Location = new System.Drawing.Point(396, 258);
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
            this.writerValueLabel.Location = new System.Drawing.Point(396, 216);
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
            this.titleValueLabel.Location = new System.Drawing.Point(396, 140);
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
            this.saveButton.Location = new System.Drawing.Point(533, 519);
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
            this.descriptionLabel.Location = new System.Drawing.Point(269, 374);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(121, 27);
            this.descriptionLabel.TabIndex = 19;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(269, 143);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 27);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "Title:";
            // 
            // editMovieLabel
            // 
            this.editMovieLabel.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.editMovieLabel.ForeColor = System.Drawing.Color.White;
            this.editMovieLabel.Location = new System.Drawing.Point(68, 21);
            this.editMovieLabel.Name = "editMovieLabel";
            this.editMovieLabel.Size = new System.Drawing.Size(186, 58);
            this.editMovieLabel.TabIndex = 21;
            this.editMovieLabel.Text = "Edit Movie";
            // 
            // uploadButton
            // 
            this.uploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.uploadButton.ForeColor = System.Drawing.Color.White;
            this.uploadButton.Location = new System.Drawing.Point(79, 392);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(150, 28);
            this.uploadButton.TabIndex = 22;
            this.uploadButton.TabStop = false;
            this.uploadButton.Text = "Upload a photo";
            this.uploadButton.UseVisualStyleBackColor = true;
            // 
            // genreValue
            // 
            this.genreValue.BackColor = System.Drawing.SystemColors.WindowText;
            this.genreValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.genreValue.FormattingEnabled = true;
            this.genreValue.Location = new System.Drawing.Point(396, 297);
            this.genreValue.Margin = new System.Windows.Forms.Padding(0);
            this.genreValue.Name = "genreValue";
            this.genreValue.Size = new System.Drawing.Size(790, 33);
            this.genreValue.TabIndex = 23;
            // 
            // dateValue
            // 
            this.dateValue.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.dateValue.Location = new System.Drawing.Point(396, 335);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(790, 20);
            this.dateValue.TabIndex = 24;
            // 
            // MovieEditorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.genreValue);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.editMovieLabel);
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

        private System.Windows.Forms.DateTimePicker dateValue;

        private System.Windows.Forms.ComboBox genreValue;

        private filmhub.Views.RoundedButton uploadButton;

        private System.Windows.Forms.Label editMovieLabel;

        private filmhub.Views.RoundedButton saveButton;

        private filmhub.Views.RoundedTextBox titleValueLabel;

        private System.Windows.Forms.Label titleLabel;

        private filmhub.Views.RoundedTextBox writerValueLabel;

        private filmhub.Views.RoundedTextBox starsValueLabel;
        private filmhub.Views.RoundedTextBox directorValueLabel;

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label starsLabel;
        private System.Windows.Forms.Label writerLabel;

        private System.Windows.Forms.Label directorLabel;

        private filmhub.Views.RoundedTextBox descriptionValueLabel;

        private System.Windows.Forms.Label descriptionLabel;

        private System.Windows.Forms.PictureBox movieImage;

        #endregion
    }
}