﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormC newC = new FormC();
            this.Hide();
            newC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormB newB = new FormB();
            this.Hide();
            newB.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormA newA = new FormA();
            this.Hide();
            newA.Show(); 
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
