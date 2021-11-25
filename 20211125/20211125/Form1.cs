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

namespace _20211125
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

        private void Btn_beolvas_Click(object sender, EventArgs e)
        {
            string[] beolvas = File.ReadAllLines("lift.txt", Encoding.Default);
            for (int i = 0; i < beolvas.Length; i++)
            {
                listBox1.Items.Add(beolvas[i]);
            }
        }

        private void Btn_torol_Click(object sender, EventArgs e)
        {
            txt_idopont.Text = "";
            txt_cel.Text = "";
            txt_indulo.Text = "";
            txt_sorszam.Text = "";
            listBox1.Items.Clear();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_feltolt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (txt_idopont.Text != "" && txt_sorszam.Text != "" & txt_indulo.Text !="" && txt_cel.Text != "" )
            {
                string ertekek = txt_idopont.Text + " " + txt_sorszam.Text + " " +txt_indulo.Text +" "+  txt_cel.Text;
                listBox1.Items.Add(ertekek);
            }
            else
            {
                MessageBox.Show("Nem adtad meg az osszes erteket");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txt_idopont.Text != "" && txt_sorszam.Text != "" & txt_indulo.Text != "" && txt_cel.Text != "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string kiir = txt_idopont.Text + " " + txt_sorszam.Text + " " + txt_indulo.Text + " " + txt_cel.Text;
                    File.AppendAllText(saveFileDialog1.FileName, kiir);
                    MessageBox.Show("a mentes sikeres volt", "mentes");
                    txt_idopont.Text = "";
                    txt_cel.Text = "";
                    txt_indulo.Text = "";
                    txt_sorszam.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Nem adtad meg az osszes erteket");
            }
            }

        private void Btn_kereses_Click(object sender, EventArgs e)
        {
            if (txt_idopont.Text !="" || txt_sorszam.Text!="")
            {
                List<string> elemek = new List<string>();
                foreach (var item in listBox1.Items)
                {
                    elemek.Add(item.ToString());
                }
                listBox1.Items.Clear();
                foreach (var item in elemek)
                {
                    if (item.Contains(txt_idopont.Text))
                    {
                            listBox1.Items.Add(item);
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("nem adtad meg az ertekeket");
            }
        }
    }
    
}
