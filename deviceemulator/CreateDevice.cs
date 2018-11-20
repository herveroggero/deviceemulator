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
    public partial class CreateDevice : Form
    {
        private EnzoIotHubOperations _enzo = null;

        public CreateDevice(EnzoIotHubOperations enzo)
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
                MessageBox.Show(this, "Please specify a unique device id before creating this device.", "Warning");
                return;
            }

            try
            {
                string deviceId = textBoxDeviceId.Text;
                string pkey = null;
                string skey = null;

                if (!string.IsNullOrEmpty(textBoxPrimary.Text)) pkey = textBoxPrimary.Text;
                if (!string.IsNullOrEmpty(textBoxSecondary.Text)) skey = textBoxSecondary.Text;

                _enzo.CreateDevice(deviceId, pkey, skey);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
            }
        }
    }
}
