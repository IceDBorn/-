using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using filmhub.Controllers;
using filmhub.Models;
using filmhub.Properties;

namespace filmhub.Views
{
    public partial class SignUpUserControl : UserControl
    {
        #region Fields

        private Image _back;
        private Image _backHover;

        #endregion
        
        #region Constructor

        public SignUpUserControl()
        {
            InitializeComponent();
            InitializeColors();
            InitializeImages();
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            signInLabel.ForeColor = Program.Colors.ForeColor;
            termsLabel.ForeColor = Program.Colors.ForeColor;
            privacyLabel.ForeColor = Program.Colors.ForeColor;
            menuPanel.BackColor = Program.Colors.BackgroundColor;
            usernameTextBox.BackColor = Program.Colors.FieldColor;
            passwordTextBox.BackColor = Program.Colors.FieldColor;
            usernameTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
            passwordTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
            signUpButton.BackColor = Program.Colors.AccentColor;
            signUpButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            byClickingLabel.ForeColor = Program.Colors.DarkTextColor;
            andLabel.ForeColor = Program.Colors.DarkTextColor;
            confirmPasswordTextBox.BackColor = Program.Colors.FieldColor;
            confirmPasswordTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
        }
        
        private void InitializeImages()
        {
            _back = Resources.back_black;
            backButton.Image = _back;
            _backHover = Resources.back_hover;
        }

        private void SignUp()
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text.Trim()) || usernameTextBox.Text.Equals(" Username"))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Username is empty.");
            }
            else if (string.IsNullOrEmpty(passwordTextBox.Text.Trim()) || passwordTextBox.Text.Equals(" Password"))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Password is empty.");
            }
            else if (string.IsNullOrEmpty(confirmPasswordTextBox.Text.Trim()) ||
                     confirmPasswordTextBox.Text.Equals(" Confirm password"))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Confirm password is empty.");
            }
            else if (!passwordTextBox.Text.Equals(confirmPasswordTextBox.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Passwords do not match.");
            }
            else
            {
                LoginController.Signup(usernameTextBox.Text, passwordTextBox.Text);
                if (Account.GetAccountInstance() == null) return;
                Program.MainForm.UserControlSelector(new MainPageUserControl(), true);
            }
        }

        #endregion

        #region Events

        private void signUpLabel_MouseHover(object sender, EventArgs e)
        {
            termsLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void TermsLabel_MouseLeave(object sender, EventArgs e)
        {
            termsLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals(@" Username"))
            {
                usernameTextBox.Text = "";
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals(""))
            {
                usernameTextBox.Text = @" Username";
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
            privacyLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUp();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new WelcomeUserControl(), false);
        }

        private void backButton_MouseHover(object sender, EventArgs e)
        {
            backButton.Image = _backHover;
            GC.Collect();
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.Image = _back;
            GC.Collect();
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            SignUp();
            e.SuppressKeyPress = true;
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            SignUp();
            e.SuppressKeyPress = true;
        }

        private void confirmPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            SignUp();
            e.SuppressKeyPress = true;
        }

        private void privacyLabel_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://github.com/IceDBorn/filmhub/blob/main/privacy-policy.md");
        }

        private void termsLabel_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://github.com/IceDBorn/filmhub/blob/main/terms-and-conditions.md");
        }
    }

    #endregion
}