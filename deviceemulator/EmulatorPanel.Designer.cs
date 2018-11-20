namespace deviceemulator
{
    partial class EmulatorPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPayload = new System.Windows.Forms.TextBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTotalCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxThreads = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.panelPayload = new System.Windows.Forms.Panel();
            this.linkLabelPayloadHelp = new System.Windows.Forms.LinkLabel();
            this.panelDevices = new System.Windows.Forms.Panel();
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.tabControlData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxThreads)).BeginInit();
            this.panelControl.SuspendLayout();
            this.panelPayload.SuspendLayout();
            this.panelDevices.SuspendLayout();
            this.tabControlData.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delay (ms):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payload:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Devices:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "(approximate number of messages to send)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "(delay in ms between Send operations)";
            // 
            // textBoxPayload
            // 
            this.textBoxPayload.AcceptsReturn = true;
            this.textBoxPayload.AcceptsTab = true;
            this.textBoxPayload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPayload.Location = new System.Drawing.Point(78, 10);
            this.textBoxPayload.Multiline = true;
            this.textBoxPayload.Name = "textBoxPayload";
            this.textBoxPayload.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPayload.Size = new System.Drawing.Size(388, 84);
            this.textBoxPayload.TabIndex = 8;
            this.textBoxPayload.TextChanged += new System.EventHandler(this.textBoxPayload_TextChanged);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.numericUpDownDelay);
            this.panelSettings.Controls.Add(this.numericUpDownTotalCount);
            this.panelSettings.Controls.Add(this.numericUpDownMaxThreads);
            this.panelSettings.Controls.Add(this.label7);
            this.panelSettings.Controls.Add(this.panelControl);
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.label6);
            this.panelSettings.Controls.Add(this.label5);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(480, 87);
            this.panelSettings.TabIndex = 9;
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Location = new System.Drawing.Point(90, 34);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownDelay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownDelay.TabIndex = 16;
            this.numericUpDownDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDelay.ValueChanged += new System.EventHandler(this.numericUpDownDelay_ValueChanged);
            // 
            // numericUpDownTotalCount
            // 
            this.numericUpDownTotalCount.Location = new System.Drawing.Point(90, 8);
            this.numericUpDownTotalCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownTotalCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTotalCount.Name = "numericUpDownTotalCount";
            this.numericUpDownTotalCount.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownTotalCount.TabIndex = 15;
            this.numericUpDownTotalCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownTotalCount.ValueChanged += new System.EventHandler(this.numericUpDownTotalCount_ValueChanged);
            // 
            // numericUpDownMaxThreads
            // 
            this.numericUpDownMaxThreads.Location = new System.Drawing.Point(90, 60);
            this.numericUpDownMaxThreads.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownMaxThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxThreads.Name = "numericUpDownMaxThreads";
            this.numericUpDownMaxThreads.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownMaxThreads.TabIndex = 14;
            this.numericUpDownMaxThreads.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownMaxThreads.ValueChanged += new System.EventHandler(this.numericUpDownMaxThreads_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Max Threads:";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.buttonStartStop);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Location = new System.Drawing.Point(400, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(80, 87);
            this.panelControl.TabIndex = 12;
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.BackColor = System.Drawing.Color.Gold;
            this.buttonStartStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStartStop.Location = new System.Drawing.Point(0, 0);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(80, 87);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "START";
            this.buttonStartStop.UseVisualStyleBackColor = false;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // panelPayload
            // 
            this.panelPayload.Controls.Add(this.linkLabelPayloadHelp);
            this.panelPayload.Controls.Add(this.textBoxPayload);
            this.panelPayload.Controls.Add(this.label3);
            this.panelPayload.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPayload.Location = new System.Drawing.Point(3, 3);
            this.panelPayload.Name = "panelPayload";
            this.panelPayload.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelPayload.Size = new System.Drawing.Size(466, 94);
            this.panelPayload.TabIndex = 10;
            // 
            // linkLabelPayloadHelp
            // 
            this.linkLabelPayloadHelp.AutoSize = true;
            this.linkLabelPayloadHelp.Location = new System.Drawing.Point(12, 35);
            this.linkLabelPayloadHelp.Name = "linkLabelPayloadHelp";
            this.linkLabelPayloadHelp.Size = new System.Drawing.Size(64, 13);
            this.linkLabelPayloadHelp.TabIndex = 9;
            this.linkLabelPayloadHelp.TabStop = true;
            this.linkLabelPayloadHelp.Text = "View Help...";
            this.linkLabelPayloadHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPayloadHelp_LinkClicked);
            // 
            // panelDevices
            // 
            this.panelDevices.Controls.Add(this.listBoxDevices);
            this.panelDevices.Controls.Add(this.label4);
            this.panelDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDevices.Location = new System.Drawing.Point(3, 97);
            this.panelDevices.Name = "panelDevices";
            this.panelDevices.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.panelDevices.Size = new System.Drawing.Size(466, 37);
            this.panelDevices.TabIndex = 11;
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.Location = new System.Drawing.Point(79, 10);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDevices.Size = new System.Drawing.Size(387, 22);
            this.listBoxDevices.Sorted = true;
            this.listBoxDevices.TabIndex = 4;
            // 
            // tabControlData
            // 
            this.tabControlData.Controls.Add(this.tabPage1);
            this.tabControlData.Controls.Add(this.tabPage2);
            this.tabControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlData.Location = new System.Drawing.Point(0, 87);
            this.tabControlData.Name = "tabControlData";
            this.tabControlData.SelectedIndex = 0;
            this.tabControlData.Size = new System.Drawing.Size(480, 163);
            this.tabControlData.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelDevices);
            this.tabPage1.Controls.Add(this.panelPayload);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Device Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 137);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Location = new System.Drawing.Point(3, 3);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(466, 131);
            this.textBoxResult.TabIndex = 0;
            // 
            // EmulatorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlData);
            this.Controls.Add(this.panelSettings);
            this.Name = "EmulatorPanel";
            this.Size = new System.Drawing.Size(480, 250);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxThreads)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelPayload.ResumeLayout(false);
            this.panelPayload.PerformLayout();
            this.panelDevices.ResumeLayout(false);
            this.panelDevices.PerformLayout();
            this.tabControlData.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPayload;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelPayload;
        private System.Windows.Forms.Panel panelDevices;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonStartStop;
        internal System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.LinkLabel linkLabelPayloadHelp;
        private System.Windows.Forms.TabControl tabControlData;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxThreads;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalCount;
    }
}
