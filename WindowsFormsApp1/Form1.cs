using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        private int counter;

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            counter = 0;
            label2.Text = counter.ToString();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            counter += 1;
            label2.Text = "Clicks: " + counter.ToString();

            if (counter == 100)
            {
                label1.Text = "Milestone: 100 Clicks!";
            }

            if (counter == 200)
            {
                label1.Text = "Milestone: 200 Clicks!";
            }

            if (counter == 500)
            {
                label1.Text = "Milestone: 500 Clicks!";
            }

            if (counter == 1000)
            {
                label1.Text = "Milestone: 1000 Clicks!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
