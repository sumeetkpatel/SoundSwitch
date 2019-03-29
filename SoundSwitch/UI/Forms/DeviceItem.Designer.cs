namespace SoundSwitch.UI.Forms
{
    partial class DeviceItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.image = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deviceName = new SoundSwitch.UI.TextBoxReadOnly();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.Location = new System.Drawing.Point(0, 10);
            this.image.MinimumSize = new System.Drawing.Size(32, 32);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(200, 130);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.deviceName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.MinimumSize = new System.Drawing.Size(200, 50);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 2;
            // 
            // deviceName
            // 
            this.deviceName.BackColor = System.Drawing.SystemColors.Control;
            this.deviceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deviceName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.deviceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceName.Location = new System.Drawing.Point(0, 10);
            this.deviceName.Multiline = true;
            this.deviceName.Name = "deviceName";
            this.deviceName.ReadOnly = true;
            this.deviceName.ShortcutsEnabled = false;
            this.deviceName.Size = new System.Drawing.Size(200, 40);
            this.deviceName.TabIndex = 4;
            this.deviceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.image);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "DeviceItem";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Size = new System.Drawing.Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Panel panel1;
        private TextBoxReadOnly deviceName;
    }
}
