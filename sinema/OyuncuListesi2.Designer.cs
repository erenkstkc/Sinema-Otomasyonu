﻿namespace sinema
{
    partial class OyuncuListesi2
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.pbResimDetay = new System.Windows.Forms.PictureBox();
            this.btnResimyukle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbResimDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Teal;
            this.lblAdSoyad.Location = new System.Drawing.Point(130, 18);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(101, 32);
            this.lblAdSoyad.TabIndex = 5;
            this.lblAdSoyad.Text = "label1";
            // 
            // pbResimDetay
            // 
            this.pbResimDetay.Location = new System.Drawing.Point(11, 3);
            this.pbResimDetay.Name = "pbResimDetay";
            this.pbResimDetay.Size = new System.Drawing.Size(103, 106);
            this.pbResimDetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResimDetay.TabIndex = 6;
            this.pbResimDetay.TabStop = false;
            // 
            // btnResimyukle
            // 
            this.btnResimyukle.BackColor = System.Drawing.Color.Gray;
            this.btnResimyukle.FlatAppearance.BorderSize = 0;
            this.btnResimyukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResimyukle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btnResimyukle.ForeColor = System.Drawing.Color.White;
            this.btnResimyukle.Location = new System.Drawing.Point(448, 80);
            this.btnResimyukle.Name = "btnResimyukle";
            this.btnResimyukle.Size = new System.Drawing.Size(114, 32);
            this.btnResimyukle.TabIndex = 8;
            this.btnResimyukle.Text = "DETAY";
            this.btnResimyukle.UseVisualStyleBackColor = false;
            this.btnResimyukle.Click += new System.EventHandler(this.btnResimyukle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 112);
            this.panel1.TabIndex = 9;
            // 
            // OyuncuListesi2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnResimyukle);
            this.Controls.Add(this.pbResimDetay);
            this.Controls.Add(this.lblAdSoyad);
            this.Name = "OyuncuListesi2";
            this.Size = new System.Drawing.Size(562, 112);
            ((System.ComponentModel.ISupportInitialize)(this.pbResimDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.PictureBox pbResimDetay;
        private System.Windows.Forms.Button btnResimyukle;
        private System.Windows.Forms.Panel panel1;
    }
}
