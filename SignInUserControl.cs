using System;
using System.Drawing;
using System.Windows.Forms;

namespace filmhub
{
    public partial class SignInUserControl : UserControl
    {
        #region Fields

        private readonly Colors _colors = new Colors();

        #endregion
        public SignInUserControl()
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
            newLabel.ForeColor = _colors.DarkTextColor;
        }

        private void signUpLabel_MouseHover(object sender, EventArgs e)
        {
            signUpLabel.ForeColor = _colors.AccentColor;
        }

        private void signUpLabel_MouseLeave(object sender, EventArgs e)
        {
            signUpLabel.ForeColor = Color.White;
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
    }
}