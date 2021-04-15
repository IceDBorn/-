using System;
using System.Drawing;
using System.Windows.Forms;
using filmhub.Properties;

namespace filmhub.Views
{
    public partial class SignUpUserControl : UserControl
    {
        #region Constructor

        public SignUpUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            menuPanel.BackColor = Program.Colors.BackgroundColor;
            emailTextBox.BackColor = Program.Colors.FieldColor;
            passwordTextBox.BackColor = Program.Colors.FieldColor;
            emailTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
            passwordTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
            signUpButton.BackColor = Program.Colors.AccentColor;
            signUpButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            byClickingLabel.ForeColor = Program.Colors.DarkTextColor;
            andLabel.ForeColor = Program.Colors.DarkTextColor;
            confirmPasswordTextBox.BackColor = Program.Colors.FieldColor;
            confirmPasswordTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
        }

        #endregion

        #region Events

        private void signUpLabel_MouseHover(object sender, EventArgs e)
        {
            termsLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void TermsLabel_MouseLeave(object sender, EventArgs e)
        {
            termsLabel.ForeColor = Color.White;
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Equals(@" E-mail"))
            {
                emailTextBox.Text = "";
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Equals(""))
            {
                emailTextBox.Text = @" E-mail";
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (!passwordTextBox.Text.Equals(@" Password")) return;
            passwordTextBox.Text = "";
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (!passwordTextBox.Text.Equals("")) return;
            passwordTextBox.Text = @" Password";
            passwordTextBox.UseSystemPasswordChar = false;
        }

        private void confirmPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (!confirmPasswordTextBox.Text.Equals(@" Confirm password")) return;
            confirmPasswordTextBox.Text = "";
            confirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void confirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (!confirmPasswordTextBox.Text.Equals("")) return;
            confirmPasswordTextBox.Text = @" Confirm password";
            confirmPasswordTextBox.UseSystemPasswordChar = false;
        }

        private void privacyLabel_MouseHover(object sender, EventArgs e)
        {
            privacyLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void privacyLabel_MouseLeave(object sender, EventArgs e)
        {
            privacyLabel.ForeColor = Color.White;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new MainPageUserControl(), true);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new WelcomeUserControl(), false);
        }

        private void backButton_MouseHover(object sender, EventArgs e)
        {
            backButton.Image = Resources.back_hover;
            GC.Collect();
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.Image = Resources.back;
            GC.Collect();
        }

        #endregion
    }
}