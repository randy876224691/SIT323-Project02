namespace SIT323_Project02
{
    partial class MainPage
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
            this.ToolBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCrozzleFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrozzleBox = new System.Windows.Forms.GroupBox();
            this.CrozzlewebBrowser = new System.Windows.Forms.WebBrowser();
            this.WordListBox = new System.Windows.Forms.GroupBox();
            this.WordListlistView = new System.Windows.Forms.ListView();
            this.ErrorBox = new System.Windows.Forms.GroupBox();
            this.ErrorwebBrowser = new System.Windows.Forms.WebBrowser();
            this.OpenCrozzleButton = new System.Windows.Forms.Button();
            this.OpenConfigButton = new System.Windows.Forms.Button();
            this.PointBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pointlabel = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveCrozzle = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.RunningTimeLabel = new System.Windows.Forms.Label();
            this.saveCrozzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar.SuspendLayout();
            this.CrozzleBox.SuspendLayout();
            this.WordListBox.SuspendLayout();
            this.ErrorBox.SuspendLayout();
            this.PointBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(1484, 24);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCrozzleFileToolStripMenuItem,
            this.openConfigurationFileToolStripMenuItem,
            this.errorTestToolStripMenuItem,
            this.saveCrozzleToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCrozzleFileToolStripMenuItem
            // 
            this.openCrozzleFileToolStripMenuItem.Name = "openCrozzleFileToolStripMenuItem";
            this.openCrozzleFileToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openCrozzleFileToolStripMenuItem.Text = "Open Crozzle File";
            this.openCrozzleFileToolStripMenuItem.Click += new System.EventHandler(this.openCrozzleFileToolStripMenuItem_Click);
            // 
            // openConfigurationFileToolStripMenuItem
            // 
            this.openConfigurationFileToolStripMenuItem.Name = "openConfigurationFileToolStripMenuItem";
            this.openConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openConfigurationFileToolStripMenuItem.Text = "Open Configuration File";
            this.openConfigurationFileToolStripMenuItem.Click += new System.EventHandler(this.openConfigurationFileToolStripMenuItem_Click);
            // 
            // errorTestToolStripMenuItem
            // 
            this.errorTestToolStripMenuItem.Name = "errorTestToolStripMenuItem";
            this.errorTestToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.errorTestToolStripMenuItem.Text = "Create Crozzle";
            this.errorTestToolStripMenuItem.Click += new System.EventHandler(this.errorTestToolStripMenuItem_Click);
            // 
            // CrozzleBox
            // 
            this.CrozzleBox.Controls.Add(this.CrozzlewebBrowser);
            this.CrozzleBox.Font = new System.Drawing.Font("Arial", 12F);
            this.CrozzleBox.Location = new System.Drawing.Point(15, 47);
            this.CrozzleBox.Name = "CrozzleBox";
            this.CrozzleBox.Size = new System.Drawing.Size(722, 530);
            this.CrozzleBox.TabIndex = 1;
            this.CrozzleBox.TabStop = false;
            this.CrozzleBox.Text = "Crozzle";
            // 
            // CrozzlewebBrowser
            // 
            this.CrozzlewebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CrozzlewebBrowser.Location = new System.Drawing.Point(6, 26);
            this.CrozzlewebBrowser.MinimumSize = new System.Drawing.Size(20, 22);
            this.CrozzlewebBrowser.Name = "CrozzlewebBrowser";
            this.CrozzlewebBrowser.Size = new System.Drawing.Size(710, 495);
            this.CrozzlewebBrowser.TabIndex = 0;
            // 
            // WordListBox
            // 
            this.WordListBox.Controls.Add(this.WordListlistView);
            this.WordListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordListBox.Location = new System.Drawing.Point(942, 154);
            this.WordListBox.Name = "WordListBox";
            this.WordListBox.Size = new System.Drawing.Size(520, 596);
            this.WordListBox.TabIndex = 2;
            this.WordListBox.TabStop = false;
            this.WordListBox.Text = "WordList";
            // 
            // WordListlistView
            // 
            this.WordListlistView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WordListlistView.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordListlistView.FullRowSelect = true;
            this.WordListlistView.Location = new System.Drawing.Point(6, 25);
            this.WordListlistView.Name = "WordListlistView";
            this.WordListlistView.Size = new System.Drawing.Size(508, 565);
            this.WordListlistView.TabIndex = 0;
            this.WordListlistView.UseCompatibleStateImageBehavior = false;
            this.WordListlistView.View = System.Windows.Forms.View.List;
            this.WordListlistView.SelectedIndexChanged += new System.EventHandler(this.WordListlistView_SelectedIndexChanged);
            // 
            // ErrorBox
            // 
            this.ErrorBox.Controls.Add(this.ErrorwebBrowser);
            this.ErrorBox.Font = new System.Drawing.Font("Arial", 12F);
            this.ErrorBox.Location = new System.Drawing.Point(12, 600);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(725, 150);
            this.ErrorBox.TabIndex = 3;
            this.ErrorBox.TabStop = false;
            this.ErrorBox.Text = "Error";
            // 
            // ErrorwebBrowser
            // 
            this.ErrorwebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorwebBrowser.Location = new System.Drawing.Point(3, 22);
            this.ErrorwebBrowser.MinimumSize = new System.Drawing.Size(20, 22);
            this.ErrorwebBrowser.Name = "ErrorwebBrowser";
            this.ErrorwebBrowser.Size = new System.Drawing.Size(719, 125);
            this.ErrorwebBrowser.TabIndex = 0;
            // 
            // OpenCrozzleButton
            // 
            this.OpenCrozzleButton.Location = new System.Drawing.Point(753, 154);
            this.OpenCrozzleButton.Name = "OpenCrozzleButton";
            this.OpenCrozzleButton.Size = new System.Drawing.Size(170, 38);
            this.OpenCrozzleButton.TabIndex = 4;
            this.OpenCrozzleButton.Text = "Open Crozzle File";
            this.OpenCrozzleButton.UseVisualStyleBackColor = true;
            this.OpenCrozzleButton.Click += new System.EventHandler(this.OpenCrozzleButton_Click);
            // 
            // OpenConfigButton
            // 
            this.OpenConfigButton.Location = new System.Drawing.Point(753, 205);
            this.OpenConfigButton.Name = "OpenConfigButton";
            this.OpenConfigButton.Size = new System.Drawing.Size(170, 38);
            this.OpenConfigButton.TabIndex = 5;
            this.OpenConfigButton.Text = "Open Configuration File";
            this.OpenConfigButton.UseVisualStyleBackColor = true;
            this.OpenConfigButton.Click += new System.EventHandler(this.OpenConfigButton_Click);
            // 
            // PointBox
            // 
            this.PointBox.Controls.Add(this.label1);
            this.PointBox.Controls.Add(this.Pointlabel);
            this.PointBox.Font = new System.Drawing.Font("Arial", 12F);
            this.PointBox.Location = new System.Drawing.Point(753, 49);
            this.PointBox.Name = "PointBox";
            this.PointBox.Size = new System.Drawing.Size(170, 85);
            this.PointBox.TabIndex = 6;
            this.PointBox.TabStop = false;
            this.PointBox.Text = "Point";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "00000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Pointlabel
            // 
            this.Pointlabel.AutoSize = true;
            this.Pointlabel.Location = new System.Drawing.Point(62, 38);
            this.Pointlabel.Name = "Pointlabel";
            this.Pointlabel.Size = new System.Drawing.Size(0, 18);
            this.Pointlabel.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.Navy;
            this.Create.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Create.Location = new System.Drawing.Point(753, 289);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(170, 25);
            this.Create.TabIndex = 7;
            this.Create.Text = "Create Crozzle";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.CreateCrozzle_Click);
            // 
            // saveCrozzle
            // 
            this.saveCrozzle.BackColor = System.Drawing.Color.Navy;
            this.saveCrozzle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.saveCrozzle.Location = new System.Drawing.Point(753, 327);
            this.saveCrozzle.Name = "saveCrozzle";
            this.saveCrozzle.Size = new System.Drawing.Size(170, 25);
            this.saveCrozzle.TabIndex = 8;
            this.saveCrozzle.Text = "Save Crozzle";
            this.saveCrozzle.UseVisualStyleBackColor = false;
            this.saveCrozzle.Click += new System.EventHandler(this.saveCrozzle_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.DarkRed;
            this.timer.Location = new System.Drawing.Point(1108, 49);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(82, 25);
            this.timer.TabIndex = 9;
            this.timer.Text = "00:00:00";
            this.timer.Click += new System.EventHandler(this.label2_Click);
            // 
            // RunningTimeLabel
            // 
            this.RunningTimeLabel.AutoSize = true;
            this.RunningTimeLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunningTimeLabel.Location = new System.Drawing.Point(943, 47);
            this.RunningTimeLabel.Name = "RunningTimeLabel";
            this.RunningTimeLabel.Size = new System.Drawing.Size(160, 29);
            this.RunningTimeLabel.TabIndex = 10;
            this.RunningTimeLabel.Text = "Running Time : ";
            this.RunningTimeLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // saveCrozzleToolStripMenuItem
            // 
            this.saveCrozzleToolStripMenuItem.Name = "saveCrozzleToolStripMenuItem";
            this.saveCrozzleToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.saveCrozzleToolStripMenuItem.Text = "Save Crozzle";
            this.saveCrozzleToolStripMenuItem.Click += new System.EventHandler(this.saveCrozzleToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 762);
            this.Controls.Add(this.RunningTimeLabel);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.saveCrozzle);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.PointBox);
            this.Controls.Add(this.OpenConfigButton);
            this.Controls.Add(this.OpenCrozzleButton);
            this.Controls.Add(this.WordListBox);
            this.Controls.Add(this.CrozzleBox);
            this.Controls.Add(this.ToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ToolBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.CrozzleBox.ResumeLayout(false);
            this.WordListBox.ResumeLayout(false);
            this.ErrorBox.ResumeLayout(false);
            this.PointBox.ResumeLayout(false);
            this.PointBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ToolBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox CrozzleBox;
        private System.Windows.Forms.WebBrowser CrozzlewebBrowser;
        private System.Windows.Forms.GroupBox WordListBox;
        private System.Windows.Forms.ListView WordListlistView;
        private System.Windows.Forms.GroupBox ErrorBox;
        private System.Windows.Forms.Button OpenCrozzleButton;
        private System.Windows.Forms.Button OpenConfigButton;
        private System.Windows.Forms.GroupBox PointBox;
        private System.Windows.Forms.Label Pointlabel;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem openCrozzleFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigurationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorTestToolStripMenuItem;
        private System.Windows.Forms.WebBrowser ErrorwebBrowser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button saveCrozzle;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label RunningTimeLabel;
        private System.Windows.Forms.ToolStripMenuItem saveCrozzleToolStripMenuItem;
    }
}