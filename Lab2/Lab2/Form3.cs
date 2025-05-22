using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PerformOperation('+');
        }

        private void substractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformOperation('-');
        }

        private void multiplyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PerformOperation('*');
        }

        private void divideToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PerformOperation('/');
        }
    }
}
