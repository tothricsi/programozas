namespace _20211014
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
            this.tbn_szamol = new System.Windows.Forms.Button();
            this.txt_magassag = new System.Windows.Forms.TextBox();
            this.txt_sugar = new System.Windows.Forms.TextBox();
            this.txt_felszin = new System.Windows.Forms.TextBox();
            this.txt_terfogat = new System.Windows.Forms.TextBox();
            this.btn_kilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magassága:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sugár:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Felszine:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Térfogata:";
            // 
            // tbn_szamol
            // 
            this.tbn_szamol.Location = new System.Drawing.Point(290, 285);
            this.tbn_szamol.Name = "tbn_szamol";
            this.tbn_szamol.Size = new System.Drawing.Size(75, 23);
            this.tbn_szamol.TabIndex = 4;
            this.tbn_szamol.Text = "Számol";
            this.tbn_szamol.UseVisualStyleBackColor = true;
            this.tbn_szamol.Click += new System.EventHandler(this.Tbn_szamol_Click);
            // 
            // txt_magassag
            // 
            this.txt_magassag.Location = new System.Drawing.Point(145, 38);
            this.txt_magassag.Name = "txt_magassag";
            this.txt_magassag.Size = new System.Drawing.Size(220, 20);
            this.txt_magassag.TabIndex = 6;
            this.txt_magassag.TextChanged += new System.EventHandler(this.Txt_magassag_TextChanged);
            // 
            // txt_sugar
            // 
            this.txt_sugar.Location = new System.Drawing.Point(145, 79);
            this.txt_sugar.Name = "txt_sugar";
            this.txt_sugar.Size = new System.Drawing.Size(220, 20);
            this.txt_sugar.TabIndex = 7;
            this.txt_sugar.TextChanged += new System.EventHandler(this.Txt_sugar_TextChanged);
            // 
            // txt_felszin
            // 
            this.txt_felszin.Enabled = false;
            this.txt_felszin.Location = new System.Drawing.Point(145, 139);
            this.txt_felszin.Name = "txt_felszin";
            this.txt_felszin.Size = new System.Drawing.Size(220, 20);
            this.txt_felszin.TabIndex = 8;
            this.txt_felszin.TextChanged += new System.EventHandler(this.Txt_felszin_TextChanged);
            // 
            // txt_terfogat
            // 
            this.txt_terfogat.Enabled = false;
            this.txt_terfogat.Location = new System.Drawing.Point(145, 185);
            this.txt_terfogat.Name = "txt_terfogat";
            this.txt_terfogat.Size = new System.Drawing.Size(220, 20);
            this.txt_terfogat.TabIndex = 9;
            // 
            // btn_kilepes
            // 
            this.btn_kilepes.Location = new System.Drawing.Point(71, 285);
            this.btn_kilepes.Name = "btn_kilepes";
            this.btn_kilepes.Size = new System.Drawing.Size(75, 23);
            this.btn_kilepes.TabIndex = 10;
            this.btn_kilepes.Text = "Kilépés";
            this.btn_kilepes.UseVisualStyleBackColor = true;
            this.btn_kilepes.Click += new System.EventHandler(this.Btn_kilepes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 364);
            this.Controls.Add(this.btn_kilepes);
            this.Controls.Add(this.txt_terfogat);
            this.Controls.Add(this.txt_felszin);
            this.Controls.Add(this.txt_sugar);
            this.Controls.Add(this.txt_magassag);
            this.Controls.Add(this.tbn_szamol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Henger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tbn_szamol;
        private System.Windows.Forms.TextBox txt_magassag;
        private System.Windows.Forms.TextBox txt_sugar;
        private System.Windows.Forms.TextBox txt_felszin;
        private System.Windows.Forms.TextBox txt_terfogat;
        private System.Windows.Forms.Button btn_kilepes;
    }
}

