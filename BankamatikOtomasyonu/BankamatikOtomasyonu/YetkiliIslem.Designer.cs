namespace BankamatikOtomasyonu
{
    partial class YetkiliIslem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz Sayın Admin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 476);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetkili İşlemleri";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Wheat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(151, 46);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(173, 54);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Müşteri Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Wheat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(151, 126);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(173, 55);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Müşteri Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Wheat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(151, 214);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(173, 55);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Müşteri Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Wheat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(151, 295);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(173, 54);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Müşteri Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Wheat;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(151, 378);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(173, 53);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Müşterileri Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Tomato;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.Location = new System.Drawing.Point(363, 584);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(153, 45);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // YetkiliIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 641);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "YetkiliIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili İşlemleri";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikis;
    }
}