using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeOClock.ClockStates;


namespace TimeOClock
{
    public partial class FormDomain : Form
    {
        public FormDomain()
        {
            InitializeComponent();
        }
        ClockInStates clockState = new ClockInStates();

        private void clockInButton_Click(object sender, EventArgs e)
        {
            
            clockState.action(false);
            if(clockState.isButtonEnabled==false)
            clockInButton.Enabled = clockState.isButtonEnabled;
            
        }
        private void clockOutButton_Click(object sender, EventArgs e)
        {
            if (clockState.isButtonEnabled == false)
                clockInButton.Enabled = clockState.isButtonEnabled;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void timeDayLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void currentTimeLable_Click(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormDomain_Load(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToLongTimeString();
            currentDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void currentDateLabel_Click(object sender, EventArgs e)
        {
            currentDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void ptoDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            employmentHistoryLabel formViewDetails = new employmentHistoryLabel();
            formViewDetails.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIndex formIndex = new FormIndex();
            formIndex.ShowDialog();
        }

       
    }
}
