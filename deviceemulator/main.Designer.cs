namespace deviceemulator
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewDevices = new System.Windows.Forms.ListView();
            this.tabControlEmulators = new System.Windows.Forms.TabControl();
            this.createDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMultipleDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewEmulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.assignDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unassignSelectedDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStartAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStopAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNewEmulator = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeleteEmulator = new System.Windows.Forms.ToolStripButton();
            this.loadEmulatorWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEmulatorWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.emulatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newToolStripMenuItem,
            this.loadEmulatorWorkspaceToolStripMenuItem,
            this.saveEmulatorWorkspaceToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "&Connect...";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDeviceToolStripMenuItem,
            this.createMultipleDevicesToolStripMenuItem,
            this.deleteSelectedDevicesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.refreshListToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // emulatorToolStripMenuItem
            // 
            this.emulatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewEmulatorToolStripMenuItem,
            this.deleteEmulatorToolStripMenuItem,
            this.toolStripMenuItem5,
            this.assignDevicesToolStripMenuItem,
            this.unassignSelectedDevicesToolStripMenuItem});
            this.emulatorToolStripMenuItem.Enabled = false;
            this.emulatorToolStripMenuItem.Name = "emulatorToolStripMenuItem";
            this.emulatorToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.emulatorToolStripMenuItem.Text = "&Emulator";
            this.emulatorToolStripMenuItem.Click += new System.EventHandler(this.emulatorToolStripMenuItem_Click);
            // 
            // listViewDevices
            // 
            this.listViewDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDevices.FullRowSelect = true;
            this.listViewDevices.HideSelection = false;
            this.listViewDevices.Location = new System.Drawing.Point(3, 3);
            this.listViewDevices.Name = "listViewDevices";
            this.listViewDevices.Size = new System.Drawing.Size(712, 397);
            this.listViewDevices.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewDevices.TabIndex = 2;
            this.listViewDevices.UseCompatibleStateImageBehavior = false;
            this.listViewDevices.View = System.Windows.Forms.View.Details;
            // 
            // tabControlEmulators
            // 
            this.tabControlEmulators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEmulators.Location = new System.Drawing.Point(3, 28);
            this.tabControlEmulators.Name = "tabControlEmulators";
            this.tabControlEmulators.SelectedIndex = 0;
            this.tabControlEmulators.Size = new System.Drawing.Size(712, 372);
            this.tabControlEmulators.TabIndex = 0;
            // 
            // createDeviceToolStripMenuItem
            // 
            this.createDeviceToolStripMenuItem.Name = "createDeviceToolStripMenuItem";
            this.createDeviceToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.createDeviceToolStripMenuItem.Text = "Create Device...";
            this.createDeviceToolStripMenuItem.Click += new System.EventHandler(this.createDeviceToolStripMenuItem_Click);
            // 
            // createMultipleDevicesToolStripMenuItem
            // 
            this.createMultipleDevicesToolStripMenuItem.Name = "createMultipleDevicesToolStripMenuItem";
            this.createMultipleDevicesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.createMultipleDevicesToolStripMenuItem.Text = "Create Multiple Devices...";
            this.createMultipleDevicesToolStripMenuItem.Click += new System.EventHandler(this.createMultipleDevicesToolStripMenuItem_Click);
            // 
            // deleteSelectedDevicesToolStripMenuItem
            // 
            this.deleteSelectedDevicesToolStripMenuItem.Name = "deleteSelectedDevicesToolStripMenuItem";
            this.deleteSelectedDevicesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deleteSelectedDevicesToolStripMenuItem.Text = "Delete Selected Devices";
            this.deleteSelectedDevicesToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedDevicesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(204, 6);
            // 
            // refreshListToolStripMenuItem
            // 
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.refreshListToolStripMenuItem.Text = "Refresh List";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.refreshListToolStripMenuItem_Click);
            // 
            // createNewEmulatorToolStripMenuItem
            // 
            this.createNewEmulatorToolStripMenuItem.Name = "createNewEmulatorToolStripMenuItem";
            this.createNewEmulatorToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.createNewEmulatorToolStripMenuItem.Text = "Create New Emulator...";
            this.createNewEmulatorToolStripMenuItem.Click += new System.EventHandler(this.createNewEmulatorToolStripMenuItem_Click);
            // 
            // deleteEmulatorToolStripMenuItem
            // 
            this.deleteEmulatorToolStripMenuItem.Name = "deleteEmulatorToolStripMenuItem";
            this.deleteEmulatorToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.deleteEmulatorToolStripMenuItem.Text = "Delete Emulator";
            this.deleteEmulatorToolStripMenuItem.Click += new System.EventHandler(this.deleteEmulatorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(209, 6);
            // 
            // assignDevicesToolStripMenuItem
            // 
            this.assignDevicesToolStripMenuItem.Name = "assignDevicesToolStripMenuItem";
            this.assignDevicesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.assignDevicesToolStripMenuItem.Text = "Assign Devices...";
            this.assignDevicesToolStripMenuItem.Click += new System.EventHandler(this.assignDevicesToolStripMenuItem_Click);
            // 
            // unassignSelectedDevicesToolStripMenuItem
            // 
            this.unassignSelectedDevicesToolStripMenuItem.Name = "unassignSelectedDevicesToolStripMenuItem";
            this.unassignSelectedDevicesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.unassignSelectedDevicesToolStripMenuItem.Text = "Unassign Selected Devices";
            this.unassignSelectedDevicesToolStripMenuItem.Click += new System.EventHandler(this.unassignSelectedDevicesToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(726, 429);
            this.tabControlMain.TabIndex = 4;
            this.tabControlMain.Click += new System.EventHandler(this.tabControlMain_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewDevices);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IoT Devices";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControlEmulators);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(718, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Emulators";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewEmulator,
            this.toolStripButtonDeleteEmulator,
            this.toolStripSeparator1,
            this.toolStripButtonStartAll,
            this.toolStripButtonStopAll});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStartAll
            // 
            this.toolStripButtonStartAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStartAll.Image")));
            this.toolStripButtonStartAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStartAll.Name = "toolStripButtonStartAll";
            this.toolStripButtonStartAll.Size = new System.Drawing.Size(130, 22);
            this.toolStripButtonStartAll.Text = "Start ALL Emulators";
            this.toolStripButtonStartAll.Click += new System.EventHandler(this.toolStripButtonStartAll_Click);
            // 
            // toolStripButtonStopAll
            // 
            this.toolStripButtonStopAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStopAll.Image")));
            this.toolStripButtonStopAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStopAll.Name = "toolStripButtonStopAll";
            this.toolStripButtonStopAll.Size = new System.Drawing.Size(130, 22);
            this.toolStripButtonStopAll.Text = "Stop ALL Emulators";
            this.toolStripButtonStopAll.Click += new System.EventHandler(this.toolStripButtonStopAll_Click);
            // 
            // toolStripButtonNewEmulator
            // 
            this.toolStripButtonNewEmulator.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewEmulator.Image")));
            this.toolStripButtonNewEmulator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewEmulator.Name = "toolStripButtonNewEmulator";
            this.toolStripButtonNewEmulator.Size = new System.Drawing.Size(102, 22);
            this.toolStripButtonNewEmulator.Text = "New Emulator";
            this.toolStripButtonNewEmulator.Click += new System.EventHandler(this.toolStripButtonNewEmulator_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDeleteEmulator
            // 
            this.toolStripButtonDeleteEmulator.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteEmulator.Image")));
            this.toolStripButtonDeleteEmulator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteEmulator.Name = "toolStripButtonDeleteEmulator";
            this.toolStripButtonDeleteEmulator.Size = new System.Drawing.Size(111, 22);
            this.toolStripButtonDeleteEmulator.Text = "Delete Emulator";
            this.toolStripButtonDeleteEmulator.Click += new System.EventHandler(this.toolStripButtonDeleteEmulator_Click);
            // 
            // loadEmulatorWorkspaceToolStripMenuItem
            // 
            this.loadEmulatorWorkspaceToolStripMenuItem.Enabled = false;
            this.loadEmulatorWorkspaceToolStripMenuItem.Name = "loadEmulatorWorkspaceToolStripMenuItem";
            this.loadEmulatorWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadEmulatorWorkspaceToolStripMenuItem.Text = "Load...";
            this.loadEmulatorWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.loadEmulatorWorkspaceToolStripMenuItem_Click);
            // 
            // saveEmulatorWorkspaceToolStripMenuItem
            // 
            this.saveEmulatorWorkspaceToolStripMenuItem.Enabled = false;
            this.saveEmulatorWorkspaceToolStripMenuItem.Name = "saveEmulatorWorkspaceToolStripMenuItem";
            this.saveEmulatorWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveEmulatorWorkspaceToolStripMenuItem.Text = "Save";
            this.saveEmulatorWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.saveEmulatorWorkspaceToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "emw";
            this.saveFileDialog.Filter = "Emulator Workspace|*.emw|All Files|*.*";
            this.saveFileDialog.Title = "Save Emulator Workspace";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "emw";
            this.openFileDialog.Filter = "Emulator Workspace|*.emw|All Files|*.*";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 453);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enzo Device Emulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emulatorToolStripMenuItem;
        private System.Windows.Forms.ListView listViewDevices;
        private System.Windows.Forms.TabControl tabControlEmulators;
        private System.Windows.Forms.ToolStripMenuItem createDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMultipleDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewEmulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem assignDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unassignSelectedDevicesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStartAll;
        private System.Windows.Forms.ToolStripButton toolStripButtonStopAll;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewEmulator;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteEmulator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadEmulatorWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveEmulatorWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

