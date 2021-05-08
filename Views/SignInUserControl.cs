using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using filmhub.Controllers;
using filmhub.Controls;
using filmhub.Models;
using filmhub.Properties;

namespace filmhub.Views
{
    public partial class SignInUserControl : UserControl
    {
        #region Fields

        private Image _back;
        private Image _backHover;

        #endregion
        
        #region Constructor

        public SignInUserControl()
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
            signUpLabel.ForeColor = Program.Colors.ForeColor;
            menuPanel.BackColor = Program.Colors.BackgroundColor;
            usernameTextBox.BackColor = Program.Colors.FieldColor;
            passwordTextBox.BackColor = Program.Colors.FieldColor;
            usernameTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
            passwordTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
            signInButton.BackColor = Program.Colors.AccentColor;
            signInButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            newLabel.ForeColor = Program.Colors.DarkTextColor;
        }

        private void InitializeImages()
        {
            _back = Settings.Default.Theme == 0 ? Resources.back : Resources.back_black;
            
            backButton.Image = _back;
            _backHover = Resources.back_hover;
        }

        private void Login()
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text.Trim()) || usernameTextBox.Text.Equals(" Username"))
            {
                SystemSounds.Beep.Play();
                CustomMessageBox.Show(@"Username is empty.");
                
            }
            else if (string.IsNullOrEmpty(passwordTextBox.Text.Trim()) || passwordTextBox.Text.Equals(" Password"))
            {
                SystemSounds.Beep.Play();
                CustomMessageBox.Show(@"Password is empty.");
            }
            else
            {
                AccountController.Login(usernameTextBox.Text, passwordTextBox.Text);
                if (Account.GetAccountInstance() == null) return;
                Program.MainForm.UserControlSelector(new MainPageUserControl(), true);
            }
        }

        #endregion

        #region Events

        private void signUpLabel_MouseHover(object sender, EventArgs e)
        {
            signUpLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void signUpLabel_MouseLeave(object sender, EventArgs e)
        {
            signUpLabel.ForeColor = Program.Colors.ForeColor;
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

        private void signInButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new SignUpUserControl(), false);
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
            Login();
            e.SuppressKeyPress = true;
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            Login();
            e.SuppressKeyPress = true;
        }

        #endregion
    }
}