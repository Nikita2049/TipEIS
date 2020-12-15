using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBD
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void планСчетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ChartOfAccounts();
            form.ShowDialog();
        }

        private void водительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Driver();
            form.ShowDialog();
        }

        private void машинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Car();
            form.ShowDialog();
        }

        private void гсмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new GSM();
            form.ShowDialog();
        }

        private void маркагсмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MarkaGSM();
            form.ShowDialog();
        }

        private void журналОперацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new JournalOperation();
            form.ShowDialog();
        }

        private void журналПроводокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new JournalEntries();
            form.ShowDialog();
        }
    }
}
