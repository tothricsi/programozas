using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210930_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            if (n>m)
            {
                Console.WriteLine(MessageBox.Show("kissebb szam nagyobb mint a nagyobb szam"));
            }
            else
            {
                    
            }
            
        }
    }
}
