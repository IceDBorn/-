using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using filmhub.Controllers;
using filmhub.Models;
using filmhub.Properties;

namespace filmhub.Views
{
    public partial class SignInUserControl : UserControl
    {
        #region Constructor

        public SignInUserControl()
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
            signInButton.BackColor = Program.Colors.AccentColor;
            signInButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            newLabel.ForeColor = Program.Colors.DarkTextColor;
        }

        private void Login()
        {
            if (string.IsNullOrEmpty(emailTextBox.Text.Trim()) || emailTextBox.Text.Equals(" E-mail"))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Email is empty.");
                
            }
            else if (string.IsNullOrEmpty(passwordTextBox.Text.Trim()) || passwordTextBox.Text.Equals(" Password"))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(@"Password is empty.");
            }
            else
            {
                LoginController.Login(emailTextBox.Text, passwordTextBox.Text);
                if (Account.getAccountInstance() == null) return;
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
            backButton.Image = Resources.back_hover;
            GC.Collect();
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.Image = Resources.back;
            GC.Collect();
        }
        
        private void emailTextBox_KeyDown(object sender, KeyEventArgs e)
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