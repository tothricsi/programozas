﻿namespace _20211004_OrvosiNobeldijasokGUI
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
            this.txt_ev = new System.Windows.Forms.TextBox();
            this.txt_nev = new System.Windows.Forms.TextBox();
            this.txt_szh = new System.Windows.Forms.TextBox();
            this.txt_orszag = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Év:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sz/H:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ország";
            // 
            // txt_ev
            // 
            this.txt_ev.Location = new System.Drawing.Point(105, 44);
            this.txt_ev.Name = "txt_ev";
            this.txt_ev.Size = new System.Drawing.Size(52, 20);
            this.txt_ev.TabIndex = 4;
            // 
            // txt_nev
            // 
            this.txt_nev.Location = new System.Drawing.Point(105, 70);
            this.txt_nev.Name = "txt_nev";
            this.txt_nev.Size = new System.Drawing.Size(159, 20);
            this.txt_nev.TabIndex = 5;
            // 
            // txt_szh
            // 
            this.txt_szh.Location = new System.Drawing.Point(105, 96);
            this.txt_szh.Name = "txt_szh";
            this.txt_szh.Size = new System.Drawing.Size(95, 20);
            this.txt_szh.TabIndex = 6;
            // 
            // txt_orszag
            // 
            this.txt_orszag.Location = new System.Drawing.Point(105, 122);
            this.txt_orszag.Name = "txt_orszag";
            this.txt_orszag.Size = new System.Drawing.Size(52, 20);
            this.txt_orszag.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adatok mentése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_orszag);
            this.Controls.Add(this.txt_szh);
            this.Controls.Add(this.txt_nev);
            this.Controls.Add(this.txt_ev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Orvosi Nobel-díjasok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ev;
        private System.Windows.Forms.TextBox txt_nev;
        private System.Windows.Forms.TextBox txt_szh;
        private System.Windows.Forms.TextBox txt_orszag;
        private System.Windows.Forms.Button button1;
    }
}

