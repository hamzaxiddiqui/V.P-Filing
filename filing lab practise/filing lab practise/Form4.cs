using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace filing_lab_practise
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.label1.Text = "File Name";
            this.button1.Text = "OK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ex = this.textBox1.Text;

            if (File.Exists(ex))
            {
                MessageBox.Show("Your File Exist");
            }
            else {
                MessageBox.Show("Not Exist");
            }
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
