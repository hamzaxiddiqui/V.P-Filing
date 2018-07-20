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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text = "File Name";
            this.button1.Text = "Delete";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String d = this.textBox1.Text;
            File.Delete(d);
            MessageBox.Show("Your File Has deleted");
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
