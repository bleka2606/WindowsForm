using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            if (this.textBox1.Text.Trim().Length <= 0 || this.textBox2.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Поле пусте", "ПОМИЛКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            double result = num1 + num2;
            label1.Text = "Відповіть: " + result.ToString();
        }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (this.textBox1.Text.Trim().Length <= 0 || this.textBox2.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Поле пусте", "ПОМИЛКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);

                double result = num1 - num2;
                label1.Text = "Відповіть: " + result.ToString();
            }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {
                if (this.textBox1.Text.Trim().Length <= 0 || this.textBox2.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Поле пусте", "ПОМИЛКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);

                double result = num1 * num2;
                label1.Text = "Відповіть: " + result.ToString();
                }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox1.Text.Trim().Length <= 0 || this.textBox2.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Поле пусте", "ПОМИЛКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                if (num2 == 0)
                {
                    MessageBox.Show("Ділення на нуль неможливе", "ПОМИЛКА", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else

                {
                    double result = num1 / num2;
                    label1.Text = "Відповіть: " + result.ToString();
                }
            }
            catch
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 newform1 = new Form1();
            newform1.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            
        }
    }
}
