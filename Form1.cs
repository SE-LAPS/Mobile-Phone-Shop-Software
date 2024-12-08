using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             String user = Convert.ToString(textBox1.Text);
            String password = Convert.ToString(textBox2.Text);
            if (user == "imashi" && password == "0000")
            {
                Form2 mm = new Form2();
                mm.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             textBox1.Clear();
            textBox2.Clear();
        }
        }
    }

