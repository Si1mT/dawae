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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Script");
            System.IO.StreamReader file =
                new System.IO.StreamReader(path + @"\" + @"test.txt");
            string lines1 = file.ReadLine();
            string[] splitlines = lines1.Split(new Char[] { '#' });
            //while ((line = file.ReadLine()) != null)
            {
                //liness.Add(line);
                //counter++;
                //label1.Text = (line);
            }
            label1.Text = (splitlines[0]);

            int n = 1;
            //while (n==1)
            {
                counter++;

            }
            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
