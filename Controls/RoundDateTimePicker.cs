using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace filmhub.Controls
{

    public class RoundDateTimePicker: DateTimePicker
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // X-coordinate of upper-left corner or padding at start
            int nTopRect, // Y-coordinate of upper-left corner or padding at the top of the textbox
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect, // Y-coordinate of lower-right corner or Height of the object
            //RADIUS, how round do you want it to be?
            int nheightRect, //height of ellipse 
            int nweightRect //width of ellipse
        );

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Region =
                Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, 
                    15,15));
        }
        
        private readonly Color _backDisabledColor;

        public RoundDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            _backDisabledColor = Color.FromKnownColor(KnownColor.Control);
        }

        /// <summary>
        ///     Gets or sets the background color of the control
        /// </summary>
        [Browsable(true)]
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            var g = CreateGraphics();
            //Graphics g = e.Graphics;
            
            //The dropDownRectangle defines position and size of dropdownbutton block, 
            //the width is fixed to 17 and height to 16. The dropdownbutton is aligned to right
            var dropDownRectangle = new Rectangle(ClientRectangle.Width - 17, 0, 17, 32);
            Brush bkgBrush;
            ComboBoxState visualState;

            //When the control is enabled the brush is set to Backcolor, 
            //otherwise to color stored in _backDisabledColor
            if (this.Enabled) {
                 bkgBrush = new SolidBrush(BackColor);
                 visualState = ComboBoxState.Normal;
            }
            else {
                bkgBrush = new SolidBrush(_backDisabledColor);
                visualState = ComboBoxState.Disabled;
            }

            // Painting...in action

            //Filling the background
            g.FillRectangle(bkgBrush, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
            
            //Drawing the datetime text
            g.DrawString(this.Text, this.Font, new SolidBrush(Program.Colors.FieldDarkTextColor), 0, 2);

            //Drawing the dropdownbutton using ComboBoxRenderer
            ComboBoxRenderer.DrawDropDownButton(g, dropDownRectangle, visualState);

            g.Dispose();
            bkgBrush.Dispose();
        }
    }
}