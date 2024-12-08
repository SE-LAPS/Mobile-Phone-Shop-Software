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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 F3 = new Form3();
            F3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
        }
    }



