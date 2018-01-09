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
            while ((line = file.ReadLine()) != null)
            {
                counter++;
                label1.Text = (line);
            }

            file.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
