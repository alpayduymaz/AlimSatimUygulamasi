
namespace AlımSatımUygulaması
{
    partial class SatisOnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisOnay));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.satisID = new System.Windows.Forms.Label();
            this.satisOnaybtn = new System.Windows.Forms.Button();
            this.eksilecekMiktarLabel = new System.Windows.Forms.Label();
            this.miktarLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.urunId = new System.Windows.Forms.Label();
            this.birimFiyatLabel = new System.Windows.Forms.Label();
            this.aliciKullaniciLabel = new System.Windows.Forms.Label();
            this.saticiKullaniciAdiLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.urunlerTableAdapter1 = new AlımSatımUygulaması.YazilimYapimiDatabaseDataSetTableAdapters.UrunlerTableAdapter();
            this.satisOnayBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // satisID
            // 
            this.satisID.AutoSize = true;
            this.satisID.BackColor = System.Drawing.Color.Transparent;
            this.satisID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisID.Location = new System.Drawing.Point(1325, 303);
            this.satisID.Name = "satisID";
            this.satisID.Size = new System.Drawing.Size(59, 20);
            this.satisID.TabIndex = 6;
            this.satisID.Text = "label1";
            this.satisID.Visible = false;
            // 
            // satisOnaybtn
            // 
            this.satisOnaybtn.BackColor = System.Drawing.Color.Transparent;
            this.satisOnaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisOnaybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisOnaybtn.ForeColor = System.Drawing.Color.Black;
            this.satisOnaybtn.Image = ((System.Drawing.Image)(resources.GetObject("satisOnaybtn.Image")));
            this.satisOnaybtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.satisOnaybtn.Location = new System.Drawing.Point(1311, 106);
            this.satisOnaybtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.satisOnaybtn.Name = "satisOnaybtn";
            this.satisOnaybtn.Size = new System.Drawing.Size(115, 112);
            this.satisOnaybtn.TabIndex = 7;
            this.satisOnaybtn.Text = "SATIŞI ONAYLA";
            this.satisOnaybtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.satisOnaybtn.UseVisualStyleBackColor = false;
            this.satisOnaybtn.Click += new System.EventHandler(this.satisOnaybtn_Click);
            // 
            // eksilecekMiktarLabel
            // 
            this.eksilecekMiktarLabel.AutoSize = true;
            this.eksilecekMiktarLabel.BackColor = System.Drawing.Color.Transparent;
            this.eksilecekMiktarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eksilecekMiktarLabel.Location = new System.Drawing.Point(1325, 440);
            this.eksilecekMiktarLabel.Name = "eksilecekMiktarLabel";
            this.eksilecekMiktarLabel.Size = new System.Drawing.Size(59, 20);
            this.eksilecekMiktarLabel.TabIndex = 8;
            this.eksilecekMiktarLabel.Text = "label1";
            this.eksilecekMiktarLabel.Visible = false;
            // 
            // miktarLabel
            // 
            this.miktarLabel.AutoSize = true;
            this.miktarLabel.BackColor = System.Drawing.Color.Transparent;
            this.miktarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarLabel.Location = new System.Drawing.Point(1325, 471);
            this.miktarLabel.Name = "miktarLabel";
            this.miktarLabel.Size = new System.Drawing.Size(59, 20);
            this.miktarLabel.TabIndex = 9;
            this.miktarLabel.Text = "label1";
            this.miktarLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(439, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "BEKLEYEN SATIŞ ONAYLARI";
            // 
            // urunId
            // 
            this.urunId.AutoSize = true;
            this.urunId.BackColor = System.Drawing.Color.Transparent;
            this.urunId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunId.Location = new System.Drawing.Point(1325, 338);
            this.urunId.Name = "urunId";
            this.urunId.Size = new System.Drawing.Size(59, 20);
            this.urunId.TabIndex = 12;
            this.urunId.Text = "label1";
            this.urunId.Visible = false;
            // 
            // birimFiyatLabel
            // 
            this.birimFiyatLabel.AutoSize = true;
            this.birimFiyatLabel.BackColor = System.Drawing.Color.Transparent;
            this.birimFiyatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimFiyatLabel.Location = new System.Drawing.Point(1325, 375);
            this.birimFiyatLabel.Name = "birimFiyatLabel";
            this.birimFiyatLabel.Size = new System.Drawing.Size(59, 20);
            this.birimFiyatLabel.TabIndex = 13;
            this.birimFiyatLabel.Text = "label1";
            this.birimFiyatLabel.Visible = false;
            // 
            // aliciKullaniciLabel
            // 
            this.aliciKullaniciLabel.AutoSize = true;
            this.aliciKullaniciLabel.BackColor = System.Drawing.Color.Transparent;
            this.aliciKullaniciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aliciKullaniciLabel.Location = new System.Drawing.Point(1325, 406);
            this.aliciKullaniciLabel.Name = "aliciKullaniciLabel";
            this.aliciKullaniciLabel.Size = new System.Drawing.Size(59, 20);
            this.aliciKullaniciLabel.TabIndex = 14;
            this.aliciKullaniciLabel.Text = "label1";
            this.aliciKullaniciLabel.Visible = false;
            // 
            // saticiKullaniciAdiLabel
            // 
            this.saticiKullaniciAdiLabel.AutoSize = true;
            this.saticiKullaniciAdiLabel.BackColor = System.Drawing.Color.Transparent;
            this.saticiKullaniciAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saticiKullaniciAdiLabel.Location = new System.Drawing.Point(1325, 505);
            this.saticiKullaniciAdiLabel.Name = "saticiKullaniciAdiLabel";
            this.saticiKullaniciAdiLabel.Size = new System.Drawing.Size(59, 20);
            this.saticiKullaniciAdiLabel.TabIndex = 15;
            this.saticiKullaniciAdiLabel.Text = "label1";
            this.saticiKullaniciAdiLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(428, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "GERCEKLEŞMİŞ OLAN SATIŞLAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 370);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1279, 181);
            this.dataGridView2.TabIndex = 16;
            // 
            // urunlerTableAdapter1
            // 
            this.urunlerTableAdapter1.ClearBeforeFill = true;
            // 
            // satisOnayBackBtn
            // 
            this.satisOnayBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.satisOnayBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisOnayBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisOnayBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("satisOnayBackBtn.Image")));
            this.satisOnayBackBtn.Location = new System.Drawing.Point(15, 9);
            this.satisOnayBackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.satisOnayBackBtn.Name = "satisOnayBackBtn";
            this.satisOnayBackBtn.Size = new System.Drawing.Size(103, 92);
            this.satisOnayBackBtn.TabIndex = 10;
            this.satisOnayBackBtn.UseVisualStyleBackColor = false;
            this.satisOnayBackBtn.Click += new System.EventHandler(this.satisOnayBackBtn_Click);
            // 
            // SatisOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1438, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.saticiKullaniciAdiLabel);
            this.Controls.Add(this.aliciKullaniciLabel);
            this.Controls.Add(this.birimFiyatLabel);
            this.Controls.Add(this.urunId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.satisOnayBackBtn);
            this.Controls.Add(this.miktarLabel);
            this.Controls.Add(this.eksilecekMiktarLabel);
            this.Controls.Add(this.satisOnaybtn);
            this.Controls.Add(this.satisID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SatisOnay";
            this.Text = "SatisOnay";
            this.Load += new System.EventHandler(this.SatisOnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label satisID;
        private System.Windows.Forms.Button satisOnaybtn;
        private System.Windows.Forms.Label eksilecekMiktarLabel;
        private System.Windows.Forms.Label miktarLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label urunId;
        private System.Windows.Forms.Label birimFiyatLabel;
        private System.Windows.Forms.Label aliciKullaniciLabel;
        private System.Windows.Forms.Label saticiKullaniciAdiLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private YazilimYapimiDatabaseDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter1;
        private System.Windows.Forms.Button satisOnayBackBtn;
    }
}