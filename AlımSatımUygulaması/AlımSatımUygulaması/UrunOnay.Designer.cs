
namespace AlımSatımUygulaması
{
    partial class UrunOnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunOnay));
            this.label1 = new System.Windows.Forms.Label();
            this.urunOnaybtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunID = new System.Windows.Forms.Label();
            this.urunOnayBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(494, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "BEKLEYEN URUN ONAYLARI";
            // 
            // urunOnaybtn
            // 
            this.urunOnaybtn.BackColor = System.Drawing.Color.Transparent;
            this.urunOnaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunOnaybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunOnaybtn.ForeColor = System.Drawing.Color.Black;
            this.urunOnaybtn.Image = ((System.Drawing.Image)(resources.GetObject("urunOnaybtn.Image")));
            this.urunOnaybtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.urunOnaybtn.Location = new System.Drawing.Point(1327, 137);
            this.urunOnaybtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunOnaybtn.Name = "urunOnaybtn";
            this.urunOnaybtn.Size = new System.Drawing.Size(115, 112);
            this.urunOnaybtn.TabIndex = 13;
            this.urunOnaybtn.Text = "URUNU ONAYLA";
            this.urunOnaybtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.urunOnaybtn.UseVisualStyleBackColor = false;
            this.urunOnaybtn.Click += new System.EventHandler(this.urunOnaybtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 200);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // urunID
            // 
            this.urunID.AutoSize = true;
            this.urunID.BackColor = System.Drawing.Color.Transparent;
            this.urunID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunID.Location = new System.Drawing.Point(707, 379);
            this.urunID.Name = "urunID";
            this.urunID.Size = new System.Drawing.Size(59, 20);
            this.urunID.TabIndex = 15;
            this.urunID.Text = "label1";
            this.urunID.Visible = false;
            // 
            // urunOnayBackBtn
            // 
            this.urunOnayBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.urunOnayBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunOnayBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunOnayBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("urunOnayBackBtn.Image")));
            this.urunOnayBackBtn.Location = new System.Drawing.Point(27, 21);
            this.urunOnayBackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunOnayBackBtn.Name = "urunOnayBackBtn";
            this.urunOnayBackBtn.Size = new System.Drawing.Size(103, 92);
            this.urunOnayBackBtn.TabIndex = 16;
            this.urunOnayBackBtn.UseVisualStyleBackColor = false;
            this.urunOnayBackBtn.Click += new System.EventHandler(this.urunOnayBackBtn_Click);
            // 
            // UrunOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 450);
            this.Controls.Add(this.urunOnayBackBtn);
            this.Controls.Add(this.urunID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunOnaybtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrunOnay";
            this.Text = "UrunOnay";
            this.Load += new System.EventHandler(this.UrunOnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button urunOnaybtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label urunID;
        private System.Windows.Forms.Button urunOnayBackBtn;
    }
}