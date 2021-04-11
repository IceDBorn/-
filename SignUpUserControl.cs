using System;
using System.Drawing;
using System.Windows.Forms;

namespace filmhub
{
    public partial class SignUpUserControl : UserControl
    {
        #region Fields

        private readonly Colors _colors = new Colors();

        #endregion
        public SignUpUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }

        private void InitializeColors()
        {
            menuPanel.BackColor = _colors.BackgroundColor;
            emailTextBox.BackColor = _colors.FieldColor;
            passwordTextBox.BackColor = _colors.FieldColor;
            emailTextBox.ForeColor = _colors.FieldDarkTextColor;
            passwordTextBox.ForeColor = _colors.FieldDarkTextColor;
            signInButton.BackColor = _colors.AccentColor;
            signInButton.FlatAppearance.BorderColor = _colors.AccentColor;
            byClickingLabel.ForeColor = _colors.DarkTextColor;
            andLabel.ForeColor = _colors.DarkTextColor;
            confirmPasswordTextBox.BackColor = _colors.FieldColor;
            confirmPasswordTextBox.ForeColor = _colors.FieldDarkTextColor;
        }

        private void signUpLabel_MouseHover(object sender, EventArgs e)
        {
            termsLabel.ForeColor = _colors.AccentColor;
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
            privacyLabel.ForeColor = _colors.AccentColor;
        }

        private void privacyLabel_MouseLeave(object sender, EventArgs e)
        {
            privacyLabel.ForeColor = Color.White;
        }
    }
}