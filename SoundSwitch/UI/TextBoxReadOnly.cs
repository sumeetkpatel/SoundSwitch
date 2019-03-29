using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundSwitch.UI
{
    public class TextBoxReadOnly : TextBox
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public bool SelectionHighlightEnabled { get; set; }

        const int WM_SETFOCUS = 0x0007;
        const int WM_KILLFOCUS = 0x0008;
        [DefaultValue(true)]

        public TextBoxReadOnly()
        {
            this.ReadOnly = true;
            this.BackColor = Color.White;
            this.GotFocus += TextBoxGotFocus;
            this.Cursor = Cursors.Arrow; // mouse cursor like in other controls 

            this.SelectionHighlightEnabled = false;
        }

        private void TextBoxGotFocus(object sender, EventArgs args)
        {
            HideCaret(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SETFOCUS && !SelectionHighlightEnabled)
                m.Msg = WM_KILLFOCUS;

            base.WndProc(ref m);
        }
    }
}
