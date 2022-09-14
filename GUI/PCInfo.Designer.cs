
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCInfo));
            this.pcInfoText = new System.Windows.Forms.TextBox();
            this.targetManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.targetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variablesTab = new System.Windows.Forms.TabPage();
            this.dataGridVariables = new System.Windows.Forms.DataGridView();
            this.pluginsTab = new System.Windows.Forms.TabPage();
            this.pluginsList = new System.Windows.Forms.ListBox();
            this.Plugins = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.targetManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetsBindingSource)).BeginInit();
            this.variablesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVariables)).BeginInit();
            this.pluginsTab.SuspendLayout();
            this.Plugins.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcInfoText
            // 
            this.pcInfoText.BackColor = System.Drawing.Color.White;
            this.pcInfoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcInfoText.ForeColor = System.Drawing.Color.Black;
            this.pcInfoText.Location = new System.Drawing.Point(6, 6);
            this.pcInfoText.Multiline = true;
            this.pcInfoText.Name = "pcInfoText";
            this.pcInfoText.ReadOnly = true;
            this.pcInfoText.Size = new System.Drawing.Size(413, 392);
            this.pcInfoText.TabIndex = 0;
            this.pcInfoText.TextChanged += new System.EventHandler(this.pcInfoText_TextChanged);
            // 
            // targetManagerBindingSource
            // 
            this.targetManagerBindingSource.DataSource = typeof(Bugtracker.Targeting.TargetManager);
            // 
            // targetsBindingSource
            // 
            this.targetsBindingSource.DataMember = "Targets";
            this.targetsBindingSource.DataSource = this.targetManagerBindingSource;
            // 
            // variablesTab
            // 
            this.variablesTab.BackColor = System.Drawing.Color.White;
            this.variablesTab.Controls.Add(this.dataGridVariables);
            this.variablesTab.Location = new System.Drawing.Point(4, 24);
            this.variablesTab.Name = "variablesTab";
            this.variablesTab.Padding = new System.Windows.Forms.Padding(3);
            this.variablesTab.Size = new System.Drawing.Size(425, 404);
            this.variablesTab.TabIndex = 1;
            this.variablesTab.Text = "Variablen";
            // 
            // dataGridVariables
            // 
            this.dataGridVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVariables.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVariables.GridColor = System.Drawing.Color.Black;
            this.dataGridVariables.Location = new System.Drawing.Point(6, 6);
            this.dataGridVariables.Name = "dataGridVariables";
            this.dataGridVariables.RowHeadersWidth = 4;
            this.dataGridVariables.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridVariables.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridVariables.RowTemplate.Height = 25;
            this.dataGridVariables.RowTemplate.ReadOnly = true;
            this.dataGridVariables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridVariables.Size = new System.Drawing.Size(413, 392);
            this.dataGridVariables.TabIndex = 0;
            // 
            // pluginsTab
            // 
            this.pluginsTab.BackColor = System.Drawing.Color.White;
            this.pluginsTab.Controls.Add(this.pluginsList);
            this.pluginsTab.ForeColor = System.Drawing.Color.Black;
            this.pluginsTab.Location = new System.Drawing.Point(4, 24);
            this.pluginsTab.Name = "pluginsTab";
            this.pluginsTab.Padding = new System.Windows.Forms.Padding(3);
            this.pluginsTab.Size = new System.Drawing.Size(425, 404);
            this.pluginsTab.TabIndex = 0;
            this.pluginsTab.Text = "Pugins";
            // 
            // pluginsList
            // 
            this.pluginsList.BackColor = System.Drawing.Color.White;
            this.pluginsList.ForeColor = System.Drawing.Color.Black;
            this.pluginsList.FormattingEnabled = true;
            this.pluginsList.ItemHeight = 15;
            this.pluginsList.Location = new System.Drawing.Point(6, 6);
            this.pluginsList.Name = "pluginsList";
            this.pluginsList.Size = new System.Drawing.Size(413, 394);
            this.pluginsList.TabIndex = 2;
            // 
            // Plugins
            // 
            this.Plugins.Controls.Add(this.generalTab);
            this.Plugins.Controls.Add(this.variablesTab);
            this.Plugins.Controls.Add(this.pluginsTab);
            this.Plugins.Location = new System.Drawing.Point(12, 56);
            this.Plugins.Name = "Plugins";
            this.Plugins.SelectedIndex = 0;
            this.Plugins.Size = new System.Drawing.Size(433, 432);
            this.Plugins.TabIndex = 0;
            // 
            // generalTab
            // 
            this.generalTab.BackColor = System.Drawing.Color.White;
            this.generalTab.Controls.Add(this.pcInfoText);
            this.generalTab.Location = new System.Drawing.Point(4, 24);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTab.Size = new System.Drawing.Size(425, 404);
            this.generalTab.TabIndex = 2;
            this.generalTab.Text = "Generell";
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::Bugtracker_UI.Properties.Resources.exit_icon;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(420, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 5;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Information";
            // 
            // PCInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(451, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.Plugins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PCInfo";
            this.Text = "PC Information";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCInfo_Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.targetManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetsBindingSource)).EndInit();
            this.variablesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVariables)).EndInit();
            this.pluginsTab.ResumeLayout(false);
            this.Plugins.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pcInfo;
        private System.Windows.Forms.TextBox pcInfoText;
        private BindingSource targetManagerBindingSource;
        private BindingSource targetsBindingSource;
        private TabPage variablesTab;
        private DataGridView dataGridVariables;
        private TabPage pluginsTab;
        private ListBox pluginsList;
        private TabControl Plugins;
        private TabPage generalTab;
        private Button exitButton;
        private Label label2;
    }
}