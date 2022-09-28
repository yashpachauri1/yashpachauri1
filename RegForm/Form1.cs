using System;
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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public String Sname;
        public string Fname;
        public String Mname;
        public string caste;
        public String district;
        public string state;
        public string Passing_year;
        public string Passing_bord;
        public string gender;
        public string date;

        public Form1()
        {
            InitializeComponent();
            instance = this;
            district = comboBoxDistic.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            year();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            caste = comboBox2.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Sname = textBox_student.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = comboBox4.Text;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Passing_year = comboBox5.Text;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Passing_bord = comboBox6.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDistic_SelectedIndexChanged(object sender, EventArgs e)
        {
            district = comboBoxDistic.Text;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Fname = textBoxF_name.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Mname = textBoxM_name.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            date = textBoxDate.Text;
        }
        void year()
        {
            for (int i = 2000; i <= 2022; i++)
            {
                comboBox5.Items.Add(i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            state = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
