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

namespace _20211007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="")
            {
                if (File.Exists("tippek.txt"))
                {
                    string osszes = File.ReadAllText("tippek.txt");
                    if (osszes.Contains(textBox1.Text))
                    {
                        MessageBox.Show("van mar ilyen nevu jatekos");
                    }
                    else
                    {
                        string[] beolvas = File.ReadAllLines("tippek.txt");
                        int tippekszama = beolvas[0].Trim().Split(' ').Length - 1;
                        int tsz = textBox2.Text.Trim().Split(' ').Length;
                        if (tippekszama == tsz)
                        {
                            File.AppendAllText("tippek.txt", textBox1.Text + " " + textBox2.Text + "\n");
                            MessageBox.Show("az allomany sikeres volt");
                        }
                        else
                        {
                            MessageBox.Show("a tippek szama nem megfelelo");
                        }
                    }
                }
                else
                {
                    File.AppendAllText("tippek.txt", textBox1.Text + " " + textBox2.Text + "\n");
                    MessageBox.Show("az allomany sikeres volt");
                }
            }
            else
            {
                MessageBox.Show("add meg a nevet vagy tippet");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            string tartalom = textBox2.Text.Trim();
            int db = tartalom.Split(' ').Length;
            lbl_darab.Text = db + " db";
        }
    }
}
