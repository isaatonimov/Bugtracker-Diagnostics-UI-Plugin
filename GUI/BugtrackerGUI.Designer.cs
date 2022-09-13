
namespace Bugtracker.GUI
{
    partial class Bugtracker_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bugtracker_Main_Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.applicationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.applicationCheckbox = new System.Windows.Forms.CheckBox();
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
            this.ToggleLog = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funktionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsUmbennennToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcName = new System.Windows.Forms.Label();
            this.bugtrackLog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.configFileSourceLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastConnectionTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.serverStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selection_screenshot_button = new System.Windows.Forms.Button();
            this.procedure_screenshot_button = new System.Windows.Forms.Button();
            this.full_screenshot_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.applicationPanel.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.applicationPanel);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(18, 573);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(330, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programme";
            // 
            // applicationPanel
            // 
            this.applicationPanel.Controls.Add(this.applicationCheckbox);
            this.applicationPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.applicationPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.applicationPanel.Location = new System.Drawing.Point(0, 22);
            this.applicationPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.applicationPanel.Name = "applicationPanel";
            this.applicationPanel.Padding = new System.Windows.Forms.Padding(8);
            this.applicationPanel.Size = new System.Drawing.Size(315, 272);
            this.applicationPanel.TabIndex = 0;
            this.applicationPanel.WrapContents = false;
            // 
            // applicationCheckbox
            // 
            this.applicationCheckbox.Checked = true;
            this.applicationCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.applicationCheckbox.ForeColor = System.Drawing.Color.Black;
            this.applicationCheckbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.applicationCheckbox.Location = new System.Drawing.Point(10, 10);
            this.applicationCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.applicationCheckbox.MaximumSize = new System.Drawing.Size(142, 67);
            this.applicationCheckbox.Name = "applicationCheckbox";
            this.applicationCheckbox.Padding = new System.Windows.Forms.Padding(2);
            this.applicationCheckbox.Size = new System.Drawing.Size(142, 33);
            this.applicationCheckbox.TabIndex = 1;
            this.applicationCheckbox.Text = "Screen";
            this.applicationCheckbox.UseVisualStyleBackColor = true;
            this.applicationCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // problemDescription
            // 
            this.problemDescription.ForeColor = System.Drawing.Color.Black;
            this.problemDescription.Location = new System.Drawing.Point(18, 330);
            this.problemDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.problemDescription.Multiline = true;
            this.problemDescription.Name = "problemDescription";
            this.problemDescription.Size = new System.Drawing.Size(322, 231);
            this.problemDescription.TabIndex = 2;
            // 
            // problemCategories
            // 
            this.problemCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.problemCategories.ForeColor = System.Drawing.Color.Black;
            this.problemCategories.FormattingEnabled = true;
            this.problemCategories.Location = new System.Drawing.Point(18, 245);
            this.problemCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.problemCategories.Name = "problemCategories";
            this.problemCategories.Size = new System.Drawing.Size(322, 33);
            this.problemCategories.TabIndex = 3;
            this.problemCategories.SelectedIndexChanged += new System.EventHandler(this.problemCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Problem Kategorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Problem Beschreibung";
            // 
            // captureAndSendButton
            // 
            this.captureAndSendButton.FlatAppearance.BorderSize = 0;
            this.captureAndSendButton.ForeColor = System.Drawing.Color.Black;
            this.captureAndSendButton.Location = new System.Drawing.Point(18, 885);
            this.captureAndSendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.captureAndSendButton.Name = "captureAndSendButton";
            this.captureAndSendButton.Size = new System.Drawing.Size(324, 55);
            this.captureAndSendButton.TabIndex = 6;
            this.captureAndSendButton.Text = "Aufzeichnen und beenden";
            this.captureAndSendButton.UseVisualStyleBackColor = false;
            this.captureAndSendButton.Click += new System.EventHandler(this.CaptureSendCloseButton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(26, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Problem Zeit";
            // 
            // bugtrackTime
            // 
            this.bugtrackTime.ForeColor = System.Drawing.Color.Black;
            this.bugtrackTime.Location = new System.Drawing.Point(18, 160);
            this.bugtrackTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bugtrackTime.Name = "bugtrackTime";
            this.bugtrackTime.ReadOnly = true;
            this.bugtrackTime.Size = new System.Drawing.Size(322, 31);
            this.bugtrackTime.TabIndex = 8;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.funktionenToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(526, 35);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerInfosToolStripMenuItem,
            this.mailversandAktivierenToolStripMenuItem,
            this.ToggleLog,
            this.beendenToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 29);
            this.toolStripMenuItem1.Text = "Optionen";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // computerInfosToolStripMenuItem
            // 
            this.computerInfosToolStripMenuItem.Name = "computerInfosToolStripMenuItem";
            this.computerInfosToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.computerInfosToolStripMenuItem.Text = "Computer Infos";
            this.computerInfosToolStripMenuItem.Click += new System.EventHandler(this.ComputerInfoToolStrip);
            // 
            // mailversandAktivierenToolStripMenuItem
            // 
            this.mailversandAktivierenToolStripMenuItem.Enabled = false;
            this.mailversandAktivierenToolStripMenuItem.Name = "mailversandAktivierenToolStripMenuItem";
            this.mailversandAktivierenToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.mailversandAktivierenToolStripMenuItem.Text = "Mailversand aktivieren";
            // 
            // ToggleLog
            // 
            this.ToggleLog.Name = "ToggleLog";
            this.ToggleLog.Size = new System.Drawing.Size(289, 34);
            this.ToggleLog.Text = "Toggle Log Fenster";
            this.ToggleLog.Click += new System.EventHandler(this.ToggleLogToolStrip);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStrip);
            // 
            // funktionenToolStripMenuItem
            // 
            this.funktionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logsLöschenToolStripMenuItem,
            this.logsUmbennennToolStripMenuItem});
            this.funktionenToolStripMenuItem.Name = "funktionenToolStripMenuItem";
            this.funktionenToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.funktionenToolStripMenuItem.Text = "Aktionen";
            // 
            // logsLöschenToolStripMenuItem
            // 
            this.logsLöschenToolStripMenuItem.Enabled = false;
            this.logsLöschenToolStripMenuItem.Name = "logsLöschenToolStripMenuItem";
            this.logsLöschenToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.logsLöschenToolStripMenuItem.Text = "Logs löschen";
            this.logsLöschenToolStripMenuItem.Click += new System.EventHandler(this.DeleteTargetedLogsToolStrip);
            // 
            // logsUmbennennToolStripMenuItem
            // 
            this.logsUmbennennToolStripMenuItem.Enabled = false;
            this.logsUmbennennToolStripMenuItem.Name = "logsUmbennennToolStripMenuItem";
            this.logsUmbennennToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.logsUmbennennToolStripMenuItem.Text = "Logs umbenennen";
            this.logsUmbennennToolStripMenuItem.Click += new System.EventHandler(this.RenameTargetedLogsToolStrip);
            // 
            // pcName
            // 
            this.pcName.AutoSize = true;
            this.pcName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pcName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pcName.Location = new System.Drawing.Point(18, 48);
            this.pcName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pcName.Name = "pcName";
            this.pcName.Size = new System.Drawing.Size(136, 41);
            this.pcName.TabIndex = 10;
            this.pcName.Text = "PC0X-XX";
            // 
            // bugtrackLog
            // 
            this.bugtrackLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bugtrackLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bugtrackLog.ForeColor = System.Drawing.Color.White;
            this.bugtrackLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bugtrackLog.Location = new System.Drawing.Point(528, 62);
            this.bugtrackLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bugtrackLog.Multiline = true;
            this.bugtrackLog.Name = "bugtrackLog";
            this.bugtrackLog.ReadOnly = true;
            this.bugtrackLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bugtrackLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bugtrackLog.Size = new System.Drawing.Size(464, 975);
            this.bugtrackLog.TabIndex = 11;
            this.bugtrackLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 945);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Konfiguration geladen von:";
            // 
            // configFileSourceLabel
            // 
            this.configFileSourceLabel.AutoSize = true;
            this.configFileSourceLabel.ForeColor = System.Drawing.Color.Black;
            this.configFileSourceLabel.Location = new System.Drawing.Point(260, 945);
            this.configFileSourceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.configFileSourceLabel.Name = "configFileSourceLabel";
            this.configFileSourceLabel.Size = new System.Drawing.Size(73, 25);
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
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lastConnectionTimeLabel,
            this.serverStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1051);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 20, 0);
            this.statusStrip1.Size = new System.Drawing.Size(526, 32);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(248, 25);
            this.toolStripStatusLabel1.Text = "Server letztes mal erreicht um:";
            // 
            // lastConnectionTimeLabel
            // 
            this.lastConnectionTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.lastConnectionTimeLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lastConnectionTimeLabel.Name = "lastConnectionTimeLabel";
            this.lastConnectionTimeLabel.Size = new System.Drawing.Size(80, 25);
            this.lastConnectionTimeLabel.Text = "16:45:30";
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.serverStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(103, 25);
            this.serverStatusLabel.Text = "Connected";
            // 
            // selection_screenshot_button
            // 
            this.selection_screenshot_button.BackColor = System.Drawing.Color.Transparent;
            this.selection_screenshot_button.BackgroundImage = global::Bugtracker_UI.Properties.Resources.icon_selection_screen;
            this.selection_screenshot_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selection_screenshot_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.selection_screenshot_button.FlatAppearance.BorderSize = 0;
            this.selection_screenshot_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selection_screenshot_button.Location = new System.Drawing.Point(40, 353);
            this.selection_screenshot_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selection_screenshot_button.Name = "selection_screenshot_button";
            this.selection_screenshot_button.Size = new System.Drawing.Size(88, 75);
            this.selection_screenshot_button.TabIndex = 19;
            this.selection_screenshot_button.UseVisualStyleBackColor = false;
            this.selection_screenshot_button.Click += new System.EventHandler(this.selection_screenshot_button_Click);
            // 
            // procedure_screenshot_button
            // 
            this.procedure_screenshot_button.BackColor = System.Drawing.Color.Transparent;
            this.procedure_screenshot_button.BackgroundImage = global::Bugtracker_UI.Properties.Resources.icon_procedure_screen;
            this.procedure_screenshot_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.procedure_screenshot_button.Enabled = false;
            this.procedure_screenshot_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.procedure_screenshot_button.FlatAppearance.BorderSize = 0;
            this.procedure_screenshot_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.procedure_screenshot_button.Location = new System.Drawing.Point(16, 203);
            this.procedure_screenshot_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.procedure_screenshot_button.Name = "procedure_screenshot_button";
            this.procedure_screenshot_button.Size = new System.Drawing.Size(132, 110);
            this.procedure_screenshot_button.TabIndex = 18;
            this.procedure_screenshot_button.UseVisualStyleBackColor = false;
            this.procedure_screenshot_button.Click += new System.EventHandler(this.procedure_screenshot_button_Click);
            // 
            // full_screenshot_button
            // 
            this.full_screenshot_button.BackColor = System.Drawing.Color.Transparent;
            this.full_screenshot_button.BackgroundImage = global::Bugtracker_UI.Properties.Resources.icon_full_screen;
            this.full_screenshot_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.full_screenshot_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.full_screenshot_button.FlatAppearance.BorderSize = 0;
            this.full_screenshot_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.full_screenshot_button.Location = new System.Drawing.Point(16, 48);
            this.full_screenshot_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.full_screenshot_button.Name = "full_screenshot_button";
            this.full_screenshot_button.Size = new System.Drawing.Size(132, 110);
            this.full_screenshot_button.TabIndex = 17;
            this.full_screenshot_button.UseVisualStyleBackColor = false;
            this.full_screenshot_button.Click += new System.EventHandler(this.full_screenshot_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Vollaufnahme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(42, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Schritte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Teilbereich";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.full_screenshot_button);
            this.panel1.Controls.Add(this.procedure_screenshot_button);
            this.panel1.Controls.Add(this.selection_screenshot_button);
            this.panel1.Location = new System.Drawing.Point(356, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 975);
            this.panel1.TabIndex = 22;
            // 
            // Bugtracker_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 1083);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.configFileSourceLabel);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Bugtracker_Main_Form";
            this.Text = "Bugtracker";
            this.Load += new System.EventHandler(this.Bugtracker_Main_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bugtracker_Main_Form_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.applicationPanel.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel applicationPanel;
        private System.Windows.Forms.TextBox problemDescription;
        private System.Windows.Forms.ComboBox problemCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button captureAndSendButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bugtrackTime;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mailversandAktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Label pcName;
        private System.Windows.Forms.ToolStripMenuItem ToggleLog;
        private System.Windows.Forms.TextBox bugtrackLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label configFileSourceLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lastConnectionTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel serverStatusLabel;
        private ToolStripMenuItem funktionenToolStripMenuItem;
        private ToolStripMenuItem computerInfosToolStripMenuItem;
        private ToolStripMenuItem logsLöschenToolStripMenuItem;
        private ToolStripMenuItem logsUmbennennToolStripMenuItem;
        private Button selection_screenshot_button;
        private Button procedure_screenshot_button;
        private Button full_screenshot_button;
        private Label label4;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private CheckBox applicationCheckbox;
    }
}