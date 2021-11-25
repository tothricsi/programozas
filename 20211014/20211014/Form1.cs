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

namespace _20211014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_kilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Txt_magassag_TextChanged(object sender, EventArgs e)
        {
        }

        private void Txt_sugar_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Txt_felszin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Tbn_szamol_Click(object sender, EventArgs e)
        {
            int m =int.Parse(txt_magassag.Text);
            int r = int.Parse(txt_sugar.Text);
            txt_terfogat.Text = 
        }
    }
}
