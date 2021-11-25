namespace _20211007
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
            this.lbl_nev = new System.Windows.Forms.Label();
            this.lbl_tipp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_darab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nev
            // 
            this.lbl_nev.AutoSize = true;
            this.lbl_nev.Location = new System.Drawing.Point(28, 36);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(86, 13);
            this.lbl_nev.TabIndex = 0;
            this.lbl_nev.Text = "A Játékos Neve:";
            // 
            // lbl_tipp
            // 
            this.lbl_tipp.AutoSize = true;
            this.lbl_tipp.Location = new System.Drawing.Point(32, 96);
            this.lbl_tipp.Name = "lbl_tipp";
            this.lbl_tipp.Size = new System.Drawing.Size(87, 13);
            this.lbl_tipp.TabIndex = 1;
            this.lbl_tipp.Text = "A Játékos Tipjjei:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(329, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // lbl_darab
            // 
            this.lbl_darab.AutoSize = true;
            this.lbl_darab.Location = new System.Drawing.Point(490, 96);
            this.lbl_darab.Name = "lbl_darab";
            this.lbl_darab.Size = new System.Drawing.Size(28, 13);
            this.lbl_darab.TabIndex = 4;
            this.lbl_darab.Text = "0 db";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Jatekos Hozzaadasa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_darab);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_tipp);
            this.Controls.Add(this.lbl_nev);
            this.Name = "Form1";
            this.Text = "Egyszamjatek GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.Label lbl_tipp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_darab;
        private System.Windows.Forms.Button button1;
    }
}

