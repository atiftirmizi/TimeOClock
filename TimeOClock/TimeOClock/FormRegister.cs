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
    public partial class FormRegisterGroupBox : Form
    {
        public FormRegisterGroupBox()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void registerFormButton_Click(object sender, EventArgs e)
        {
            if (this.termsCheckBox.Checked)
            {
                //If all the information on the form is filled out with proper values; then allow them to continue onto the main screen.
                //Guide them to the next page if the Pin they entered is valid:
                this.Hide();
                FormDomain formDomain = new FormDomain();
                formDomain.ShowDialog();
            }            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cellphoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
        }

        private void temsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTermsAndConditions termsAndConditionsForm = new FormTermsAndConditions();
            termsAndConditionsForm.ShowDialog();
        }
    }
}
