using System.ComponentModel;

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
            this.joinButton = new RoundedButton();
            this.signInButton = new RoundedButton();
            this.SuspendLayout();
            // 
            // joinButton
            // 
            this.joinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinButton.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.joinButton.ForeColor = System.Drawing.Color.White;
            this.joinButton.Location = new System.Drawing.Point(14, 305);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(253, 56);
            this.joinButton.TabIndex = 2;
            this.joinButton.TabStop = false;
            this.joinButton.Text = "Join for free";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(1120, 12);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(130, 34);
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
            this.BackgroundImage = global::filmhub.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.joinButton);
            this.Name = "WelcomeUserControl";
            this.Size = new System.Drawing.Size(1264, 581);
            this.ResumeLayout(false);
        }

        private RoundedButton signInButton;

        private RoundedButton joinButton;

        #endregion
    }
}