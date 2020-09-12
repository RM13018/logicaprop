using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logicaprop
{
    public partial class Form1 : Form
    {
        bool p, q, r, s;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && textBox1.Text != "") 
            {
                p = false;
                MessageBox.Show(p.ToString(), textBox1.Text);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && textBox2.Text != "")
            {
                q = true;
                MessageBox.Show(q.ToString(), textBox2.Text);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && textBox2.Text != "")
            {
                q = false;
                MessageBox.Show(q.ToString(), textBox2.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Error de logica vacio", "error");
            }
            else if (textBox5.Text.Contains("Y")) 
            {
                if (textBox5.Text.Contains(textBox1.Text) && textBox5.Text.Contains(textBox2.Text)) 
                {
                    if (p = false && p.Equals(q)) { MessageBox.Show("falso", "valor de sentencia simple"); }
                    else if (p = true && p.Equals(q)) { MessageBox.Show("verdadero", "valor de sentencia simple"); }
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pt = textBox1.Text;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && textBox1.Text != "") 
            {
                p = true;
                MessageBox.Show(p.ToString(), textBox1.Text);
            }
        }
    }
}
