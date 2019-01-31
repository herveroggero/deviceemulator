using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deviceemulator
{
    public partial class main : Form
    {
        #region Private properties
        /// <summary>
        /// Current Enzo connection settings
        /// </summary>
        private byte[] _connectionBytes = null;

        private List<Emulator> _emulators = new List<Emulator>();
        private bool _workspaceLoaded = false;
        private string _workspaceFile = null;

        #endregion

        public main()
        {
            InitializeComponent();
        }

        #region Properties
        public EnzoHttpAzureIoTHub EnzoIoTHub
        {
            get
            {
                if (_connectionBytes == null)
                    return null;

                return EnzoHttpAzureIoTHub.Deserialize(_connectionBytes);

            }
        }

        public EnzoIotHubOperations EnzoIotHubOperations { get { return new EnzoIotHubOperations(EnzoIoTHub); } }

        public Emulator CurrentEmulator
        {
            get
            {
                if (tabControlEmulators.TabPages.Count == 0)
                {
                    return null;
                }
                Guid id = (Guid)(tabControlEmulators.SelectedTab.Tag);
                var emulator = _emulators.FirstOrDefault(p => p.EmulatorId == id);
                return emulator;
            }
        }
        
        #endregion

        #region Methods

        private void RefreshUI()
        {
            try
            {
                // Load current list of devices - this UI supports up to 100 devices
                var data = EnzoIotHubOperations.ListDevices();
                listViewDevices.Fill(data);
            }
            catch 
            {
            }
        }

        private void RefreshMenu()
        {
            editToolStripMenuItem.Enabled = tabControlMain.SelectedIndex == 0;
            emulatorToolStripMenuItem.Enabled = tabControlMain.SelectedIndex == 1;
            deleteSelectedDevicesToolStripMenuItem.Enabled = listViewDevices.SelectedItems.Count > 0;

            saveEmulatorWorkspaceToolStripMenuItem.Enabled = (_connectionBytes != null) && (_emulators.Count > 0 || _workspaceLoaded);
            saveAsToolStripMenuItem.Enabled = _workspaceFile != null;
            loadEmulatorWorkspaceToolStripMenuItem.Enabled = _connectionBytes != null;
            newToolStripMenuItem.Enabled = _connectionBytes != null;

        }
        
        private void NewEmulator()
        {
            try
            {
                var form = new CreateEmulator(listViewDevices.Items);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    
                    Emulator emulator = new Emulator(EnzoIoTHub, null);
                    emulator.Name = form.EmulatorName;

                    TabPage page = new TabPage();
                    EmulatorPanel panel = new EmulatorPanel(emulator);
                    panel.Dock = DockStyle.Fill;
                    page.Controls.Add(panel);
                    page.Text = form.EmulatorName;
                    page.Tag = emulator.EmulatorId;

                    foreach (string deviceId in form.SelectedDevices)
                    {
                        panel.AddDevice(deviceId);
                    }

                    tabControlEmulators.TabPages.Add(page);
                    tabControlEmulators.SelectedIndex = tabControlEmulators.TabPages.Count - 1;

                    _emulators.Add(emulator);
                }
            }
            catch { }
        }
        
        private void DeleteEmulator()
        {
            try
            {
                bool exit = false;
                var emulator = CurrentEmulator;

                if (emulator == null)
                {
                    MessageBox.Show(this, "There are no emulators to delete.", "Error");
                    exit = true;
                }
                else if (emulator.IsRunning)
                {
                    MessageBox.Show(this, "Cannot delete an emulator that is currently running.", "Error");
                    exit = true;
                }
                else if (MessageBox.Show(this, "You are about to delete emulator: " + tabControlEmulators.SelectedTab.Text, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    exit = true;
                }


                if (exit) return;

                tabControlEmulators.TabPages.Remove(tabControlEmulators.SelectedTab);
                _emulators.Remove(emulator);

            }
            catch { }
        }

        #endregion

        #region Menu & Toolbar Events

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new ui.connect();
                var res = form.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    _connectionBytes = form.ConnectionInfo;

                    RefreshUI();
                    RefreshMenu();
                    
                    // Change enzo connection settings on all emulators
                    foreach (TabPage page in tabControlEmulators.TabPages)
                    {
                        var emulatorPanel = (EmulatorPanel)page.Controls[0];
                        emulatorPanel.Emulator.EnzoIoTHub = EnzoIoTHub;
                    }
                }
            }
            catch { }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ui.about();
            form.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new CreateDevice(EnzoIotHubOperations);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    RefreshUI();
                }
            }
            catch { }
        }

        private void createMultipleDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new CreateMultipleDevices(EnzoIotHubOperations);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    RefreshUI();
                }
            }
            catch { }
        }

        private void deleteSelectedDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Delete the selected devices from the IoT Hub? WARNING: This will delete devices from the Hub directly.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    var selected = listViewDevices.SelectedItems;
                    for (int i = selected.Count; i > 0; i--)
                    {
                        EnzoIotHubOperations.DeleteDevice(selected[i - 1].Text);
                        listViewDevices.Items.Remove(selected[i - 1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshUI();
            }
            catch { }
        }

        private void createNewEmulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEmulator();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshMenu();
                
            }
            catch { }
        }

        private void emulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshMenu();

            }
            catch { }
        }
        
        private void deleteEmulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEmulator();
        }

        private void assignDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentEmulator != null)
                {
                    var form = new CreateEmulator(listViewDevices.Items, CurrentEmulator.Name);
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        var panel = (EmulatorPanel)tabControlEmulators.SelectedTab.Controls[0];
                        panel.ClearDevices();
                        foreach (string deviceId in form.SelectedDevices)
                        {
                            panel.AddDevice(deviceId);
                        }
                    }
                }
            }
            catch { }
        }

        private void unassignSelectedDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentEmulator != null)
                {
                    var panel = (EmulatorPanel)tabControlEmulators.SelectedTab.Controls[0];
                    
                    if (panel.SelectedDevicesCount > 0)
                    {
                        if (MessageBox.Show(this, "Remove the selected devices from this emulator?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            panel.RemoveSelectedDevices();
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "No devices are selected. To remove assigned devices, you must select them from the emulator device list.", "Information");
                    }
                }
            }
            catch { }
        }

        private void tabControlMain_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshMenu();

            }
            catch { }
        }

        private void toolStripButtonStartAll_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                foreach (TabPage page in tabControlEmulators.TabPages)
                {
                    var emulatorPanel = (EmulatorPanel)page.Controls[0];
                    if (emulatorPanel.CanStart)
                    {
                        emulatorPanel.Emulator.EnzoIoTHub = EnzoIoTHub;
                        emulatorPanel.Start();
                    }
                }
            }
            catch { }
            Cursor = Cursors.Default;
        }

        private void toolStripButtonStopAll_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                foreach (TabPage page in tabControlEmulators.TabPages)
                {
                    var emulatorPanel = (EmulatorPanel)page.Controls[0];
                    if (emulatorPanel.CanStop)
                    {
                        emulatorPanel.Stop();
                    }
                }
            }
            catch { }
            Cursor = Cursors.Default;
        }

        private void toolStripButtonNewEmulator_Click(object sender, EventArgs e)
        {
            NewEmulator();
        }

        private void toolStripButtonDeleteEmulator_Click(object sender, EventArgs e)
        {
            DeleteEmulator();
        }

        private void saveEmulatorWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_workspaceFile == null)
                {
                    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        _workspaceLoaded = true;
                        _workspaceFile = saveFileDialog.FileName;
                    }
                }

                if (_workspaceFile != null)
                {
                    string data = _emulators.Serialize();
                    File.WriteAllText(_workspaceFile, data);
                }
            }
            catch { }
        }

        private void loadEmulatorWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string data = File.ReadAllText(openFileDialog.FileName);
                    _emulators = _emulators.Load(data);

                    // Reload all pages now...
                    tabControlEmulators.TabPages.Clear();

                    foreach (var emulator in _emulators)
                    {
                        emulator.EnzoIoTHub = EnzoIoTHub;
                        TabPage page = new TabPage();
                        EmulatorPanel panel = new EmulatorPanel(emulator);
                        panel.Dock = DockStyle.Fill;
                        page.Controls.Add(panel);
                        page.Text = emulator.Name;
                        page.Tag = emulator.EmulatorId;
                        tabControlEmulators.TabPages.Add(page);
                    }

                    _workspaceFile = openFileDialog.FileName;
                    _workspaceLoaded = true;
                }
            }
            catch { }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string data = _emulators.Serialize();
                    _workspaceLoaded = true;
                    _workspaceFile = saveFileDialog.FileName;
                    File.WriteAllText(_workspaceFile, data);
                    
                }
                
            }
            catch { }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlEmulators.TabPages.Clear();
            _workspaceFile = null;
            _workspaceLoaded = false;
        }

        #endregion

    }
}
