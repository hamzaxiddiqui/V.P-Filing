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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Source Address";
            this.label2.Text = "File Name";
            this.label3.Text = " Destination Address";
            this.button1.Text = "Ok";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = this.textBox1.Text + this.textBox2.Text;
            String d = this.textBox3.Text  + this.textBox2.Text;
            if (File.Exists(d))
            {

                DialogResult dr = MessageBox.Show("Your file Already Exist do you want to replace? ");
                if (dr == DialogResult.OK)
                {
                    File.Delete(d);
                    File.Copy(s, d);
                }

            }
            else
            {
            File.Copy(s,d);
            }
                
            }
        }

    }
