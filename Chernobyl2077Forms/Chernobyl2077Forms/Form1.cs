﻿using System;
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
            Quiz2();
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

        //public void Loading()
        //{
        //    string path= Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Script");
        //    PictureBox load = new PictureBox();
        //    load.Image = Image.FromFile(path + @"/" + @"giphyy.gif");
        //    load.Location = new Point(100, 100);
        //    load.Size = new Size(300, 300);
        //    Controls.Add(load);

        //    //string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Script");
        //    //PictureBox image = new PictureBox();
        //    //image.Image = Image.FromFile(path + @"\" + @"image.jpg");
        //    //image.Location = new Point(100, 100);
        //    //image.Size = new Size(500, 500);
        //    //this.Controls.Add(image);
        //}
        public void Quiz2()
        {
            label1.Text = "What is the capital of Germany?";
            pictureBox1.Visible = true;
            Quiz3();
        }
        public void Quiz3()
        {
            new System.Threading.ManualResetEvent(false).WaitOne(3000);
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            Quiz();
        }
        public void Quiz()
        {

            label3.Text = "Hamburg";
            label4.Text = "München";
            label5.Text = "Berlin";
            label6.Text = "Frankfurt";
            pictureBox1.Visible = false;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
            private void StartAsyncTimedWork()
        {
            myTimer.Interval = 5000;
            myTimer.Tick += new EventHandler(myTimer_Tick);
            myTimer.Start(); 
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                /* Not on UI thread, reenter there... */
                this.BeginInvoke(new EventHandler(myTimer_Tick), sender, e);
            }
            else
            {
                lock (myTimer)
                {
                    /* only work when this is no reentry while we are already working */
                    if (this.myTimer.Enabled)
                    {
                        this.myTimer.Stop();
                        this.doMyDelayedWork();
                        this.myTimer.Start(); /* optionally restart for periodic work */
                    }
                }
            }
        }
        private async Task delayedWork()
        {
            await Task.Delay(5000);
            this.doMyDelayedWork();
        }
        private void StartAsyncTimedWork()
        {
            Task ignoredAwaitableResult = this.delayedWork();
        }
    }
}
