﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegForm
{

    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "hello";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = Form1.instance.district;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = Form1.instance.district;
        }
    }
}
