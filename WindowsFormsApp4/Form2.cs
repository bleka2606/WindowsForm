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
        double num1 = 0;
        double num2 = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GetUserValue()
        {
            if (this.textBox1.Text.Trim().Length <= 0 || this.textBox2.Text.Trim().Length <= 0)
                throw new Exception("Поле пусте");

            num1 = Convert.ToDouble(textBox1.Text.Trim());
            num2 = Convert.ToDouble(textBox2.Text.Trim());
        }

        private void ShowResult(double value)
        {
            label1.Text = "Відповіть: " + value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetUserValue();
            ShowResult(num1 + num2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetUserValue();
            ShowResult(num1 - num2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetUserValue();
            ShowResult(num1 * num2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetUserValue();
            if (num2 == 0)
                throw new Exception("Ділення на нуль неможливе");
            else
                ShowResult(num1 / num2);

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