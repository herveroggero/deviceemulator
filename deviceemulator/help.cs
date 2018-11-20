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

namespace ui
{
    public partial class help : Form
    {
        private byte[] _data = null;
        public help()
        {
            InitializeComponent();
            _data = deviceemulator.Properties.Resources.connect_help;
        }

        public help(byte[] data)
        {
            InitializeComponent();
            _data = data;
        }

        private void help_Load(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream(_data);
            richTextBoxHelp.LoadFile(stream, RichTextBoxStreamType.RichText);
        }
    }
}
