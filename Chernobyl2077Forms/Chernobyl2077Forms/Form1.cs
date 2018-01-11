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
        public static bool Images;
        private void label13_Click(object sender, EventArgs e)
        {
            label13.Text = score.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox image2 = new PictureBox();
        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Images");

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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 659);
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
            this.label1.Visible = true;
            image2.Image = Image.FromFile(path + @"/" + @"berlin2.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
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
            image2.Image = Image.FromFile(path + @"/" + @"Kampala.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 333);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
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
            image2.Image = Image.FromFile(path + @"/" + @"europe.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            label1.Text = "?How many countries in Europe";
            label3.Text = "53";
            label4.Text = "a bazilion";
            label5.Text = "37";
            label6.Text = "44"; //
            checkForBuPr();
            RiAns4();
            Quiz4();
        }
        public void Quiz4()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"USA_states.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 391);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
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
            image2.Image = Image.FromFile(path + @"/" + @"Africa.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(615, 615);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
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
            image2.Image = Image.FromFile(path + @"/" + @"flagmap_estonia.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 381);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
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
            image2.Image = Image.FromFile(path + @"/" + @"Washington.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
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
            image2.Image = Image.FromFile(path + @"/" + @"London.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 411);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
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
            image2.Image = Image.FromFile(path + @"/" + @"USA.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 409);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            label1.Text = "?How many km² is US";
            //label3.Text = "9 965 000";
            //label4.Text = "9 834 000";
            //label5.Text = "10 000 000";
            //label6.Text = "9 757 000";
            label3.Text = "000 965 9";
            label4.Text = "000 834 9"; // 
            label5.Text = "000 000 10";
            label6.Text = "000 757 9";
            checkForBuPr();
            RiAns2();
            Quiz10();
        }
        public void Quiz10()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"UK.gif");
            image2.Location = new Point(850, 13);
            image2.Size = new Size(486, 587);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            label1.Text = "?How many km² is UK";
            //label3.Text = "245 500";
            //label4.Text = "342 495";
            //label5.Text = "242 495";
            //label6.Text = "3 cheeseburgers";
            label3.Text = "500 245";
            label4.Text = "495 342";
            label5.Text = "495 242"; //
            label6.Text = "a few cheeseburgers";
            checkForBuPr();
            RiAns3();
            Quiz11();
        }
        public void Quiz11()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"Africakm.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            label1.Text = "?How many km² is Africa";
            label3.Text = "Three blocks";
            label4.Text = "000 370 30"; //
            label5.Text = "000 375 30";
            label6.Text = "000 370 40";
            checkForBuPr();
            RiAns2();
            Quiz12();
        }
        public void Quiz12()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"world.png");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            label1.Text = "?How many countries are there in the world";
            label3.Text = "7";
            label4.Text = "186";
            label5.Text = "200";
            label6.Text = "195"; //
            checkForBuPr();
            RiAns4();
            Quiz13();

        }
        public void Quiz13()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"usapop.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            label1.Text = "?How many people live in the US";
            // Correct 326,766,748
            label3.Text = "748 766 326"; //
            label4.Text = "000 800 330";
            label5.Text = "?Like 5";
            label6.Text = "000 700 400";
            checkForBuPr();
            RiAns1();
            Quiz14();
        }
        public void Quiz14()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"ukpop.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            label1.Text = "?How many people live in the UK";
            // Correct 66,573,504
            label3.Text = "748 766 66"; //
            label4.Text = "000 850 69";
            label5.Text = "?Like 5";
            label6.Text = "000 570 66";
            checkForBuPr();
            RiAns1();
            Quiz15();

        }
        public void Quiz15()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"sauepop.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            this.label1.Location = new System.Drawing.Point(150, 57);
            label1.Text = "?How many people live in Saue, Harjumaa, Estonia";
            // Correct 66,573,504
            label3.Text = "6065"; //
            label4.Text = "1337";
            label5.Text = "5810";
            label6.Text = "4753";
            checkForBuPr();
            RiAns3();
            Quiz16();

        }
        public void Quiz16()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"doge-mining.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            this.label1.Location = new System.Drawing.Point(267, 46);
            label1.Text = "?How much are doge coins worth";
            // Correct 66,573,504
            label3.Text = "0,00987 eur"; //
            label4.Text = "0,00562 eur";
            label5.Text = "0,0907 eur";
            label6.Text = "one doge meme";
            checkForBuPr();
            RiAns1();
            Quiz17();

        }
        public void Quiz17()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"chinapop.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            label1.Text = "?How many people live in China";
            // Correct 1,412,648,363
            label3.Text = "000 000 412 1"; //
            label4.Text = "000 850 693 2";
            label5.Text = "?5";
            label6.Text = "000 570 430 1";
            checkForBuPr();
            RiAns1();
            Quiz18();

        }
        public void Quiz18()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"kiev.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            label1.Text = "?Which countries capital city is 'Kiev'";
            // Correct 66,573,504
            label3.Text = "Ukraine"; //
            label4.Text = "Slovenia";
            label5.Text = "Poland";
            label6.Text = "Uganda";
            checkForBuPr();
            RiAns1();
            Quiz19();

        }
        public void Quiz19()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"ljubljana.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            label1.Text = "?What is the capital of Slovenia";
            // Correct 66,573,504
            label5.Text = "Ljubljana"; //
            label4.Text = "Celje";
            label3.Text = "Bled";
            label6.Text = "?Moscow";
            checkForBuPr();
            RiAns3();
            Quiz20();

        }
        public void Quiz20()
        {
            DeBuSet();
            image2.Image = Image.FromFile(path + @"/" + @"ugandapop.jpg");
            image2.Location = new Point(775, 13);
            image2.Size = new Size(622, 500);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(image2);
            label1.Text = "?How many people live in Uganda";
            // Correct 66,573,504
            label3.Text = "a few people and Knuckles"; //
            label4.Text = "000 490 41";
            label5.Text = "000 234 56";
            label6.Text = "000 570 66";
            checkForBuPr();
            RiAns2();
            QuizEnd();            

        }
        public void QuizEnd()
        {
            image2.Image = Image.FromFile(path + @"/" + @"tenor.gif");
            image2.Location = new Point(0, 0);
            image2.Size = new Size(1417, 659);
            this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.label15.Visible = false;
            this.button7.Visible = false;
            this.button8.Visible = false;
            this.button5.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            label16.Visible = true;

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
            Score10();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Images = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 659);
        }
        private void Score10()
        {
            if (score == 10)
            {
                this.label13.ForeColor = System.Drawing.Color.Red;
                new System.Threading.ManualResetEvent(false).WaitOne(250);
                this.label13.ForeColor = System.Drawing.Color.Black;
                new System.Threading.ManualResetEvent(false).WaitOne(250);
                this.label13.ForeColor = System.Drawing.Color.Red;
                new System.Threading.ManualResetEvent(false).WaitOne(250);
                this.label13.ForeColor = System.Drawing.Color.Black;

            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Images = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 659);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.button5.Visible = false;
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.label12.Visible = true;
            this.label1.Visible = true;
            this.label13.Location = new System.Drawing.Point(704, 35);
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label12.Location = new System.Drawing.Point(646, 30);
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 659);
            Quiz20();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.button5.Visible = false;
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.label1.Visible = true;
            this.label12.Visible = true;
            this.label13.Location = new System.Drawing.Point(704, 35);
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label12.Location = new System.Drawing.Point(646, 30);
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 659);
            QuizEnd();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
            checkBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
