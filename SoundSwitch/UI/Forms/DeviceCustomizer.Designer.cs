namespace SoundSwitch.UI.Forms
{
    partial class DeviceCustomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceCustomizer));
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customIconPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.iconPathText = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(12, 25);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(465, 20);
            this.nameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Custom Icon Path";
            // 
            // customIconPathDialog
            // 
            this.customIconPathDialog.FileName = "openFileDialog1";
            // 
            // iconPathText
            // 
            this.iconPathText.Location = new System.Drawing.Point(12, 77);
            this.iconPathText.Name = "iconPathText";
            this.iconPathText.Size = new System.Drawing.Size(384, 20);
            this.iconPathText.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(402, 77);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(402, 124);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // DeviceCustomizer
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 159);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.iconPathText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceCustomizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customize Device";
            this.Load += new System.EventHandler(this.DeviceCustomizer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog customIconPathDialog;
        private System.Windows.Forms.TextBox iconPathText;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button saveButton;
    }
}