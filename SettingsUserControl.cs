using System;
using System.Windows.Forms;

namespace filmhub
{
    public partial class SettingsUserControl : UserControl
    {
        private readonly Colors _colors = new Colors();
        public SettingsUserControl()
        {
            InitializeComponent();
            InitializeColors();
        }

        private void InitializeColors()
        {
            BackColor = _colors.BackgroundColor;
            saveButton.BackColor = _colors.AccentColor;
            saveButton.FlatAppearance.BorderColor = _colors.AccentColor;
            resetButton.BackColor = _colors.AccentColor;
            resetButton.FlatAppearance.BorderColor = _colors.AccentColor;
            uploadButton.BackColor = _colors.AccentColor;
            uploadButton.FlatAppearance.BorderColor = _colors.AccentColor;
            changeTextBox.BackColor = _colors.FieldColor;
            changeTextBox.ForeColor = _colors.FieldDarkTextColor;
            confirmTextBox.BackColor = _colors.FieldColor;
            confirmTextBox.ForeColor = _colors.FieldDarkTextColor;
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