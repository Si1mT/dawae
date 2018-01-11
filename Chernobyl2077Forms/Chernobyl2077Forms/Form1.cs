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
            label1.Visible = false;
            label7.Visible = false;
        }
        public static int score;
        public static bool BuIsPr;
        public static bool BuIsPr1;
        public static bool BuIsPr2;
        public static bool BuIsPr3;
        public static bool BuIsPr4;
        private void label13_Click(object sender, EventArgs e)
        {
            label13.Text = score.ToString();
        }
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
            this.label12.Visible = true;
            this.label13.Location = new System.Drawing.Point(704, 35);
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label12.Location = new System.Drawing.Point(646, 30);
            this.label12.Size = new System.Drawing.Size(61, 20);
            Quiz1();
           
        }

        public void image()
        {
            string path = 
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
            this.label1.Visible = true;
            label1.Text = "What is the capital of Germany";
            label3.Text = "Hamburg";
            label4.Text = "München";
            label5.Text = "Berlin";
            label6.Text = "Frankfurt";
            checkForBuPr();
            RiAns3();
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
            RiAns2();
            Quiz3();
        }
        public void Quiz3()
        {
            DeBuSet();
            label1.Text = "How many countries in Europe";
            label3.Text = "53";
            label4.Text = "a bazilion";
            label5.Text = "37";
            label6.Text = "44";
            checkForBuPr();
            RiAns4();
            Quiz4();
        }
        public void Quiz4()
        {
            DeBuSet();
            label1.Text = "How many states in USA";
            label3.Text = "50";
            label4.Text = "about a million";
            label5.Text = "1";
            label6.Text = "16";
            checkForBuPr();
            RiAns1();
            Quiz5();
        }
        public void Quiz5()
        {
            DeBuSet();
            label1.Text = "How many countries in Africa";
            label3.Text = "53";
            label4.Text = "a few";
            label5.Text = "54";
            label6.Text = "45";
            checkForBuPr();
            RiAns3();
            Quiz6();
        }
        public void Quiz6()
        {
            DeBuSet();
            label1.Text = "How many counties in Estonia";
            label3.Text = "13";
            label4.Text = "15";
            label5.Text = "16";
            label6.Text = "19";
            checkForBuPr();
            RiAns2();
            Quiz7();
        }
        public void Quiz7()
        {
            DeBuSet();
            label1.Text = "What is the capital city of USA";
            label3.Text = "Washington";
            label4.Text = "New York";
            label5.Text = "Boston";
            label6.Text = "London";
            checkForBuPr();
            RiAns1();
            Quiz8();
        }
        public void Quiz8()
        {
            DeBuSet();
            label1.Text = "What is the capital city of UK";
            label3.Text = "Washing a ton";
            label4.Text = "Glasgow";
            label5.Text = "Boston";
            label6.Text = "London";
            checkForBuPr();
            RiAns4();
            Quiz9();
        }
        public void Quiz9()
        {
            DeBuSet();
            label1.Text = "How many km² is US?";
            label3.Text = "9 965 000";
            label4.Text = "9 834 000";
            label5.Text = "10 000 000";
            label6.Text = "9 757 000";
            checkForBuPr();
            RiAns2();
            Quiz10();

        }
        public void Quiz10()
        {
            DeBuSet();
            label1.Text = "How many km² is UK?";
            label3.Text = "245 500";
            label4.Text = "342 495";
            label5.Text = "242 495";
            label6.Text = "3 cheeseburgers";
            checkForBuPr();
            RiAns3();
            //Quiz11();

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
            label13.Text = score.ToString();
            new System.Threading.ManualResetEvent(false).WaitOne(1000);
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
        }
        public void DeBuSetNoSlow()
        {
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
        }
        public void WrAns()
        {
            new System.Threading.ManualResetEvent(false).WaitOne(500);
            this.button5.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.button6.Visible = true;
            this.label1.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
            label7.Visible = true;
            this.label13.Location = new System.Drawing.Point(384, 209);
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label12.Location = new System.Drawing.Point(327, 204);
            this.label12.Size = new System.Drawing.Size(61, 20);
            while (BuIsPr == false)
            {
                Application.DoEvents();
            }
            BuIsPr = false;
            score = 0;
            label13.Text = "";
            this.label13.Location = new System.Drawing.Point(704, 35);
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label12.Location = new System.Drawing.Point(646, 30);
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.button5.Visible = false;
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.label1.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;
            label7.Visible = false;
            DeBuSetNoSlow();
            Quiz1();
        }
        public void RiAns1()
        {
            if (BuIsPr1 == true)
            {

                BuIsPr = false;
                BuIsPr1 = false;
                this.button1.BackColor = System.Drawing.Color.LawnGreen;
                score++;
            }
            if (BuIsPr2 == true)
            {

                BuIsPr = false;
                BuIsPr2 = false;
                this.button2.BackColor = System.Drawing.Color.Red;
                WrAns();

            }
            if (BuIsPr3 == true)
            {
                BuIsPr = false;
                BuIsPr3 = false;
                this.button3.BackColor = System.Drawing.Color.Red;
                WrAns();

            }
            if (BuIsPr4 == true)
            {
                BuIsPr = false;
                BuIsPr4 = false;
                this.button4.BackColor = System.Drawing.Color.Red;
                WrAns();
            }
        }
        public void RiAns2()
        {
            if (BuIsPr2 == true)
            {

                BuIsPr = false;
                BuIsPr2 = false;
                this.button2.BackColor = System.Drawing.Color.LawnGreen;
                score++;
            }
            if (BuIsPr1 == true)
            {

                BuIsPr = false;
                BuIsPr1 = false;
                this.button1.BackColor = System.Drawing.Color.Red;
                WrAns();

            }
            if (BuIsPr3 == true)
            {
                BuIsPr = false;
                BuIsPr3 = false;
                this.button3.BackColor = System.Drawing.Color.Red;
                WrAns();

            }
            if (BuIsPr4 == true)
            {
                BuIsPr = false;
                BuIsPr4 = false;
                this.button4.BackColor = System.Drawing.Color.Red;
                WrAns();
            }
        }
        public void RiAns3()
        {
            if (BuIsPr3 == true)
            {

                BuIsPr = false;
                BuIsPr3 = false;
                this.button3.BackColor = System.Drawing.Color.LawnGreen;
                score++;
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
        }
        public void RiAns4()
        {
            if (BuIsPr4 == true)
            {

                BuIsPr = false;
                BuIsPr4 = false;
                this.button4.BackColor = System.Drawing.Color.LawnGreen;
                score++;
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
            if (BuIsPr3 == true)
            {
                BuIsPr = false;
                BuIsPr3 = false;
                this.button3.BackColor = System.Drawing.Color.Red;
                WrAns();

            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BuIsPr = true;
            this.button6.Visible = false;
        }
        //public void Timer1sec()
        //{
        //        System.Timers.Timer aTimer = new System.Timers.Timer();
        //        aTimer.Interval = 5000;
        //        aTimer.Enabled = true;
        //}

    }
}
