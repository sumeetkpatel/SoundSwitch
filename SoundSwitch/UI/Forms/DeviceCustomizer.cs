using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundSwitch.UI.Forms
{
    public partial class DeviceCustomizer : Form
    {
        public string CustomName;
        public string CustomPath;

        public DeviceCustomizer(string customName, string customPath)
        {
            InitializeComponent();

            saveButton.Click += SaveButton_Click;

            nameText.Text = customName;
            iconPathText.Text = customPath;

            customIconPathDialog.Title = @"Select Device Image";
            customIconPathDialog.Filter = @"Images(*.BMP; *.JPG; *.GIF,*.PNG,*.TIFF)| *.BMP; *.JPG; *.GIF; *.PNG; *.TIFF | " +  
"All files (*.*)|*.*";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CustomName = nameText.Text;
            CustomPath = iconPathText.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void DeviceCustomizer_Load(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = customIconPathDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                iconPathText.Text = customIconPathDialog.FileName;
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
    }
}
