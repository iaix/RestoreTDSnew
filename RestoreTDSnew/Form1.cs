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

        private readonly Lab obiekt = new Lab();

        private void radioLab1_CheckedChanged(object sender, EventArgs e)
        {
            obiekt.WhichLab = 1;
            label1.Text = obiekt.WhichLab.ToString();
        }

        private void radioLab2_CheckedChanged(object sender, EventArgs e)
        {
            obiekt.WhichLab = 2;
            label1.Text = obiekt.WhichLab.ToString();
        }

        private void radioLab3_CheckedChanged(object sender, EventArgs e)
        {
            obiekt.WhichLab = 3;
            label1.Text = obiekt.WhichLab.ToString();
        }

        private void radioSpik2_CheckedChanged(object sender, EventArgs e)
        {
            obiekt.WhichServer = 2;
            label1.Text = obiekt.WhichServer.ToString();
        }

        private void radioSpik4_CheckedChanged(object sender, EventArgs e)
        {
            obiekt.WhichServer = 4;
            label1.Text = obiekt.WhichServer.ToString();

            obiekt.pickServer(4);
        }

        private void radioSpik5_CheckedChanged(object sender, EventArgs e)
        {
            obiekt.WhichServer = 5;
            label1.Text = obiekt.WhichServer.ToString();
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do zaimplementowania");
        }
    }
}
