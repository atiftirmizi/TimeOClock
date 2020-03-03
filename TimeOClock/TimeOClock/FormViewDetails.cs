using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeOClock
{
    public partial class employmentHistoryLabel : Form
    {
        public employmentHistoryLabel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDomain formDomain = new FormDomain();
            formDomain.ShowDialog();
        }
    }
}
