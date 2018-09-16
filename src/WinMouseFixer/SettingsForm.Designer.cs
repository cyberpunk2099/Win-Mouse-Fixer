namespace WinMouseFixer
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.popup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runningMi = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delayDisplay = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.mouseRight = new System.Windows.Forms.RadioButton();
            this.mouseLeft = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.running = new System.Windows.Forms.CheckBox();
            this.indicator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.popup.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.popup;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Win Mouse Fixer - RUNNING";
            this.notifyIcon.Visible = true;
            // 
            // popup
            // 
            this.popup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runningMi,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.popup.Name = "popup";
            this.popup.Size = new System.Drawing.Size(164, 76);
            // 
            // runningMi
            // 
            this.runningMi.Checked = true;
            this.runningMi.CheckOnClick = true;
            this.runningMi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.runningMi.Name = "runningMi";
            this.runningMi.Size = new System.Drawing.Size(163, 22);
            this.runningMi.Text = "Fix Double Clicks";
            this.runningMi.CheckedChanged += new System.EventHandler(this.FixCheckedChanged);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Quit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitClick);
            // 
            // delayDisplay
            // 
            this.delayDisplay.AutoSize = true;
            this.delayDisplay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayDisplay.Location = new System.Drawing.Point(146, 51);
            this.delayDisplay.Name = "delayDisplay";
            this.delayDisplay.Size = new System.Drawing.Size(62, 13);
            this.delayDisplay.TabIndex = 4;
            this.delayDisplay.Text = "<= 200 ms";
            this.delayDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPanel.Controls.Add(this.indicator);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.delayDisplay);
            this.settingsPanel.Controls.Add(this.delay);
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.mouseRight);
            this.settingsPanel.Controls.Add(this.mouseLeft);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Location = new System.Drawing.Point(85, 12);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(247, 139);
            this.settingsPanel.TabIndex = 5;
            this.settingsPanel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "For delay";
            // 
            // delay
            // 
            this.delay.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WinMouseFixer.Properties.Settings.Default, "MouseButtonDelay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.delay.LargeChange = 100;
            this.delay.Location = new System.Drawing.Point(66, 46);
            this.delay.Maximum = 300;
            this.delay.Minimum = 50;
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(74, 45);
            this.delay.SmallChange = 50;
            this.delay.TabIndex = 8;
            this.delay.TickFrequency = 50;
            this.delay.Value = global::WinMouseFixer.Properties.Settings.Default.MouseButtonDelay;
            this.delay.Scroll += new System.EventHandler(this.DelayScroll);
            this.delay.ValueChanged += new System.EventHandler(this.DelayChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "mouse button";
            // 
            // mouseRight
            // 
            this.mouseRight.AutoSize = true;
            this.mouseRight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseRight.Location = new System.Drawing.Point(87, 23);
            this.mouseRight.Name = "mouseRight";
            this.mouseRight.Size = new System.Drawing.Size(53, 17);
            this.mouseRight.TabIndex = 6;
            this.mouseRight.Text = "Right";
            this.mouseRight.UseVisualStyleBackColor = true;
            this.mouseRight.CheckedChanged += new System.EventHandler(this.MouseButtonChanged);
            this.mouseRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChkMouseDown);
            // 
            // mouseLeft
            // 
            this.mouseLeft.AutoSize = true;
            this.mouseLeft.Checked = true;
            this.mouseLeft.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseLeft.Location = new System.Drawing.Point(36, 23);
            this.mouseLeft.Name = "mouseLeft";
            this.mouseLeft.Size = new System.Drawing.Size(45, 17);
            this.mouseLeft.TabIndex = 5;
            this.mouseLeft.TabStop = true;
            this.mouseLeft.Text = "Left";
            this.mouseLeft.UseVisualStyleBackColor = true;
            this.mouseLeft.CheckedChanged += new System.EventHandler(this.MouseButtonChanged);
            this.mouseLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChkMouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "For";
            // 
            // about
            // 
            this.about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.about.Location = new System.Drawing.Point(257, 157);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(75, 23);
            this.about.TabIndex = 7;
            this.about.Text = "About...";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.AboutClick);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Location = new System.Drawing.Point(257, 186);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 8;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.CloseClick);
            // 
            // running
            // 
            this.running.AutoSize = true;
            this.running.Checked = global::WinMouseFixer.Properties.Settings.Default.Running;
            this.running.CheckState = System.Windows.Forms.CheckState.Checked;
            this.running.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMouseFixer.Properties.Settings.Default, "Running", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.running.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.running.Location = new System.Drawing.Point(94, 12);
            this.running.Name = "running";
            this.running.Size = new System.Drawing.Size(134, 17);
            this.running.TabIndex = 6;
            this.running.Text = "Prevent Double Click";
            this.running.UseVisualStyleBackColor = true;
            this.running.CheckedChanged += new System.EventHandler(this.RunningChanged);
            // 
            // indicator
            // 
            this.indicator.AutoSize = true;
            this.indicator.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator.Location = new System.Drawing.Point(6, 94);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(42, 13);
            this.indicator.TabIndex = 10;
            this.indicator.Text = "0 fixed";
            this.indicator.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinMouseFixer.Properties.Resources.Computer_Hardware_Mouse_Left_Click_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 221);
            this.Controls.Add(this.close);
            this.Controls.Add(this.about);
            this.Controls.Add(this.running);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win Mouse Fixer - RUNNING";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsFormClosed);
            this.Load += new System.EventHandler(this.SettingsFormLoad);
            this.popup.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label delayDisplay;
        private System.Windows.Forms.GroupBox settingsPanel;
        private System.Windows.Forms.RadioButton mouseLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton mouseRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar delay;
        private System.Windows.Forms.CheckBox running;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ContextMenuStrip popup;
        private System.Windows.Forms.ToolStripMenuItem runningMi;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label indicator;
    }
}

