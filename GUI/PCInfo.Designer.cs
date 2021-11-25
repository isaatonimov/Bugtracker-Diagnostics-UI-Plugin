
namespace Bugtracker.GUI
{
    partial class PCInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCInfo));
            this.pcInfoText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pcInfoText
            // 
            this.pcInfoText.Location = new System.Drawing.Point(12, 12);
            this.pcInfoText.Multiline = true;
            this.pcInfoText.Name = "pcInfoText";
            this.pcInfoText.ReadOnly = true;
            this.pcInfoText.Size = new System.Drawing.Size(330, 251);
            this.pcInfoText.TabIndex = 0;
            // 
            // PcInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 263);
            this.Controls.Add(this.pcInfoText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PCInfo";
            this.Text = "PC Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pcInfo;
        private System.Windows.Forms.TextBox pcInfoText;
    }
}