using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Chernobyl2077Forms
{
    public partial class Form1 : Form
    {
        public static bool BuIsPr1;
        public static bool BuIsPr2;
        public static bool BuIsPr3;
        public static bool BuIsPr4;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuIsPr1 = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuIsPr2 = true;
        }

        public void button5_Click_1(object sender, EventArgs e)
        {
            this.button5.Visible = false;
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            Quiz();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void Quiz()
        {
            label1.Text = "What is the capital of Germany?";
            label3.Text = "Hamburg";
            label4.Text = "München";
            label5.Text = "Berlin";
            label6.Text = "Frankfurt";
            if (BuIsPr3 == true)
            {
                BuIsPr3 = false;
                this.button1.BackColor = System.Drawing.Color.LawnGreen;
            }
            if (BuIsPr1 == true)
            {
                BuIsPr1 = false;
                this.button1.BackColor = System.Drawing.Color.Red;
            }
            if (BuIsPr2 == true)
            {
                BuIsPr2 = false;
                this.button2.BackColor = System.Drawing.Color.Red;
            }
            if (BuIsPr4 == true)
            {
                BuIsPr4 = false;
                this.button1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuIsPr3 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuIsPr4 = true;
        }
    }
}
