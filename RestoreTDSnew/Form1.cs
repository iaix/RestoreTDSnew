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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonShrink_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do zaimplementowania");
        }

        private readonly Lab lab = new Lab();

        private void radioLab1_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichLab = 1;
            label1.Text = lab.WhichLab.ToString();
        }

        private void radioLab2_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichLab = 2;
            label1.Text = lab.WhichLab.ToString();
        }

        private void radioLab3_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichLab = 3;
            label1.Text = lab.WhichLab.ToString();
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
            lab.pickServer();
        }

        private void radioSpik5_CheckedChanged(object sender, EventArgs e)
        {
            lab.WhichServer = 5;
            label1.Text = lab.WhichServer.ToString();
        }

        private void SetButtonActivity(ControlActivity controlActivity)
        {
            textBoxSpik2.Enabled = controlActivity.TextBoxSpik2_Active;
            textBoxSpik4.Enabled = controlActivity.TextBoxSpik4_Active;
            textBoxSpik5.Enabled = controlActivity.TextBoxSpik5_Active;
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do zaimplementowania");
        }
    }
}
