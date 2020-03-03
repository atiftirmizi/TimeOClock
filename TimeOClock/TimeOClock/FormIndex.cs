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
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MessageBox.Show("Please enter your information");
            FormRegisterGroupBox formRegister = new FormRegisterGroupBox();
            formRegister.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            //Guide them to the next page if the Pin they entered is valid:
            this.Hide();
            FormDomain formDomain = new FormDomain();
            formDomain.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormForgotPin forgotPinForm = new FormForgotPin();
            forgotPinForm.ShowDialog();
        }
    }
}
