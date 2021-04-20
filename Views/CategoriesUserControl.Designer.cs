using System.ComponentModel;

namespace filmhub.Views
{
    partial class CategoriesUserControl
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
            this.categoriesPanel = new System.Windows.Forms.Panel();
            this.westernLabel = new System.Windows.Forms.Label();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.scifiLabel = new System.Windows.Forms.Label();
            this.romanceLabel = new System.Windows.Forms.Label();
            this.mysteryLabel = new System.Windows.Forms.Label();
            this.horrorLabel = new System.Windows.Forms.Label();
            this.fantasyLabel = new System.Windows.Forms.Label();
            this.dramaLabel = new System.Windows.Forms.Label();
            this.documentaryLabel = new System.Windows.Forms.Label();
            this.crimeLabel = new System.Windows.Forms.Label();
            this.comedyLabel = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.categoriesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesPanel
            // 
            this.categoriesPanel.Controls.Add(this.westernLabel);
            this.categoriesPanel.Controls.Add(this.categoriesLabel);
            this.categoriesPanel.Controls.Add(this.scifiLabel);
            this.categoriesPanel.Controls.Add(this.romanceLabel);
            this.categoriesPanel.Controls.Add(this.mysteryLabel);
            this.categoriesPanel.Controls.Add(this.horrorLabel);
            this.categoriesPanel.Controls.Add(this.fantasyLabel);
            this.categoriesPanel.Controls.Add(this.dramaLabel);
            this.categoriesPanel.Controls.Add(this.documentaryLabel);
            this.categoriesPanel.Controls.Add(this.crimeLabel);
            this.categoriesPanel.Controls.Add(this.comedyLabel);
            this.categoriesPanel.Controls.Add(this.actionLabel);
            this.categoriesPanel.Location = new System.Drawing.Point(0, 0);
            this.categoriesPanel.Name = "categoriesPanel";
            this.categoriesPanel.Size = new System.Drawing.Size(248, 594);
            this.categoriesPanel.TabIndex = 18;
            // 
            // westernLabel
            // 
            this.westernLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.westernLabel.ForeColor = System.Drawing.Color.White;
            this.westernLabel.Location = new System.Drawing.Point(45, 546);
            this.westernLabel.Name = "westernLabel";
            this.westernLabel.Size = new System.Drawing.Size(199, 34);
            this.westernLabel.TabIndex = 10;
            this.westernLabel.Text = "Western";
            this.westernLabel.Click += new System.EventHandler(this.westernLabel_Click);
            this.westernLabel.MouseLeave += new System.EventHandler(this.westernLabel_MouseLeave);
            this.westernLabel.MouseHover += new System.EventHandler(this.westernLabel_MouseHover);
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.categoriesLabel.ForeColor = System.Drawing.Color.White;
            this.categoriesLabel.Location = new System.Drawing.Point(1, 21);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(245, 45);
            this.categoriesLabel.TabIndex = 16;
            this.categoriesLabel.Text = "Categories";
            this.categoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scifiLabel
            // 
            this.scifiLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.scifiLabel.ForeColor = System.Drawing.Color.White;
            this.scifiLabel.Location = new System.Drawing.Point(46, 501);
            this.scifiLabel.Name = "scifiLabel";
            this.scifiLabel.Size = new System.Drawing.Size(199, 34);
            this.scifiLabel.TabIndex = 9;
            this.scifiLabel.Text = "Sci-Fi";
            this.scifiLabel.Click += new System.EventHandler(this.scifiLabel_Click);
            this.scifiLabel.MouseLeave += new System.EventHandler(this.scifiLabel_MouseLeave);
            this.scifiLabel.MouseHover += new System.EventHandler(this.scifiLabel_MouseHover);
            // 
            // romanceLabel
            // 
            this.romanceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.romanceLabel.ForeColor = System.Drawing.Color.White;
            this.romanceLabel.Location = new System.Drawing.Point(46, 456);
            this.romanceLabel.Name = "romanceLabel";
            this.romanceLabel.Size = new System.Drawing.Size(199, 34);
            this.romanceLabel.TabIndex = 8;
            this.romanceLabel.Text = "Romance";
            this.romanceLabel.Click += new System.EventHandler(this.romanceLabel_Click);
            this.romanceLabel.MouseLeave += new System.EventHandler(this.romanceLabel_MouseLeave);
            this.romanceLabel.MouseHover += new System.EventHandler(this.romanceLabel_MouseHover);
            // 
            // mysteryLabel
            // 
            this.mysteryLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.mysteryLabel.ForeColor = System.Drawing.Color.White;
            this.mysteryLabel.Location = new System.Drawing.Point(46, 411);
            this.mysteryLabel.Name = "mysteryLabel";
            this.mysteryLabel.Size = new System.Drawing.Size(199, 34);
            this.mysteryLabel.TabIndex = 7;
            this.mysteryLabel.Text = "Mystery";
            this.mysteryLabel.Click += new System.EventHandler(this.mysteryLabel_Click);
            this.mysteryLabel.MouseLeave += new System.EventHandler(this.mysteryLabel_MouseLeave);
            this.mysteryLabel.MouseHover += new System.EventHandler(this.mysteryLabel_MouseHover);
            // 
            // horrorLabel
            // 
            this.horrorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.horrorLabel.ForeColor = System.Drawing.Color.White;
            this.horrorLabel.Location = new System.Drawing.Point(46, 366);
            this.horrorLabel.Name = "horrorLabel";
            this.horrorLabel.Size = new System.Drawing.Size(199, 34);
            this.horrorLabel.TabIndex = 6;
            this.horrorLabel.Text = "Horror";
            this.horrorLabel.Click += new System.EventHandler(this.horrorLabel_Click);
            this.horrorLabel.MouseLeave += new System.EventHandler(this.horrorLabel_MouseLeave);
            this.horrorLabel.MouseHover += new System.EventHandler(this.horrorLabel_MouseHover);
            // 
            // fantasyLabel
            // 
            this.fantasyLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.fantasyLabel.ForeColor = System.Drawing.Color.White;
            this.fantasyLabel.Location = new System.Drawing.Point(46, 321);
            this.fantasyLabel.Name = "fantasyLabel";
            this.fantasyLabel.Size = new System.Drawing.Size(199, 34);
            this.fantasyLabel.TabIndex = 5;
            this.fantasyLabel.Text = "Fantasy";
            this.fantasyLabel.Click += new System.EventHandler(this.fantasyLabel_Click);
            this.fantasyLabel.MouseLeave += new System.EventHandler(this.fantasyLabel_MouseLeave);
            this.fantasyLabel.MouseHover += new System.EventHandler(this.fantasyLabel_MouseHover);
            // 
            // dramaLabel
            // 
            this.dramaLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dramaLabel.ForeColor = System.Drawing.Color.White;
            this.dramaLabel.Location = new System.Drawing.Point(46, 276);
            this.dramaLabel.Name = "dramaLabel";
            this.dramaLabel.Size = new System.Drawing.Size(199, 34);
            this.dramaLabel.TabIndex = 4;
            this.dramaLabel.Text = "Drama";
            this.dramaLabel.Click += new System.EventHandler(this.dramaLabel_Click);
            this.dramaLabel.MouseLeave += new System.EventHandler(this.dramaLabel_MouseLeave);
            this.dramaLabel.MouseHover += new System.EventHandler(this.dramaLabel_MouseHover);
            // 
            // documentaryLabel
            // 
            this.documentaryLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.documentaryLabel.ForeColor = System.Drawing.Color.White;
            this.documentaryLabel.Location = new System.Drawing.Point(46, 231);
            this.documentaryLabel.Name = "documentaryLabel";
            this.documentaryLabel.Size = new System.Drawing.Size(199, 34);
            this.documentaryLabel.TabIndex = 3;
            this.documentaryLabel.Text = "Documentary";
            this.documentaryLabel.Click += new System.EventHandler(this.documentaryLabel_Click);
            this.documentaryLabel.MouseLeave += new System.EventHandler(this.documentaryLabel_MouseLeave);
            this.documentaryLabel.MouseHover += new System.EventHandler(this.documentaryLabel_MouseHover);
            // 
            // crimeLabel
            // 
            this.crimeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.crimeLabel.ForeColor = System.Drawing.Color.White;
            this.crimeLabel.Location = new System.Drawing.Point(46, 186);
            this.crimeLabel.Name = "crimeLabel";
            this.crimeLabel.Size = new System.Drawing.Size(199, 34);
            this.crimeLabel.TabIndex = 2;
            this.crimeLabel.Text = "Crime";
            this.crimeLabel.Click += new System.EventHandler(this.crimeLabel_Click);
            this.crimeLabel.MouseLeave += new System.EventHandler(this.crimeLabel_MouseLeave);
            this.crimeLabel.MouseHover += new System.EventHandler(this.crimeLabel_MouseHover);
            // 
            // comedyLabel
            // 
            this.comedyLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comedyLabel.ForeColor = System.Drawing.Color.White;
            this.comedyLabel.Location = new System.Drawing.Point(46, 141);
            this.comedyLabel.Name = "comedyLabel";
            this.comedyLabel.Size = new System.Drawing.Size(199, 34);
            this.comedyLabel.TabIndex = 1;
            this.comedyLabel.Text = "Comedy";
            this.comedyLabel.Click += new System.EventHandler(this.comedyLabel_Click);
            this.comedyLabel.MouseLeave += new System.EventHandler(this.comedyLabel_MouseLeave);
            this.comedyLabel.MouseHover += new System.EventHandler(this.comedyLabel_MouseHover);
            // 
            // actionLabel
            // 
            this.actionLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.actionLabel.ForeColor = System.Drawing.Color.White;
            this.actionLabel.Location = new System.Drawing.Point(46, 96);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(199, 34);
            this.actionLabel.TabIndex = 0;
            this.actionLabel.Text = "Action";
            this.actionLabel.Click += new System.EventHandler(this.actionLabel_Click);
            this.actionLabel.MouseLeave += new System.EventHandler(this.actionLabel_MouseLeave);
            this.actionLabel.MouseHover += new System.EventHandler(this.actionLabel_MouseHover);
            // 
            // CategoriesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.categoriesPanel);
            this.Name = "CategoriesUserControl";
            this.Size = new System.Drawing.Size(248, 594);
            this.categoriesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.Panel categoriesPanel;
        private System.Windows.Forms.Label comedyLabel;
        private System.Windows.Forms.Label crimeLabel;
        private System.Windows.Forms.Label documentaryLabel;
        private System.Windows.Forms.Label dramaLabel;
        private System.Windows.Forms.Label fantasyLabel;
        private System.Windows.Forms.Label horrorLabel;
        private System.Windows.Forms.Label mysteryLabel;
        private System.Windows.Forms.Label romanceLabel;
        private System.Windows.Forms.Label scifiLabel;
        private System.Windows.Forms.Label westernLabel;

        #endregion
    }
}