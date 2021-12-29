
namespace Bugtracker.GUI
{
    partial class Bugtracker_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bugtracker_Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.applicationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.screenshotCheckbox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.problemDescription = new System.Windows.Forms.TextBox();
            this.problemCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.captureAndSendButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bugtrackTime = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.computerInfosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailversandAktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenshotErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bereichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aufzeichnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproduzierbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeigeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcName = new System.Windows.Forms.Label();
            this.bugtrackLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.configFileSourceLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastConnectionTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.serverStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.applicationPanel.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.applicationPanel);
            this.groupBox1.Location = new System.Drawing.Point(12, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programme";
            // 
            // applicationPanel
            // 
            this.applicationPanel.Controls.Add(this.screenshotCheckbox);
            this.applicationPanel.Location = new System.Drawing.Point(6, 34);
            this.applicationPanel.Name = "applicationPanel";
            this.applicationPanel.Size = new System.Drawing.Size(407, 201);
            this.applicationPanel.TabIndex = 0;
            // 
            // screenshotCheckbox
            // 
            this.screenshotCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.screenshotCheckbox.Checked = true;
            this.screenshotCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.screenshotCheckbox.Location = new System.Drawing.Point(3, 3);
            this.screenshotCheckbox.Margin = new System.Windows.Forms.Padding(3, 3, 300, 3);
            this.screenshotCheckbox.MinimumSize = new System.Drawing.Size(75, 35);
            this.screenshotCheckbox.Name = "screenshotCheckbox";
            this.screenshotCheckbox.Size = new System.Drawing.Size(75, 35);
            this.screenshotCheckbox.TabIndex = 0;
            this.screenshotCheckbox.Text = "Screen";
            this.screenshotCheckbox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // problemDescription
            // 
            this.problemDescription.Location = new System.Drawing.Point(18, 195);
            this.problemDescription.Multiline = true;
            this.problemDescription.Name = "problemDescription";
            this.problemDescription.Size = new System.Drawing.Size(407, 81);
            this.problemDescription.TabIndex = 2;
            // 
            // problemCategories
            // 
            this.problemCategories.FormattingEnabled = true;
            this.problemCategories.Location = new System.Drawing.Point(18, 144);
            this.problemCategories.Name = "problemCategories";
            this.problemCategories.Size = new System.Drawing.Size(407, 23);
            this.problemCategories.TabIndex = 3;
            this.problemCategories.SelectedIndexChanged += new System.EventHandler(this.problemCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Problem Kategorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Problem Beschreibung";
            // 
            // captureAndSendButton
            // 
            this.captureAndSendButton.Location = new System.Drawing.Point(18, 528);
            this.captureAndSendButton.Name = "captureAndSendButton";
            this.captureAndSendButton.Size = new System.Drawing.Size(407, 40);
            this.captureAndSendButton.TabIndex = 6;
            this.captureAndSendButton.Text = "Aufzeichnen und beenden";
            this.captureAndSendButton.UseVisualStyleBackColor = true;
            this.captureAndSendButton.Click += new System.EventHandler(this.captureAndSendButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Problem Zeit";
            // 
            // bugtrackTime
            // 
            this.bugtrackTime.Enabled = false;
            this.bugtrackTime.Location = new System.Drawing.Point(18, 93);
            this.bugtrackTime.Name = "bugtrackTime";
            this.bugtrackTime.Size = new System.Drawing.Size(407, 23);
            this.bugtrackTime.TabIndex = 8;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(834, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerInfosToolStripMenuItem,
            this.mailversandAktivierenToolStripMenuItem,
            this.screenshotErstellenToolStripMenuItem,
            this.aufzeichnenToolStripMenuItem,
            this.beendenToolStripMenuItem,
            this.zeigeLogToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem1.Text = "Aktionen";
            // 
            // computerInfosToolStripMenuItem
            // 
            this.computerInfosToolStripMenuItem.Name = "computerInfosToolStripMenuItem";
            this.computerInfosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.computerInfosToolStripMenuItem.Text = "Computer Infos";
            this.computerInfosToolStripMenuItem.Click += new System.EventHandler(this.computerInfosToolStripMenuItem_Click);
            // 
            // mailversandAktivierenToolStripMenuItem
            // 
            this.mailversandAktivierenToolStripMenuItem.Name = "mailversandAktivierenToolStripMenuItem";
            this.mailversandAktivierenToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.mailversandAktivierenToolStripMenuItem.Text = "Mailversand aktivieren";
            // 
            // screenshotErstellenToolStripMenuItem
            // 
            this.screenshotErstellenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alleToolStripMenuItem,
            this.bereichToolStripMenuItem});
            this.screenshotErstellenToolStripMenuItem.Name = "screenshotErstellenToolStripMenuItem";
            this.screenshotErstellenToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.screenshotErstellenToolStripMenuItem.Text = "Screenshot erstellen";
            // 
            // alleToolStripMenuItem
            // 
            this.alleToolStripMenuItem.Name = "alleToolStripMenuItem";
            this.alleToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.alleToolStripMenuItem.Text = "Alle";
            this.alleToolStripMenuItem.Click += new System.EventHandler(this.MakeScreenshotToolStripMenuItemClick);
            // 
            // bereichToolStripMenuItem
            // 
            this.bereichToolStripMenuItem.Name = "bereichToolStripMenuItem";
            this.bereichToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.bereichToolStripMenuItem.Text = "Bereich";
            // 
            // aufzeichnenToolStripMenuItem
            // 
            this.aufzeichnenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reproduzierbarToolStripMenuItem});
            this.aufzeichnenToolStripMenuItem.Name = "aufzeichnenToolStripMenuItem";
            this.aufzeichnenToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aufzeichnenToolStripMenuItem.Text = "Aufzeichnen";
            // 
            // reproduzierbarToolStripMenuItem
            // 
            this.reproduzierbarToolStripMenuItem.Name = "reproduzierbarToolStripMenuItem";
            this.reproduzierbarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.reproduzierbarToolStripMenuItem.Text = "Reproduzierbar";
            this.reproduzierbarToolStripMenuItem.Click += new System.EventHandler(this.reproduzierbarToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // zeigeLogToolStripMenuItem
            // 
            this.zeigeLogToolStripMenuItem.Name = "zeigeLogToolStripMenuItem";
            this.zeigeLogToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.zeigeLogToolStripMenuItem.Text = "Toggle Log Fenster";
            this.zeigeLogToolStripMenuItem.Click += new System.EventHandler(this.zeigeLogToolStripMenuItem_Click);
            // 
            // pcName
            // 
            this.pcName.AutoSize = true;
            this.pcName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pcName.Location = new System.Drawing.Point(18, 34);
            this.pcName.Name = "pcName";
            this.pcName.Size = new System.Drawing.Size(90, 28);
            this.pcName.TabIndex = 10;
            this.pcName.Text = "PC0X-XX";
            // 
            // bugtrackLog
            // 
            this.bugtrackLog.Location = new System.Drawing.Point(437, 74);
            this.bugtrackLog.Multiline = true;
            this.bugtrackLog.Name = "bugtrackLog";
            this.bugtrackLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bugtrackLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bugtrackLog.Size = new System.Drawing.Size(385, 505);
            this.bugtrackLog.TabIndex = 11;
            this.bugtrackLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(437, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bugtracker Log";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Konfiguration geladen von:";
            // 
            // configFileSourceLabel
            // 
            this.configFileSourceLabel.AutoSize = true;
            this.configFileSourceLabel.Location = new System.Drawing.Point(376, 9);
            this.configFileSourceLabel.Name = "configFileSourceLabel";
            this.configFileSourceLabel.Size = new System.Drawing.Size(46, 15);
            this.configFileSourceLabel.TabIndex = 14;
            this.configFileSourceLabel.Text = "SERVER";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lastConnectionTimeLabel,
            this.serverStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(165, 17);
            this.toolStripStatusLabel1.Text = "Server letztes mal erreicht um:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lastConnectionTimeLabel
            // 
            this.lastConnectionTimeLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lastConnectionTimeLabel.Name = "lastConnectionTimeLabel";
            this.lastConnectionTimeLabel.Size = new System.Drawing.Size(49, 17);
            this.lastConnectionTimeLabel.Text = "16:45:30";
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.serverStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(67, 17);
            this.serverStatusLabel.Text = "Connected";
            this.serverStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // Bugtracker_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 601);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.configFileSourceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bugtrackLog);
            this.Controls.Add(this.pcName);
            this.Controls.Add(this.bugtrackTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.captureAndSendButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.problemCategories);
            this.Controls.Add(this.problemDescription);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Bugtracker_Form";
            this.Text = "Bugtracker";
            this.groupBox1.ResumeLayout(false);
            this.applicationPanel.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel applicationPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox problemDescription;
        private System.Windows.Forms.ComboBox problemCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button captureAndSendButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bugtrackTime;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem computerInfosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailversandAktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenshotErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bereichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aufzeichnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproduzierbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Label pcName;
        private System.Windows.Forms.ToolStripMenuItem zeigeLogToolStripMenuItem;
        private System.Windows.Forms.TextBox bugtrackLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label configFileSourceLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lastConnectionTimeLabel;
        private System.Windows.Forms.CheckBox screenshotCheckbox;
        private System.Windows.Forms.ToolStripStatusLabel serverStatusLabel;
    }
}