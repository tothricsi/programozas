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

namespace _20211118
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_kilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_torol_Click(object sender, EventArgs e)
        {
            txt_datum.Text = "";
            txt_helyezes.Text = "";
            txt_helyszin.Text = "";
            txt_pont.Text = "";
        }

        private void Btn_fejlbairas_Click(object sender, EventArgs e)
        {
                if (txt_datum.Text != "" & txt_helyszin.Text != "" & txt_helyezes.Text != "" & txt_pont.Text != "")
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string kiir = txt_datum.Text + "\t" + txt_helyszin.Text + "\t" + txt_helyezes.Text + "\t" + txt_pont.Text;
                        File.AppendAllText(saveFileDialog1.FileName, kiir);
                        MessageBox.Show("a mentes sikeres volt", "mentes");
                        txt_datum.Text = "";
                        txt_helyszin.Text = "";
                        txt_helyezes.Text = "";
                        txt_pont.Text = "";
                    }
                }
            else
            {
                MessageBox.Show("nem adtad meg az osszes erteket");
            }
        }

        private void Btn_feltoltes_Click(object sender, EventArgs e)
        {
            string[] beolvas = File.ReadAllLines("Prost.csv", Encoding.Default);
            for (int i = 0; i < beolvas.Length; i++)
            {
                listBox1.Items.Add(beolvas);
            }
        }
    }
    }


       