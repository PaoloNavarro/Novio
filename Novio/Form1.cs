using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novio
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button3.Visible = true;
            button2.Enabled = false;
            button2.Visible = false;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button4.Visible = true;
            button3.Enabled = false;
            button3.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.Visible = true;
            button4.Enabled = false;
            button4.Visible = false;

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button6.Visible = true;
            button5.Enabled = false;
            button5.Visible = false;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button3.Visible = true;
            button6.Enabled = false;
            button6.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias nena, estaremos juntos para siempre :)","ya somos novios :)");
        }
    }
}
