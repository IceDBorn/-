using System.ComponentModel;
using filmhub.Controls;

namespace filmhub.Views
{
    partial class WelcomeUserControl
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
            this.joinButton = new RoundButton();
            this.signInButton = new RoundButton();
            this.SuspendLayout();
            // 
            // joinButton
            // 
            this.joinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.joinButton.ForeColor = System.Drawing.Color.White;
            this.joinButton.Location = new System.Drawing.Point(14, 305);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(251, 52);
            this.joinButton.TabIndex = 2;
            this.joinButton.TabStop = false;
            this.joinButton.Text = "Join for free";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(1107, 12);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(143, 43);
            this.signInButton.TabIndex = 3;
            this.signInButton.TabStop = false;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // WelcomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::filmhub.Properties.Resources.background_slogan;
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.joinButton);
            this.Name = "WelcomeUserControl";
            this.Size = new System.Drawing.Size(1264, 595);
            this.ResumeLayout(false);
        }

        private RoundButton signInButton;

        private RoundButton joinButton;

        #endregion
    }
}