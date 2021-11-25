namespace _20211110_tengerszint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_orszag = new System.Windows.Forms.TextBox();
            this.txt_csucs = new System.Windows.Forms.TextBox();
            this.txt_magassag = new System.Windows.Forms.TextBox();
            this.btn_mentes = new System.Windows.Forms.Button();
            this.btn_torles = new System.Windows.Forms.Button();
            this.btn_kilepes = new System.Windows.Forms.Button();
            this.lbx_adatok = new System.Windows.Forms.ListBox();
            this.btn_feltoltes = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "orszag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "csucs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "magassag";
            // 
            // txt_orszag
            // 
            this.txt_orszag.Location = new System.Drawing.Point(143, 61);
            this.txt_orszag.Name = "txt_orszag";
            this.txt_orszag.Size = new System.Drawing.Size(100, 20);
            this.txt_orszag.TabIndex = 1;
            // 
            // txt_csucs
            // 
            this.txt_csucs.Location = new System.Drawing.Point(143, 98);
            this.txt_csucs.Name = "txt_csucs";
            this.txt_csucs.Size = new System.Drawing.Size(100, 20);
            this.txt_csucs.TabIndex = 2;
            // 
            // txt_magassag
            // 
            this.txt_magassag.Location = new System.Drawing.Point(143, 136);
            this.txt_magassag.Name = "txt_magassag";
            this.txt_magassag.Size = new System.Drawing.Size(100, 20);
            this.txt_magassag.TabIndex = 3;
            // 
            // btn_mentes
            // 
            this.btn_mentes.Location = new System.Drawing.Point(62, 191);
            this.btn_mentes.Name = "btn_mentes";
            this.btn_mentes.Size = new System.Drawing.Size(75, 23);
            this.btn_mentes.TabIndex = 4;
            this.btn_mentes.Text = "mentes";
            this.btn_mentes.UseVisualStyleBackColor = true;
            this.btn_mentes.Click += new System.EventHandler(this.Btn_mentes_Click);
            // 
            // btn_torles
            // 
            this.btn_torles.Location = new System.Drawing.Point(209, 191);
            this.btn_torles.Name = "btn_torles";
            this.btn_torles.Size = new System.Drawing.Size(75, 23);
            this.btn_torles.TabIndex = 5;
            this.btn_torles.Text = "torles";
            this.btn_torles.UseVisualStyleBackColor = true;
            this.btn_torles.Click += new System.EventHandler(this.Btn_torles_Click);
            // 
            // btn_kilepes
            // 
            this.btn_kilepes.Location = new System.Drawing.Point(209, 284);
            this.btn_kilepes.Name = "btn_kilepes";
            this.btn_kilepes.Size = new System.Drawing.Size(75, 23);
            this.btn_kilepes.TabIndex = 6;
            this.btn_kilepes.Text = "kilepes";
            this.btn_kilepes.UseVisualStyleBackColor = true;
            this.btn_kilepes.Click += new System.EventHandler(this.Btn_kilepes_Click);
            // 
            // lbx_adatok
            // 
            this.lbx_adatok.FormattingEnabled = true;
            this.lbx_adatok.Location = new System.Drawing.Point(360, 64);
            this.lbx_adatok.Name = "lbx_adatok";
            this.lbx_adatok.Size = new System.Drawing.Size(337, 251);
            this.lbx_adatok.Sorted = true;
            this.lbx_adatok.TabIndex = 7;
            // 
            // btn_feltoltes
            // 
            this.btn_feltoltes.Location = new System.Drawing.Point(62, 284);
            this.btn_feltoltes.Name = "btn_feltoltes";
            this.btn_feltoltes.Size = new System.Drawing.Size(75, 23);
            this.btn_feltoltes.TabIndex = 8;
            this.btn_feltoltes.Text = "feltoltes";
            this.btn_feltoltes.UseVisualStyleBackColor = true;
            this.btn_feltoltes.Click += new System.EventHandler(this.Btn_feltoltes_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(635, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_feltoltes);
            this.Controls.Add(this.lbx_adatok);
            this.Controls.Add(this.btn_kilepes);
            this.Controls.Add(this.btn_torles);
            this.Controls.Add(this.btn_mentes);
            this.Controls.Add(this.txt_magassag);
            this.Controls.Add(this.txt_csucs);
            this.Controls.Add(this.txt_orszag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "tengerszintgui";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_orszag;
        private System.Windows.Forms.TextBox txt_csucs;
        private System.Windows.Forms.TextBox txt_magassag;
        private System.Windows.Forms.Button btn_mentes;
        private System.Windows.Forms.Button btn_torles;
        private System.Windows.Forms.Button btn_kilepes;
        private System.Windows.Forms.ListBox lbx_adatok;
        private System.Windows.Forms.Button btn_feltoltes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

