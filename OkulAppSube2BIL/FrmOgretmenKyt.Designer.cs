namespace OkulAppSube2BIL
{
    partial class FrmOgretmenKyt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.btnOgrBul = new System.Windows.Forms.Button();
            this.btnOgrSil = new System.Windows.Forms.Button();
            this.btnOgrGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogretmen Kayıt";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(153, 83);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(153, 35);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 5;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(153, 135);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(48, 90);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(37, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Soyad";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(20, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ad";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(48, 142);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(37, 13);
            this.lblTc.TabIndex = 0;
            this.lblTc.Text = "Tc No";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(118, 230);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnOgrBul
            // 
            this.btnOgrBul.Location = new System.Drawing.Point(308, 55);
            this.btnOgrBul.Name = "btnOgrBul";
            this.btnOgrBul.Size = new System.Drawing.Size(75, 23);
            this.btnOgrBul.TabIndex = 9;
            this.btnOgrBul.Text = "BUL";
            this.btnOgrBul.UseVisualStyleBackColor = true;
            this.btnOgrBul.Click += new System.EventHandler(this.btnOgrBul_Click);
            // 
            // btnOgrSil
            // 
            this.btnOgrSil.Location = new System.Drawing.Point(307, 97);
            this.btnOgrSil.Name = "btnOgrSil";
            this.btnOgrSil.Size = new System.Drawing.Size(75, 23);
            this.btnOgrSil.TabIndex = 10;
            this.btnOgrSil.Text = "SİL";
            this.btnOgrSil.UseVisualStyleBackColor = true;
            this.btnOgrSil.Click += new System.EventHandler(this.btnOgrSil_Click);
            // 
            // btnOgrGuncelle
            // 
            this.btnOgrGuncelle.Location = new System.Drawing.Point(307, 140);
            this.btnOgrGuncelle.Name = "btnOgrGuncelle";
            this.btnOgrGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnOgrGuncelle.TabIndex = 11;
            this.btnOgrGuncelle.Text = "GÜNCELLE";
            this.btnOgrGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrGuncelle.Click += new System.EventHandler(this.btnOgrGuncelle_Click);
            // 
            // FrmOgretmenKyt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 270);
            this.Controls.Add(this.btnOgrGuncelle);
            this.Controls.Add(this.btnOgrSil);
            this.Controls.Add(this.btnOgrBul);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOgretmenKyt";
            this.Text = "FrmOgretmenKyt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKaydet;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTc;
        public System.Windows.Forms.Button btnOgrBul;
        public System.Windows.Forms.Button btnOgrSil;
        public System.Windows.Forms.Button btnOgrGuncelle;
    }
}