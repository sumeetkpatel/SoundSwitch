namespace SoundSwitch.UI.Forms
{
    partial class DeviceSelector
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceSelector));
            this.doneButton = new System.Windows.Forms.Button();
            this.devicePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(38, 72);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(150, 45);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "DONE";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Visible = false;
            this.doneButton.Click += new System.EventHandler(this.doneButtonClick);
            // 
            // devicePanel
            // 
            this.devicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devicePanel.AutoSize = true;
            this.devicePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.devicePanel.Location = new System.Drawing.Point(12, 12);
            this.devicePanel.MinimumSize = new System.Drawing.Size(200, 100);
            this.devicePanel.Name = "devicePanel";
            this.devicePanel.Size = new System.Drawing.Size(200, 100);
            this.devicePanel.TabIndex = 2;
            this.devicePanel.WrapContents = false;
            // 
            // DeviceSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(222, 121);
            this.ControlBox = false;
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.devicePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Playback Device";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.FlowLayoutPanel devicePanel;
    }
}