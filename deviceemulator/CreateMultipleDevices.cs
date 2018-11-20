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
    public partial class CreateMultipleDevices : Form
    {
        private EnzoIotHubOperations _enzo = null;

        public CreateMultipleDevices(EnzoIotHubOperations enzo)
        {
            InitializeComponent();
            _enzo = enzo;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxDeviceId.Text.Trim().Length == 0)
            {
                MessageBox.Show(this, "Please specify a device pattern before creating devices.", "Warning");
                return;
            }

            if (numericUpDownTo.Value <= numericUpDownFrom.Value)
            {
                MessageBox.Show(this, "The To value must be greater than the From value.", "Warning");
                return;
            }

            if (numericUpDownTo.Value - numericUpDownFrom.Value > 100)
            {
                MessageBox.Show(this, "The range specified cannot exceed 100 devices.", "Warning");
                return;
            }

            try
            {
                string deviceId = textBoxDeviceId.Text;
                string from = Convert.ToInt32(numericUpDownFrom.Value).ToString(); ;
                string to = Convert.ToInt32(numericUpDownTo.Value).ToString(); ;
                string range = from + "-" + to;

                Cursor = Cursors.WaitCursor;
                _enzo.CreateDevices(deviceId, range);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
            }
            Cursor = Cursors.Default;
        }
    }
}
