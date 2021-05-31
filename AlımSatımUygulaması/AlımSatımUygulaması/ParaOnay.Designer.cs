
namespace AlımSatımUygulaması
{
    partial class ParaOnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaOnay));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciLabel = new System.Windows.Forms.Label();
            this.eklenecekBakiye_label = new System.Windows.Forms.Label();
            this.paraonayBtn = new System.Windows.Forms.Button();
            this.paraOnayBackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 144);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kullaniciLabel
            // 
            this.kullaniciLabel.AutoSize = true;
            this.kullaniciLabel.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciLabel.Location = new System.Drawing.Point(1302, 315);
            this.kullaniciLabel.Name = "kullaniciLabel";
            this.kullaniciLabel.Size = new System.Drawing.Size(60, 24);
            this.kullaniciLabel.TabIndex = 4;
            this.kullaniciLabel.Text = "label1";
            this.kullaniciLabel.Visible = false;
            // 
            // eklenecekBakiye_label
            // 
            this.eklenecekBakiye_label.AutoSize = true;
            this.eklenecekBakiye_label.BackColor = System.Drawing.Color.Transparent;
            this.eklenecekBakiye_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklenecekBakiye_label.Location = new System.Drawing.Point(1302, 363);
            this.eklenecekBakiye_label.Name = "eklenecekBakiye_label";
            this.eklenecekBakiye_label.Size = new System.Drawing.Size(60, 24);
            this.eklenecekBakiye_label.TabIndex = 5;
            this.eklenecekBakiye_label.Text = "label1";
            this.eklenecekBakiye_label.Visible = false;
            // 
            // paraonayBtn
            // 
            this.paraonayBtn.BackColor = System.Drawing.Color.Transparent;
            this.paraonayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paraonayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paraonayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paraonayBtn.ForeColor = System.Drawing.Color.Black;
            this.paraonayBtn.Image = ((System.Drawing.Image)(resources.GetObject("paraonayBtn.Image")));
            this.paraonayBtn.Location = new System.Drawing.Point(1233, 144);
            this.paraonayBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paraonayBtn.Name = "paraonayBtn";
            this.paraonayBtn.Size = new System.Drawing.Size(197, 149);
            this.paraonayBtn.TabIndex = 6;
            this.paraonayBtn.Text = "PARAYI ONAYLA";
            this.paraonayBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.paraonayBtn.UseVisualStyleBackColor = false;
            this.paraonayBtn.Click += new System.EventHandler(this.paraonayBtn_Click);
            // 
            // paraOnayBackBtn
            // 
            this.paraOnayBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.paraOnayBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paraOnayBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("paraOnayBackBtn.Image")));
            this.paraOnayBackBtn.Location = new System.Drawing.Point(15, 14);
            this.paraOnayBackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paraOnayBackBtn.Name = "paraOnayBackBtn";
            this.paraOnayBackBtn.Size = new System.Drawing.Size(96, 90);
            this.paraOnayBackBtn.TabIndex = 11;
            this.paraOnayBackBtn.UseVisualStyleBackColor = false;
            this.paraOnayBackBtn.Click += new System.EventHandler(this.paraOnayBackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(452, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "BEKLEYEN PARA ONAYLARI";
            // 
            // ParaOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paraOnayBackBtn);
            this.Controls.Add(this.paraonayBtn);
            this.Controls.Add(this.eklenecekBakiye_label);
            this.Controls.Add(this.kullaniciLabel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ParaOnay";
            this.Text = "ParaOnay";
            this.Load += new System.EventHandler(this.ParaOnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label kullaniciLabel;
        private System.Windows.Forms.Label eklenecekBakiye_label;
        private System.Windows.Forms.Button paraonayBtn;
        private System.Windows.Forms.Button paraOnayBackBtn;
        private System.Windows.Forms.Label label1;
    }
}