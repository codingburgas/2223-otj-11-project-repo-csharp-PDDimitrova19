using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                new Form2().Show();
                this.Hide();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
