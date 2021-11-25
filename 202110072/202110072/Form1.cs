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

namespace _202110072
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string beolvas = File.ReadAllLines("gyumolcsok.txt");
            foreach (string item in beolvas)
            {
                listBox1.Items.add(item);
            }
        }
    }
}
