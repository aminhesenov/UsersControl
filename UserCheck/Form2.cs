using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserCheck
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isUsernameCorrect = false;
            bool isPasswordCorrect = false;
            
            for (int j = 0; j < Form1.i; j++)
            {
                if (textBox1.Text == Form1.username[j])
                {
                    isUsernameCorrect = true;
                }               
            }

            for (int j = 0; j < Form1.i; j++)
            {               
                if (textBox2.Text == Form1.password[j])
                {
                    isPasswordCorrect = true;
                }
            }

            if(textBox1.Text == "" || textBox2.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please enter username");
                errorProvider2.SetError(textBox2, "Please enter password");
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();

                if (isUsernameCorrect && isPasswordCorrect)
                {
                    richTextBox1.Text = "User found\n- Registration date: " + Form1.date[Array.IndexOf(Form1.username, textBox1.Text)];
                }
                else
                {
                    richTextBox1.Text = "User not found :(";
                    richTextBox1.ForeColor = Color.DarkRed;
                }
            }

        }
    }
}
