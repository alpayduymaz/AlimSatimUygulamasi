
namespace AlımSatımUygulaması
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtGirisKul = new System.Windows.Forms.TextBox();
            this.txtSifrekul = new System.Windows.Forms.TextBox();
            this.kayit = new System.Windows.Forms.Button();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiris.Location = new System.Drawing.Point(67, 171);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(182, 78);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtGirisKul
            // 
            this.txtGirisKul.BackColor = System.Drawing.Color.LightGray;
            this.txtGirisKul.Location = new System.Drawing.Point(67, 53);
            this.txtGirisKul.Margin = new System.Windows.Forms.Padding(2);
            this.txtGirisKul.Multiline = true;
            this.txtGirisKul.Name = "txtGirisKul";
            this.txtGirisKul.Size = new System.Drawing.Size(182, 32);
            this.txtGirisKul.TabIndex = 1;
            this.txtGirisKul.Text = "Kullanıcı Adı";
            this.txtGirisKul.Click += new System.EventHandler(this.txtGirisKul_Click);
            // 
            // txtSifrekul
            // 
            this.txtSifrekul.BackColor = System.Drawing.Color.LightGray;
            this.txtSifrekul.Location = new System.Drawing.Point(67, 107);
            this.txtSifrekul.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifrekul.Multiline = true;
            this.txtSifrekul.Name = "txtSifrekul";
            this.txtSifrekul.Size = new System.Drawing.Size(182, 32);
            this.txtSifrekul.TabIndex = 2;
            this.txtSifrekul.Text = "Şifre";
            this.txtSifrekul.UseSystemPasswordChar = true;
            this.txtSifrekul.Click += new System.EventHandler(this.txtSifrekul_Click);
            // 
            // kayit
            // 
            this.kayit.BackColor = System.Drawing.Color.DodgerBlue;
            this.kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kayit.Image = ((System.Drawing.Image)(resources.GetObject("kayit.Image")));
            this.kayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kayit.Location = new System.Drawing.Point(440, 340);
            this.kayit.Margin = new System.Windows.Forms.Padding(2);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(342, 81);
            this.kayit.TabIndex = 3;
            this.kayit.Text = "KAYDOL";
            this.kayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kayit.UseVisualStyleBackColor = false;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.BackColor = System.Drawing.Color.LightGray;
            this.txtKulAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKulAdi.Location = new System.Drawing.Point(440, 53);
            this.txtKulAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKulAdi.Multiline = true;
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(143, 31);
            this.txtKulAdi.TabIndex = 4;
            this.txtKulAdi.Text = "Kullanıcı Adı";
            this.txtKulAdi.Click += new System.EventHandler(this.txtKulAdi_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.LightGray;
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(440, 87);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(143, 31);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click);
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.LightGray;
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.Location = new System.Drawing.Point(440, 122);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(143, 30);
            this.txtAd.TabIndex = 6;
            this.txtAd.Text = "Ad";
            this.txtAd.Click += new System.EventHandler(this.txtAd_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.LightGray;
            this.txtSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtSoyad.Location = new System.Drawing.Point(440, 156);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(143, 29);
            this.txtSoyad.TabIndex = 7;
            this.txtSoyad.Text = "Soyad";
            this.txtSoyad.Click += new System.EventHandler(this.txtSoyad_Click);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.LightGray;
            this.txtTel.ForeColor = System.Drawing.Color.Black;
            this.txtTel.Location = new System.Drawing.Point(440, 222);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(143, 27);
            this.txtTel.TabIndex = 17;
            this.txtTel.Text = "Telefon";
            this.txtTel.Click += new System.EventHandler(this.txtTel_Click);
            // 
            // txtTc
            // 
            this.txtTc.BackColor = System.Drawing.Color.LightGray;
            this.txtTc.ForeColor = System.Drawing.Color.Black;
            this.txtTc.Location = new System.Drawing.Point(440, 189);
            this.txtTc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTc.Multiline = true;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(143, 29);
            this.txtTc.TabIndex = 16;
            this.txtTc.Text = "Kimlik Numarası";
            this.txtTc.Click += new System.EventHandler(this.txtTc_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.LightGray;
            this.txtAdres.ForeColor = System.Drawing.Color.Black;
            this.txtAdres.Location = new System.Drawing.Point(440, 288);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(342, 39);
            this.txtAdres.TabIndex = 23;
            this.txtAdres.Text = "Adres";
            this.txtAdres.Click += new System.EventHandler(this.txtAdres_Click);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.LightGray;
            this.txtMail.ForeColor = System.Drawing.Color.Black;
            this.txtMail.Location = new System.Drawing.Point(440, 253);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(342, 31);
            this.txtMail.TabIndex = 22;
            this.txtMail.Text = "E-Mail";
            this.txtMail.Click += new System.EventHandler(this.txtMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(96, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "GİRİŞ YAP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(435, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "KAYIT OL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(840, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 39);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(218, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 32);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 477);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKulAdi);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.txtSifrekul);
            this.Controls.Add(this.txtGirisKul);
            this.Controls.Add(this.btnGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Giris";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtGirisKul;
        private System.Windows.Forms.TextBox txtSifrekul;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.TextBox txtKulAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

