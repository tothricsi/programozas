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

namespace _20211110_tengerszint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_kilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_mentes_Click(object sender, EventArgs e)
        {
            if (txt_orszag.Text!="" & txt_csucs.Text!="" & txt_magassag.Text!="")
            {
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    string kiir = txt_orszag.Text + ";" + txt_csucs.Text + ";" + txt_magassag.Text;
                    File.AppendAllText(saveFileDialog1.FileName, kiir );
                    MessageBox.Show("a mentes sikeres volt","mentes");
                    txt_csucs.Text = "";
                    txt_magassag.Text = "";
                    txt_orszag.Text = "";
                    
                }
            }
            else
            {
                MessageBox.Show("nem adtal meg erteket", "hiba");
            }
        }

        private void Btn_feltoltes_Click(object sender, EventArgs e)
        {
            string[] beolvas = File.ReadAllLines("tengerszint.txt", Encoding.Default);
            string[] darabok;
            foreach (var item in beolvas)
            {
                darabok = item.Split('\t');
                if (!lbx_adatok.Items.Contains(darabok[1]))
                {
                        lbx_adatok.Items.Add(darabok[1]);
                }
            }
        }

        private void Btn_torles_Click(object sender, EventArgs e)
        {
            lbx_adatok.Items.Clear();
        }
    }
}
