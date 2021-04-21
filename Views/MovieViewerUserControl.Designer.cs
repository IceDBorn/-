using System.ComponentModel;

namespace filmhub.Views
{
    partial class MovieViewerUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieViewerUserControl));
            this.titleLabel = new System.Windows.Forms.Label();
            this.movieImage = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.writerLabel = new System.Windows.Forms.Label();
            this.starsLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.directorValueLabel = new System.Windows.Forms.Label();
            this.starsValueLabel = new System.Windows.Forms.Label();
            this.writerValueLabel = new System.Windows.Forms.Label();
            this.genreValueLabel = new System.Windows.Forms.Label();
            this.dateValueLabel = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.favoriteImage = new System.Windows.Forms.PictureBox();
            this.watchlistImage = new System.Windows.Forms.PictureBox();
            this.watchedImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.movieImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.favoriteImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.watchlistImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.watchedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(68, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1193, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // movieImage
            // 
            this.movieImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.movieImage.Location = new System.Drawing.Point(156, 107);
            this.movieImage.Name = "movieImage";
            this.movieImage.Size = new System.Drawing.Size(150, 200);
            this.movieImage.TabIndex = 1;
            this.movieImage.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(148, 355);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(206, 45);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description\r\n";
            // 
            // descriptionText
            // 
            this.descriptionText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.descriptionText.ForeColor = System.Drawing.Color.White;
            this.descriptionText.Location = new System.Drawing.Point(151, 410);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(996, 171);
            this.descriptionText.TabIndex = 3;
            this.descriptionText.Text = resources.GetString("descriptionText.Text");
            // 
            // directorLabel
            // 
            this.directorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.directorLabel.ForeColor = System.Drawing.Color.White;
            this.directorLabel.Location = new System.Drawing.Point(342, 101);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(98, 27);
            this.directorLabel.TabIndex = 5;
            this.directorLabel.Text = "Directors:";
            // 
            // writerLabel
            // 
            this.writerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.writerLabel.ForeColor = System.Drawing.Color.White;
            this.writerLabel.Location = new System.Drawing.Point(342, 141);
            this.writerLabel.Name = "writerLabel";
            this.writerLabel.Size = new System.Drawing.Size(82, 27);
            this.writerLabel.TabIndex = 6;
            this.writerLabel.Text = "Writers:";
            // 
            // starsLabel
            // 
            this.starsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.starsLabel.ForeColor = System.Drawing.Color.White;
            this.starsLabel.Location = new System.Drawing.Point(342, 181);
            this.starsLabel.Name = "starsLabel";
            this.starsLabel.Size = new System.Drawing.Size(77, 27);
            this.starsLabel.TabIndex = 7;
            this.starsLabel.Text = "Stars:";
            // 
            // genreLabel
            // 
            this.genreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.genreLabel.ForeColor = System.Drawing.Color.White;
            this.genreLabel.Location = new System.Drawing.Point(342, 221);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(79, 27);
            this.genreLabel.TabIndex = 8;
            this.genreLabel.Text = "Genres:";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(342, 261);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(59, 27);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.ratingLabel.ForeColor = System.Drawing.Color.White;
            this.ratingLabel.Location = new System.Drawing.Point(342, 301);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(77, 27);
            this.ratingLabel.TabIndex = 10;
            this.ratingLabel.Text = "Rating:";
            // 
            // directorValueLabel
            // 
            this.directorValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.directorValueLabel.ForeColor = System.Drawing.Color.White;
            this.directorValueLabel.Location = new System.Drawing.Point(443, 101);
            this.directorValueLabel.Name = "directorValueLabel";
            this.directorValueLabel.Size = new System.Drawing.Size(861, 27);
            this.directorValueLabel.TabIndex = 12;
            this.directorValueLabel.Text = "directors";
            // 
            // starsValueLabel
            // 
            this.starsValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.starsValueLabel.ForeColor = System.Drawing.Color.White;
            this.starsValueLabel.Location = new System.Drawing.Point(443, 181);
            this.starsValueLabel.Name = "starsValueLabel";
            this.starsValueLabel.Size = new System.Drawing.Size(861, 27);
            this.starsValueLabel.TabIndex = 13;
            this.starsValueLabel.Text = "stars";
            // 
            // writerValueLabel
            // 
            this.writerValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.writerValueLabel.ForeColor = System.Drawing.Color.White;
            this.writerValueLabel.Location = new System.Drawing.Point(443, 141);
            this.writerValueLabel.Name = "writerValueLabel";
            this.writerValueLabel.Size = new System.Drawing.Size(861, 27);
            this.writerValueLabel.TabIndex = 14;
            this.writerValueLabel.Text = "writers";
            // 
            // genreValueLabel
            // 
            this.genreValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.genreValueLabel.ForeColor = System.Drawing.Color.White;
            this.genreValueLabel.Location = new System.Drawing.Point(443, 221);
            this.genreValueLabel.Name = "genreValueLabel";
            this.genreValueLabel.Size = new System.Drawing.Size(861, 27);
            this.genreValueLabel.TabIndex = 15;
            this.genreValueLabel.Text = "genres";
            // 
            // dateValueLabel
            // 
            this.dateValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.dateValueLabel.ForeColor = System.Drawing.Color.White;
            this.dateValueLabel.Location = new System.Drawing.Point(443, 261);
            this.dateValueLabel.Name = "dateValueLabel";
            this.dateValueLabel.Size = new System.Drawing.Size(861, 27);
            this.dateValueLabel.TabIndex = 16;
            this.dateValueLabel.Text = "month 00, 0000";
            // 
            // star1
            // 
            this.star1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star1.Image = global::filmhub.Properties.Resources.star_empty;
            this.star1.Location = new System.Drawing.Point(446, 302);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(23, 27);
            this.star1.TabIndex = 17;
            this.star1.TabStop = false;
            this.star1.Tag = "0";
            this.star1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.star1_MouseClick);
            this.star1.MouseLeave += new System.EventHandler(this.star1_MouseLeave);
            this.star1.MouseHover += new System.EventHandler(this.star1_MouseHover);
            // 
            // star2
            // 
            this.star2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star2.Image = global::filmhub.Properties.Resources.star_empty;
            this.star2.Location = new System.Drawing.Point(486, 302);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(23, 27);
            this.star2.TabIndex = 18;
            this.star2.TabStop = false;
            this.star2.Tag = "0";
            this.star2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.star2_MouseClick);
            this.star2.MouseLeave += new System.EventHandler(this.star2_MouseLeave);
            this.star2.MouseHover += new System.EventHandler(this.star2_MouseHover);
            // 
            // star3
            // 
            this.star3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star3.Image = global::filmhub.Properties.Resources.star_empty;
            this.star3.Location = new System.Drawing.Point(526, 302);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(23, 27);
            this.star3.TabIndex = 19;
            this.star3.TabStop = false;
            this.star3.Tag = "0";
            this.star3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.star3_MouseClick);
            this.star3.MouseLeave += new System.EventHandler(this.star3_MouseLeave);
            this.star3.MouseHover += new System.EventHandler(this.star3_MouseHover);
            // 
            // star4
            // 
            this.star4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star4.Image = global::filmhub.Properties.Resources.star_empty;
            this.star4.Location = new System.Drawing.Point(566, 302);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(23, 27);
            this.star4.TabIndex = 20;
            this.star4.TabStop = false;
            this.star4.Tag = "0";
            this.star4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.star4_MouseClick);
            this.star4.MouseLeave += new System.EventHandler(this.star4_MouseLeave);
            this.star4.MouseHover += new System.EventHandler(this.star4_MouseHover);
            // 
            // star5
            // 
            this.star5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star5.Image = global::filmhub.Properties.Resources.star_empty;
            this.star5.Location = new System.Drawing.Point(606, 302);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(23, 27);
            this.star5.TabIndex = 21;
            this.star5.TabStop = false;
            this.star5.Tag = "0";
            this.star5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.star5_MouseClick);
            this.star5.MouseLeave += new System.EventHandler(this.star5_MouseLeave);
            this.star5.MouseHover += new System.EventHandler(this.star5_MouseHover);
            // 
            // favoriteImage
            // 
            this.favoriteImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoriteImage.Image = global::filmhub.Properties.Resources.favorite_empty;
            this.favoriteImage.Location = new System.Drawing.Point(72, 102);
            this.favoriteImage.Name = "favoriteImage";
            this.favoriteImage.Size = new System.Drawing.Size(47, 45);
            this.favoriteImage.TabIndex = 22;
            this.favoriteImage.TabStop = false;
            this.favoriteImage.Tag = "0";
            this.favoriteImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.favoriteImage_MouseClick);
            this.favoriteImage.MouseLeave += new System.EventHandler(this.favoriteImage_MouseLeave);
            this.favoriteImage.MouseHover += new System.EventHandler(this.favoriteImage_MouseHover);
            // 
            // watchlistImage
            // 
            this.watchlistImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchlistImage.Image = global::filmhub.Properties.Resources.watchlist_empty;
            this.watchlistImage.Location = new System.Drawing.Point(72, 264);
            this.watchlistImage.Name = "watchlistImage";
            this.watchlistImage.Size = new System.Drawing.Size(47, 45);
            this.watchlistImage.TabIndex = 23;
            this.watchlistImage.TabStop = false;
            this.watchlistImage.Tag = "0";
            this.watchlistImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.watchlistImage_MouseClick);
            this.watchlistImage.MouseLeave += new System.EventHandler(this.watchlistImage_MouseLeave);
            this.watchlistImage.MouseHover += new System.EventHandler(this.watchlistImage_MouseHover);
            // 
            // watchedImage
            // 
            this.watchedImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchedImage.Image = global::filmhub.Properties.Resources.watched_empty;
            this.watchedImage.Location = new System.Drawing.Point(72, 183);
            this.watchedImage.Name = "watchedImage";
            this.watchedImage.Size = new System.Drawing.Size(47, 45);
            this.watchedImage.TabIndex = 24;
            this.watchedImage.TabStop = false;
            this.watchedImage.Tag = "0";
            this.watchedImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.watchedImage_MouseClick);
            this.watchedImage.MouseLeave += new System.EventHandler(this.watchedImage_MouseLeave);
            this.watchedImage.MouseHover += new System.EventHandler(this.watchedImage_MouseHover);
            // 
            // MovieViewerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.watchedImage);
            this.Controls.Add(this.watchlistImage);
            this.Controls.Add(this.favoriteImage);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.dateValueLabel);
            this.Controls.Add(this.genreValueLabel);
            this.Controls.Add(this.writerValueLabel);
            this.Controls.Add(this.starsValueLabel);
            this.Controls.Add(this.directorValueLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.starsLabel);
            this.Controls.Add(this.writerLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.movieImage);
            this.Controls.Add(this.titleLabel);
            this.Name = "MovieViewerUserControl";
            this.Size = new System.Drawing.Size(1264, 581);
            ((System.ComponentModel.ISupportInitialize) (this.movieImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.favoriteImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.watchlistImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.watchedImage)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox favoriteImage;
        private System.Windows.Forms.PictureBox watchlistImage;
        private System.Windows.Forms.PictureBox watchedImage;

        private System.Windows.Forms.PictureBox star5;

        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star4;

        private System.Windows.Forms.PictureBox star1;

        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.Label dateValueLabel;
        private System.Windows.Forms.Label genreValueLabel;
        private System.Windows.Forms.Label writerValueLabel;

        private System.Windows.Forms.Label starsValueLabel;
        private System.Windows.Forms.Label directorValueLabel;

        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label starsLabel;
        private System.Windows.Forms.Label writerLabel;

        private System.Windows.Forms.Label directorLabel;

        private System.Windows.Forms.Label descriptionText;

        private System.Windows.Forms.Label descriptionLabel;

        private System.Windows.Forms.PictureBox movieImage;

        #endregion
    }
}