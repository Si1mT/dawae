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

        public Array splitlines2()
        {
            //Read the file and display it line by line.  
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Script");
            System.IO.StreamReader file = new System.IO.StreamReader(path + @"\" + @"test.txt");
            string lines1 = file.ReadToEnd();
            string[] splitlines = lines1.Split(new Char[] { '#' });
            file.Close();
            return splitlines;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("dab");
            string path=Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Script");
            PictureBox image = new PictureBox();
            image.Image = Image.FromFile(path + @"\" + @"image.jpg");
            image.Location = new Point(100, 100);
            image.Size = new Size(500, 500);
            this.Controls.Add(image);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string number in splitlines2())
            {
                label1.Text += number;
                label2.Text += number;
            }
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Script");
            PictureBox image = new PictureBox();
            image.Image = Image.FromFile(path + @"\" + @"image.jpg");
            image.Location = new Point(100, 100);
            image.Size = new Size(500, 500);
            this.Controls.Add(image);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
