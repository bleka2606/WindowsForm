using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Число:0";
        }

         private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
         private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

         int count = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            
            count ++;
            label2.Text = "Число:" + count.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
