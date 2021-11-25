namespace _20211118
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_torol = new System.Windows.Forms.Button();
            this.btn_fejlbairas = new System.Windows.Forms.Button();
            this.btn_kereses = new System.Windows.Forms.Button();
            this.btn_kilepes = new System.Windows.Forms.Button();
            this.btn_feltoltes = new System.Windows.Forms.Button();
            this.txt_datum = new System.Windows.Forms.TextBox();
            this.txt_helyszin = new System.Windows.Forms.TextBox();
            this.txt_helyezes = new System.Windows.Forms.TextBox();
            this.txt_pont = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Helyszin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Helyezes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pont";
            // 
            // btn_torol
            // 
            this.btn_torol.Location = new System.Drawing.Point(32, 271);
            this.btn_torol.Name = "btn_torol";
            this.btn_torol.Size = new System.Drawing.Size(75, 23);
            this.btn_torol.TabIndex = 4;
            this.btn_torol.Text = "Torol";
            this.btn_torol.UseVisualStyleBackColor = true;
            this.btn_torol.Click += new System.EventHandler(this.Btn_torol_Click);
            // 
            // btn_fejlbairas
            // 
            this.btn_fejlbairas.Location = new System.Drawing.Point(174, 271);
            this.btn_fejlbairas.Name = "btn_fejlbairas";
            this.btn_fejlbairas.Size = new System.Drawing.Size(75, 23);
            this.btn_fejlbairas.TabIndex = 5;
            this.btn_fejlbairas.Text = "Fajlba iras";
            this.btn_fejlbairas.UseVisualStyleBackColor = true;
            this.btn_fejlbairas.Click += new System.EventHandler(this.Btn_fejlbairas_Click);
            // 
            // btn_kereses
            // 
            this.btn_kereses.Location = new System.Drawing.Point(105, 312);
            this.btn_kereses.Name = "btn_kereses";
            this.btn_kereses.Size = new System.Drawing.Size(75, 23);
            this.btn_kereses.TabIndex = 7;
            this.btn_kereses.Text = "Keresés";
            this.btn_kereses.UseVisualStyleBackColor = true;
            // 
            // btn_kilepes
            // 
            this.btn_kilepes.Location = new System.Drawing.Point(241, 314);
            this.btn_kilepes.Name = "btn_kilepes";
            this.btn_kilepes.Size = new System.Drawing.Size(75, 23);
            this.btn_kilepes.TabIndex = 8;
            this.btn_kilepes.Text = "Kilepes";
            this.btn_kilepes.UseVisualStyleBackColor = true;
            this.btn_kilepes.Click += new System.EventHandler(this.Btn_kilepes_Click);
            // 
            // btn_feltoltes
            // 
            this.btn_feltoltes.Location = new System.Drawing.Point(316, 271);
            this.btn_feltoltes.Name = "btn_feltoltes";
            this.btn_feltoltes.Size = new System.Drawing.Size(75, 23);
            this.btn_feltoltes.TabIndex = 9;
            this.btn_feltoltes.Text = "Feltoltes";
            this.btn_feltoltes.UseVisualStyleBackColor = true;
            this.btn_feltoltes.Click += new System.EventHandler(this.Btn_feltoltes_Click);
            // 
            // txt_datum
            // 
            this.txt_datum.Location = new System.Drawing.Point(139, 29);
            this.txt_datum.Name = "txt_datum";
            this.txt_datum.Size = new System.Drawing.Size(100, 20);
            this.txt_datum.TabIndex = 10;
            // 
            // txt_helyszin
            // 
            this.txt_helyszin.Location = new System.Drawing.Point(139, 88);
            this.txt_helyszin.Name = "txt_helyszin";
            this.txt_helyszin.Size = new System.Drawing.Size(100, 20);
            this.txt_helyszin.TabIndex = 11;
            // 
            // txt_helyezes
            // 
            this.txt_helyezes.Location = new System.Drawing.Point(139, 145);
            this.txt_helyezes.Name = "txt_helyezes";
            this.txt_helyezes.Size = new System.Drawing.Size(100, 20);
            this.txt_helyezes.TabIndex = 12;
            // 
            // txt_pont
            // 
            this.txt_pont.Location = new System.Drawing.Point(139, 217);
            this.txt_pont.Name = "txt_pont";
            this.txt_pont.Size = new System.Drawing.Size(100, 20);
            this.txt_pont.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(275, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(446, 212);
            this.listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 350);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_pont);
            this.Controls.Add(this.txt_helyezes);
            this.Controls.Add(this.txt_helyszin);
            this.Controls.Add(this.txt_datum);
            this.Controls.Add(this.btn_feltoltes);
            this.Controls.Add(this.btn_kilepes);
            this.Controls.Add(this.btn_kereses);
            this.Controls.Add(this.btn_fejlbairas);
            this.Controls.Add(this.btn_torol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_torol;
        private System.Windows.Forms.Button btn_fejlbairas;
        private System.Windows.Forms.Button btn_kereses;
        private System.Windows.Forms.Button btn_kilepes;
        private System.Windows.Forms.Button btn_feltoltes;
        private System.Windows.Forms.TextBox txt_datum;
        private System.Windows.Forms.TextBox txt_helyszin;
        private System.Windows.Forms.TextBox txt_helyezes;
        private System.Windows.Forms.TextBox txt_pont;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

