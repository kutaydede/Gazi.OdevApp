namespace Gazi.OdevApp
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpOgrenci = new System.Windows.Forms.GroupBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnOgrtKaydet = new System.Windows.Forms.Button();
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.txtOgrtTc = new System.Windows.Forms.TextBox();
            this.lblOgrtAd = new System.Windows.Forms.Label();
            this.lblOgrtSoyad = new System.Windows.Forms.Label();
            this.txtOgrtSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrtAd = new System.Windows.Forms.TextBox();
            this.lblOgrtTc = new System.Windows.Forms.Label();
            this.grpOgrenci.SuspendLayout();
            this.grpOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(163, 240);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 28);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // grpOgrenci
            // 
            this.grpOgrenci.Controls.Add(this.txtNumara);
            this.grpOgrenci.Controls.Add(this.lblAd);
            this.grpOgrenci.Controls.Add(this.lblSoyad);
            this.grpOgrenci.Controls.Add(this.lblNumara);
            this.grpOgrenci.Controls.Add(this.txtSoyad);
            this.grpOgrenci.Controls.Add(this.txtAd);
            this.grpOgrenci.Location = new System.Drawing.Point(52, 32);
            this.grpOgrenci.Margin = new System.Windows.Forms.Padding(4);
            this.grpOgrenci.Name = "grpOgrenci";
            this.grpOgrenci.Padding = new System.Windows.Forms.Padding(4);
            this.grpOgrenci.Size = new System.Drawing.Size(281, 187);
            this.grpOgrenci.TabIndex = 12;
            this.grpOgrenci.TabStop = false;
            this.grpOgrenci.Text = "Öğrenci Bilgileri";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(111, 138);
            this.txtNumara.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(132, 22);
            this.txtNumara.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(39, 46);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(39, 90);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(39, 138);
            this.lblNumara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(55, 16);
            this.lblNumara.TabIndex = 6;
            this.lblNumara.Text = "Numara";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(111, 81);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(132, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(111, 37);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 22);
            this.txtAd.TabIndex = 1;
            // 
            // btnOgrtKaydet
            // 
            this.btnOgrtKaydet.Location = new System.Drawing.Point(526, 240);
            this.btnOgrtKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrtKaydet.Name = "btnOgrtKaydet";
            this.btnOgrtKaydet.Size = new System.Drawing.Size(133, 28);
            this.btnOgrtKaydet.TabIndex = 15;
            this.btnOgrtKaydet.Text = "Kaydet";
            this.btnOgrtKaydet.UseVisualStyleBackColor = true;
            this.btnOgrtKaydet.Click += new System.EventHandler(this.btnOgrtKaydet_Click);
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.txtOgrtTc);
            this.grpOgretmen.Controls.Add(this.lblOgrtAd);
            this.grpOgretmen.Controls.Add(this.lblOgrtSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgrtSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgrtAd);
            this.grpOgretmen.Controls.Add(this.lblOgrtTc);
            this.grpOgretmen.Location = new System.Drawing.Point(416, 32);
            this.grpOgretmen.Margin = new System.Windows.Forms.Padding(4);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Padding = new System.Windows.Forms.Padding(4);
            this.grpOgretmen.Size = new System.Drawing.Size(281, 187);
            this.grpOgretmen.TabIndex = 14;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Öğretmen Bilgileri";
            // 
            // txtOgrtTc
            // 
            this.txtOgrtTc.Location = new System.Drawing.Point(112, 37);
            this.txtOgrtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrtTc.Name = "txtOgrtTc";
            this.txtOgrtTc.Size = new System.Drawing.Size(132, 22);
            this.txtOgrtTc.TabIndex = 3;
            // 
            // lblOgrtAd
            // 
            this.lblOgrtAd.AutoSize = true;
            this.lblOgrtAd.Location = new System.Drawing.Point(39, 90);
            this.lblOgrtAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrtAd.Name = "lblOgrtAd";
            this.lblOgrtAd.Size = new System.Drawing.Size(24, 16);
            this.lblOgrtAd.TabIndex = 4;
            this.lblOgrtAd.Text = "Ad";
            // 
            // lblOgrtSoyad
            // 
            this.lblOgrtSoyad.AutoSize = true;
            this.lblOgrtSoyad.Location = new System.Drawing.Point(39, 144);
            this.lblOgrtSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrtSoyad.Name = "lblOgrtSoyad";
            this.lblOgrtSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblOgrtSoyad.TabIndex = 5;
            this.lblOgrtSoyad.Text = "Soyad";
            // 
            // txtOgrtSoyad
            // 
            this.txtOgrtSoyad.Location = new System.Drawing.Point(112, 138);
            this.txtOgrtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrtSoyad.Name = "txtOgrtSoyad";
            this.txtOgrtSoyad.Size = new System.Drawing.Size(132, 22);
            this.txtOgrtSoyad.TabIndex = 2;
            // 
            // txtOgrtAd
            // 
            this.txtOgrtAd.Location = new System.Drawing.Point(111, 81);
            this.txtOgrtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrtAd.Name = "txtOgrtAd";
            this.txtOgrtAd.Size = new System.Drawing.Size(132, 22);
            this.txtOgrtAd.TabIndex = 1;
            // 
            // lblOgrtTc
            // 
            this.lblOgrtTc.AutoSize = true;
            this.lblOgrtTc.Location = new System.Drawing.Point(39, 46);
            this.lblOgrtTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrtTc.Name = "lblOgrtTc";
            this.lblOgrtTc.Size = new System.Drawing.Size(23, 16);
            this.lblOgrtTc.TabIndex = 6;
            this.lblOgrtTc.Text = "Tc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 280);
            this.Controls.Add(this.btnOgrtKaydet);
            this.Controls.Add(this.grpOgretmen);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpOgrenci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpOgrenci.ResumeLayout(false);
            this.grpOgrenci.PerformLayout();
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox grpOgrenci;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnOgrtKaydet;
        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.Windows.Forms.TextBox txtOgrtTc;
        private System.Windows.Forms.Label lblOgrtAd;
        private System.Windows.Forms.Label lblOgrtSoyad;
        private System.Windows.Forms.TextBox txtOgrtSoyad;
        private System.Windows.Forms.TextBox txtOgrtAd;
        private System.Windows.Forms.Label lblOgrtTc;
    }
}

