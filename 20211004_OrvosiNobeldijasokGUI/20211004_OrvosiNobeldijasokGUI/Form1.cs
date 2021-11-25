using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211004_OrvosiNobeldijasokGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(txt_ev.Text) < 1989)
            {
                MessageBox.Show("Hiba! Az évszám nem megfelelő!");
            }
            if (txt_nev.Text == "" || txt_ev.Text == "" || txt_orszag.Text == "" || txt_szh.Text== "")
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
            }
        }
    }
}
