using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace filmhub.Controls
{
    public class MyLabel : Label
    {
        public static Label Set(string text = "")
        {
            var l = new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 14.25F),
                ForeColor = Program.Colors.ForeColor,
                BackColor = Program.Colors.NavBarBackgroundColor,
                AutoSize = true
            };
            return l;
        }
    }

    public class MyButton : RoundButton
    {
        public static RoundButton Set(string text = "", int width = 100, int height = 30)
        {
            var b = new RoundButton
            {
                Text = text,
                Width = width,
                Height = height,
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.White,
                BackColor = Program.Colors.AccentColor,
                FlatStyle = FlatStyle.Flat,
                TabStop = false
            };
            b.UseVisualStyleBackColor = b.BackColor == SystemColors.Control;
            b.FlatAppearance.BorderColor = Program.Colors.AccentColor;
            return b;
        }
    }

    public sealed class CustomMessageBox : Form
    {
        private const int CS_DROPSHADOW = 0x20000;

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private CustomMessageBox()
        {
            _panText = new FlowLayoutPanel();
            _panButtons = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panText
            // 
            _panText.Parent = this;
            _panText.AutoScroll = true;
            _panText.AutoSize = true;
            _panText.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _panText.Margin = new Padding(0);
            _panText.MaximumSize = new Size(500, 300);
            _panText.MinimumSize = new Size(108, 50);
            _panText.Size = new Size(108, 50);
            // 
            // panButtons
            // 
            _panButtons.AutoSize = true;
            _panButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _panButtons.FlowDirection = FlowDirection.RightToLeft;
            _panButtons.Location = new Point(89, 89);
            _panButtons.Margin = new Padding(0);
            _panButtons.MaximumSize = new Size(580, 150);
            _panButtons.MinimumSize = new Size(108, 0);
            _panButtons.Size = new Size(108, 35);
            // 
            // CustomMessageBox
            // 
            BackColor = Program.Colors.NavBarBackgroundColor;
            ForeColor = Program.Colors.ForeColor;
            FormBorderStyle = FormBorderStyle.None;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 133);
            Controls.Add(_panButtons);
            Controls.Add(_panText);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(168, 132);
            Name = "CustomMessageBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        public static void Show(string label, string title = "", List<Button> buttons = null)
        {
            var labels = new List<Label> {MyLabel.Set(label)};
            Show(labels, title, buttons);
        }

        public static DialogResult ShowDialog(string label, string title = "", List<Button> buttons = null)
        {
            var labels = new List<Label> {MyLabel.Set(label)};
            Show(labels, title, buttons);
            return _result;
        }

        private static void Show(List<Label> labels = null, string title = "", List<Button> buttons2 = null)
        {
            labels ??= new List<Label>();
            if (labels.Count == 0) labels.Add(MyLabel.Set());
            buttons2 ??= new List<Button>();
            if (buttons2.Count == 0) buttons2.Add(MyButton.Set("OK"));
            var buttons = new List<Button>(buttons2);
            buttons.Reverse();

            var mb = new CustomMessageBox {Text = title};

            //Labels
            mb._panText.Location = new Point(39, 24);
            foreach (var l in labels)
            {
                mb._panText.Controls.Add(l);
                l.Location = new Point(200, 50);
                l.MaximumSize = new Size(480, 2000);
            }

            labels.ForEach(l => l.MinimumSize = new Size(labels.Max(x => x.Width), 1));
            mb._panText.Height = labels.Sum(l => l.Height);
            mb._panText.MinimumSize = new Size(labels.Max(x => x.Width) + ScrollBarWidth(labels), 0);
            mb._panText.MaximumSize = new Size(labels.Max(x => x.Width) + ScrollBarWidth(labels), 300);
            var labelWidth = mb._panText.Width;
            var labelHeight = mb._panText.Height;

            //buttons2
            foreach (var b in buttons)
            {
                mb._panButtons.Controls.Add(b);
                b.Location = new Point(3, 3);
                b.TabIndex = buttons2.FindIndex(i => i.Text == b.Text);
                b.Click += mb.Button_Click;
            }

            var buttonWidth = mb._panButtons.Width;
            var buttonHeight = mb._panButtons.Height;

            //Set Widths
            if (buttonWidth > labelWidth)
            {
                labels.ForEach(l => l.MinimumSize = new Size(buttonWidth - ScrollBarWidth(labels), 1));
                mb._panText.Height = labels.Sum(l => l.Height);
                mb._panText.MinimumSize = new Size(labels.Max(x => x.Width) + ScrollBarWidth(labels), 0);
                mb._panText.MaximumSize = new Size(labels.Max(x => x.Width) + ScrollBarWidth(labels), 300);
                labelWidth = mb._panText.Width;
                labelHeight = mb._panText.Height;
            }

            //Set Height
            var totalHeight = labelHeight + buttonHeight;

            mb._panButtons.Location = new Point(labelWidth / 2 - buttonWidth / 2 + 40,
                mb._panText.Location.Y + mb._panText.Height + 30);

            mb.Size = new Size(labelWidth + 85, totalHeight + 80);
            mb.ShowDialog();
        }

        private readonly FlowLayoutPanel _panText;
        private readonly FlowLayoutPanel _panButtons;

        private static int ScrollBarWidth(IEnumerable<Label> labels)
        {
            return (labels.Sum(l => l.Height) > 300) ? 23 : 6;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            _result = ((Button) sender).DialogResult;
            Close();
        }

        private static DialogResult _result;
    }
}