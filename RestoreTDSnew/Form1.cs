using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoreTDSnew
{
    public partial class Form1 : Form
    {
        private readonly Lab lab = new Lab();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetButtonActivity(lab.ControlActivity);
        }

        private void SetButtonActivity(ControlActivity controlActivity)
        {
            textBoxSpik2.Enabled = controlActivity.TextBoxSpik2_Active;
            textBoxSpik4.Enabled = controlActivity.TextBoxSpik4_Active;
            textBoxSpik5.Enabled = controlActivity.TextBoxSpik5_Active;
            textBoxSpik6.Enabled = controlActivity.TextBoxSpik6_Active;
            textBoxSpik7.Enabled = controlActivity.TextBoxSpik7_Active;
            textBoxSpik8.Enabled = controlActivity.TextBoxSpik8_Active;
            radioSpik2.Enabled = controlActivity.RadioSpik2_Active;
            radioSpik4.Enabled = controlActivity.RadioSpik4_Active;
            radioSpik5.Enabled = controlActivity.RadioSpik5_Active;
            radioSpik6.Enabled = controlActivity.RadioSpik6_Active;
            radioSpik7.Enabled = controlActivity.RadioSpik7_Active;
            radioSpik8.Enabled = controlActivity.RadioSpik8_Active;
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonShrink_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do zaimplementowania");
        }


        private void radioLab1_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichLab = 1;
            label1.Text = lab.WhichLab.ToString();
            lab.SetLab1Activity();
            SetButtonActivity(lab.ControlActivity);
        }

        private void radioLab2_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichLab = 2;
            label1.Text = lab.WhichLab.ToString();
            lab.SetLab2Activity();
            SetButtonActivity(lab.ControlActivity);
        }

        private void radioLab3_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichLab = 3;
            label1.Text = lab.WhichLab.ToString();
            lab.SetLab3Activity();
            SetButtonActivity(lab.ControlActivity);
        }

        private void radioSpik2_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichServer = 2;
            label1.Text = lab.WhichServer.ToString();
            lab.SetSpik2Activity();
            SetButtonActivity(lab.ControlActivity);
        }

        private void radioSpik4_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichServer = 4;
            label1.Text = lab.WhichServer.ToString();
            lab.SetSpik4Activity();
            SetButtonActivity(lab.ControlActivity);

        }

        private void radioSpik5_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichServer = 5;
            label1.Text = lab.WhichServer.ToString();
            lab.SetSpik5Activity();
            SetButtonActivity(lab.ControlActivity);

        }
        private void radioSpik6_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichServer = 6;
            label1.Text = lab.WhichServer.ToString();
            lab.SetSpik6Activity();
            SetButtonActivity(lab.ControlActivity);
        }

        private void radioSpik7_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichServer = 7;
            label1.Text = lab.WhichServer.ToString();
            lab.SetSpik7Activity();
            SetButtonActivity(lab.ControlActivity);
        }

        private void radioSpik8_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichServer = 8;
            label1.Text = lab.WhichServer.ToString();
            lab.SetSpik8Activity();
            SetButtonActivity(lab.ControlActivity);
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do zaimplementowania");
        }


    }
}
