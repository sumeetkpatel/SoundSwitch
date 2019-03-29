using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoundSwitch.Framework.Configuration.Device;
using System.Text.RegularExpressions;
using System.IO;

namespace SoundSwitch.UI.Forms
{
    public partial class DeviceItem : UserControl
    {
        public DeviceFullInfo AudioDevice;

        public DeviceItem(DeviceFullInfo deviceInfo)
        {
            InitializeComponent();

            AudioDevice = deviceInfo;

            //Device Name
            if (deviceInfo.CustomName != null && !String.IsNullOrEmpty(deviceInfo.CustomName))
            {
                deviceName.Text = deviceInfo.CustomName;
            }
            else
            {
                Regex regex = new Regex(@"(.+) \(.*\)", RegexOptions.IgnoreCase);
                Match match = regex.Match(deviceInfo.Name);
                String simpleName = match.Groups[1].ToString();
                deviceName.Text = simpleName;
            }

            //Device Image
            if (deviceInfo.CustomIconPath != null && !String.IsNullOrEmpty(deviceInfo.CustomIconPath) && File.Exists(deviceInfo.CustomIconPath))
            {
                image.Image = Image.FromFile(deviceInfo.CustomIconPath);
            }
            else
            {
                image.Image = deviceInfo.LargeIcon.ToBitmap();
            }

            //Handle clicks and hovers
            foreach (Control control in Controls)
            {
                control.Click += (sender, args) => OnClick(args);
                control.MouseEnter += (sender, args) => DeviceItem_MouseEnter(sender, args);
                control.MouseLeave += (sender, args) => DeviceItem_MouseLeave(sender, args);
            }

            deviceName.Click += (sender, args) => OnClick(args);
            deviceName.MouseEnter += (sender, args) => DeviceItem_MouseEnter(sender, args);
            deviceName.MouseLeave += (sender, args) => DeviceItem_MouseLeave(sender, args);

            //Hover coloring
            BackColor = SystemColors.MenuBar;
            deviceName.BackColor = SystemColors.MenuBar;
            deviceName.ForeColor = SystemColors.MenuText;

            MouseEnter += DeviceItem_MouseEnter;
            MouseLeave += DeviceItem_MouseLeave;

            deviceName.SelectionStart = 0;
            deviceName.SelectionLength = 0;
        }

        private void DeviceItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.MenuBar;

            deviceName.BackColor = SystemColors.MenuBar;
            deviceName.ForeColor = SystemColors.MenuText;
        }

        private void DeviceItem_MouseEnter(object sender, EventArgs e)
        {
            BackColor = SystemColors.MenuHighlight;
            
            deviceName.BackColor = SystemColors.MenuHighlight;
            deviceName.ForeColor = SystemColors.HighlightText;
        }
    }
}
