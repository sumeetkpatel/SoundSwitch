using SoundSwitch.Framework.Configuration.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundSwitch.UI.Forms
{
    public partial class DeviceSelector : Form
    {
        private ICollection<DeviceFullInfo> playbackDevices;

        public EventHandler<DeviceItem> deviceSelected;

        public DeviceSelector(ICollection<DeviceFullInfo> devices)
        {
            InitializeComponent();

            playbackDevices = devices;

            foreach (var playbackDevice in playbackDevices)
            {
                DeviceItem deviceItem = new DeviceItem(playbackDevice);
                devicePanel.Controls.Add(deviceItem);

                deviceItem.Click += DeviceItem_Click;
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            // ESC should close the dialog
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void DeviceItem_Click(object sender, EventArgs e)
        {
            DeviceItem deviceItem = (DeviceItem)sender;
            deviceSelected(this, deviceItem);
        }

        private void doneButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // if click outside dialog -> Close Dlg
            if (m.Msg == (uint)0x0086) //0x86
            {
                if (this.Visible)
                {
                    if (!this.RectangleToScreen(this.DisplayRectangle).Contains(Cursor.Position))
                        this.Close();
                }
            }
        }
    }
}
