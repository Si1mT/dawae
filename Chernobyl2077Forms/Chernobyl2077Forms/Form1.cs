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
using System.Timers;

namespace Chernobyl2077Forms
{
    public partial class Form1 : Form
    {
        private CheckBox break1 = new CheckBox();
        private bool ButtonWasClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonWasClicked = true;
            //int counter = 0;
            //string line;

            //// Read the file and display it line by line.  
            //string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Script");
            //System.IO.StreamReader file =
            //    new System.IO.StreamReader(path + @"\" + @"test.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //    counter++;
            //    label1.Text = (line);
            //}

            //file.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "test1";
            Timer timer = new Timer(new TimerCallback(TimerCb), null, 2000, 0);
            ButtonWasClicked = false;
            richTextBox1.AppendText(Environment.NewLine + "test2");
            if (break1.Checked == true)
            {
                while (ButtonWasClicked == false)
                {
                    // this will loop until button is clicked;
                }
                ButtonWasClicked = false;
            }
            richTextBox1.AppendText(Environment.NewLine + "test3");
        }
        private void textBox1_KeyDown(object sender, KeyPressEventArgs e)
        {
        }
        public void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
