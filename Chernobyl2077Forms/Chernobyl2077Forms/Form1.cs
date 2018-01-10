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
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Chernobyl2077Forms
{
    public partial class Form1 : Form
    {
        public void m()
        {
            label7.Visible = false;
        }
        public static bool BuIsPr;
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
            BuIsPr = true;
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
            BuIsPr = true;
            BuIsPr2 = true;
        }

        public void button5_Click_1(object sender, EventArgs e)
        {
            this.button5.Visible = false;
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            Quiz1();
           
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
        private void button3_Click(object sender, EventArgs e)
        {
            BuIsPr = true;
            BuIsPr3 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuIsPr = true;
            BuIsPr4 = true;
        }
        public void Quiz1()
        {
            label1.Text = "What is the capital of Germany?";
            label3.Text = "Hamburg";
            label4.Text = "München";
            label5.Text = "Berlin";
            label6.Text = "Frankfurt";
            checkForBuPr();
            if (BuIsPr3 == true)
            {
                BuIsPr = false;
                BuIsPr3 = false;
                this.button3.BackColor = System.Drawing.Color.LawnGreen;
            }
            if (BuIsPr1 == true)
            {
                BuIsPr = false;
                BuIsPr1 = false;
                this.button1.BackColor = System.Drawing.Color.Red;
                WrAns();

            }
            if (BuIsPr2 == true)
            {
                BuIsPr = false;
                BuIsPr2 = false;
                this.button2.BackColor = System.Drawing.Color.Red;
                WrAns();
            }
            if (BuIsPr4 == true)
            {
                BuIsPr = false;
                BuIsPr4 = false;
                this.button4.BackColor = System.Drawing.Color.Red;
                WrAns();
            }
            //DeBuSet();
            Quiz2();

        }
        public void Quiz2()
        {
            DeBuSet();
            label1.Text = "What is the capital of Uganda";
            label3.Text = "Jinja";
            label4.Text = "Kampala";
            label5.Text = "Gulu";
            label6.Text = "Lira";
            checkForBuPr();
            if (BuIsPr2 == true)
            {

                BuIsPr = false;
                BuIsPr2 = false;
                this.button2.BackColor = System.Drawing.Color.LawnGreen;
            }
            if (BuIsPr1 == true)
            {

                BuIsPr = false;
                BuIsPr1 = false;
                this.button1.BackColor = System.Drawing.Color.Red;

            }
            if (BuIsPr3 == true)
            {
                BuIsPr = false;
                BuIsPr3 = false;
                this.button3.BackColor = System.Drawing.Color.Red;

            }
            if (BuIsPr4 == true)
            {
                BuIsPr = false;
                BuIsPr4 = false;
                WrAns();

            }

        }
        public static void checkForBuPr()
        {
            while (BuIsPr == false)
            {
                Application.DoEvents();
            }
        }
        public void DeBuSet()
        {
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
        }
        public void WrAns()
        {
            this.button5.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.label1.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
            label7.Visible = true;
            while (BuIsPr == false)
            {
                Application.DoEvents();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //public void Timer1sec()
        //{
        //        System.Timers.Timer aTimer = new System.Timers.Timer();
        //        aTimer.Interval = 5000;
        //        aTimer.Enabled = true;
        //}

    }
}
