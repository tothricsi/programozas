namespace _20211125
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_beolvas = new System.Windows.Forms.Button();
            this.btn_torol = new System.Windows.Forms.Button();
            this.txt_idopont = new System.Windows.Forms.TextBox();
            this.txt_indulo = new System.Windows.Forms.TextBox();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.btn_kereses = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_feltolt = new System.Windows.Forms.Button();
            this.txt_sorszam = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(425, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 355);
            this.listBox1.TabIndex = 1;
            // 
            // btn_beolvas
            // 
            this.btn_beolvas.Location = new System.Drawing.Point(35, 309);
            this.btn_beolvas.Name = "btn_beolvas";
            this.btn_beolvas.Size = new System.Drawing.Size(75, 23);
            this.btn_beolvas.TabIndex = 2;
            this.btn_beolvas.Text = "beolvas";
            this.btn_beolvas.UseVisualStyleBackColor = true;
            this.btn_beolvas.Click += new System.EventHandler(this.Btn_beolvas_Click);
            // 
            // btn_torol
            // 
            this.btn_torol.Location = new System.Drawing.Point(151, 309);
            this.btn_torol.Name = "btn_torol";
            this.btn_torol.Size = new System.Drawing.Size(75, 23);
            this.btn_torol.TabIndex = 3;
            this.btn_torol.Text = "torles";
            this.btn_torol.UseVisualStyleBackColor = true;
            this.btn_torol.Click += new System.EventHandler(this.Btn_torol_Click);
            // 
            // txt_idopont
            // 
            this.txt_idopont.Location = new System.Drawing.Point(136, 44);
            this.txt_idopont.Name = "txt_idopont";
            this.txt_idopont.Size = new System.Drawing.Size(100, 20);
            this.txt_idopont.TabIndex = 4;
            // 
            // txt_indulo
            // 
            this.txt_indulo.Location = new System.Drawing.Point(136, 133);
            this.txt_indulo.Name = "txt_indulo";
            this.txt_indulo.Size = new System.Drawing.Size(100, 20);
            this.txt_indulo.TabIndex = 6;
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(136, 178);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(100, 20);
            this.txt_cel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "hasznalat idopointja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "kartya sorszama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "indulo szint";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "celszint";
            // 
            // btn_kilep
            // 
            this.btn_kilep.Location = new System.Drawing.Point(270, 309);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(75, 23);
            this.btn_kilep.TabIndex = 12;
            this.btn_kilep.Text = "kilepes";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.Btn_kilep_Click);
            // 
            // btn_kereses
            // 
            this.btn_kereses.Location = new System.Drawing.Point(35, 376);
            this.btn_kereses.Name = "btn_kereses";
            this.btn_kereses.Size = new System.Drawing.Size(75, 23);
            this.btn_kereses.TabIndex = 13;
            this.btn_kereses.Text = "kereses";
            this.btn_kereses.UseVisualStyleBackColor = true;
            this.btn_kereses.Click += new System.EventHandler(this.Btn_kereses_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "fajlba iras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btn_feltolt
            // 
            this.btn_feltolt.Location = new System.Drawing.Point(270, 376);
            this.btn_feltolt.Name = "btn_feltolt";
            this.btn_feltolt.Size = new System.Drawing.Size(75, 23);
            this.btn_feltolt.TabIndex = 15;
            this.btn_feltolt.Text = "feltoltes";
            this.btn_feltolt.UseVisualStyleBackColor = true;
            this.btn_feltolt.Click += new System.EventHandler(this.Btn_feltolt_Click);
            // 
            // txt_sorszam
            // 
            this.txt_sorszam.Location = new System.Drawing.Point(136, 86);
            this.txt_sorszam.Name = "txt_sorszam";
            this.txt_sorszam.Size = new System.Drawing.Size(100, 20);
            this.txt_sorszam.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_sorszam);
            this.Controls.Add(this.btn_feltolt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_kereses);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cel);
            this.Controls.Add(this.txt_indulo);
            this.Controls.Add(this.txt_idopont);
            this.Controls.Add(this.btn_torol);
            this.Controls.Add(this.btn_beolvas);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_beolvas;
        private System.Windows.Forms.Button btn_torol;
        private System.Windows.Forms.TextBox txt_idopont;
        private System.Windows.Forms.TextBox txt_indulo;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.Button btn_kereses;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_feltolt;
        private System.Windows.Forms.TextBox txt_sorszam;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

