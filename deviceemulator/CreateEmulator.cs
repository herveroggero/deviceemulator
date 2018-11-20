using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deviceemulator
{
    public partial class CreateEmulator : Form
    {
        public CreateEmulator(ListView.ListViewItemCollection items, string emulatorName = null)
        {
            InitializeComponent();

            foreach (ListViewItem item in items)
                listBoxDevices.Items.Add(item.Text);

            if (!string.IsNullOrEmpty(emulatorName))
            {
                labelDescription.Text = "Edit the list of devices assigned to this emulator below.";
                textBoxEmulator.Text = emulatorName;
                textBoxEmulator.Enabled = false;
            }

        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxEmulator.Text.Trim().Length > 0)
            {
                EmulatorName = textBoxEmulator.Text;
                SelectedDevices = new List<string>();
                
                foreach (string item in listBoxDevices.SelectedItems)
                {
                    SelectedDevices.Add(item);
                }

                DialogResult = DialogResult.OK;
                Close();

            }
            else
            {
                MessageBox.Show(this, "Please enter a name for this emulator", "Error");
            }
        }

        public string EmulatorName { get; set; }

        public List<string> SelectedDevices { get; set; }

    }
}
