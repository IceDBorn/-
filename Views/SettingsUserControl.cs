using System;
using System.Windows.Forms;

namespace filmhub.Views
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }

        private void InitializeColors()
        {
            BackColor = Program.Colors.BackgroundColor;
            saveButton.BackColor = Program.Colors.AccentColor;
            saveButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            resetButton.BackColor = Program.Colors.AccentColor;
            resetButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            uploadButton.BackColor = Program.Colors.AccentColor;
            uploadButton.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            changeTextBox.BackColor = Program.Colors.FieldColor;
            changeTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
            confirmTextBox.BackColor = Program.Colors.FieldColor;
            confirmTextBox.ForeColor = Program.Colors.FieldDarkTextColor;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            changeTextBox.Text = "";
            confirmTextBox.Text = "";
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            photoBrowser.FileName = "";
            photoBrowser.Title = @"Select photo to upload";
            photoBrowser.Filter = @"Image Files(*.BMP;*.JPG;*.GIF,.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            photoBrowser.ShowDialog();
        }
    }
}