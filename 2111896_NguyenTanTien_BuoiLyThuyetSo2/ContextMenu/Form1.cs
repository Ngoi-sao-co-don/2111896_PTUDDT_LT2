using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = this.listBox1.SelectedIndex;
            this.listBox1.Items.RemoveAt(i+1);
        }
    }
}
