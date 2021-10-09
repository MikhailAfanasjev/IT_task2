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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("test.txt"))
            {
                path = "test.txt";
                textBox4.Text = path;
            }
            else
            {
                path = "";
                textBox4.Text = "Файл не найден";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path);
            textBox3.Text = sr.ReadToEnd();
        }

        private void mySplit(string rs)
        {
            listBox1.Items.Clear();
            String[] res = rs.Split('.');
                foreach (var r in res)
                    listBox1.Items.Add(r.Trim());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            mySplit(textBox3.Text);
        }
        string src = "", nstr = "", ostr = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ostr = textBox1.Text;
            nstr = textBox2.Text;
            src = textBox3.Text;
            src = src.Replace(ostr, nstr);
            mySplit(src);
        }
    }
}
