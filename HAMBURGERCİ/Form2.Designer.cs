
namespace HAMBURGERCİ
{
    partial class Form2
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
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.grbBoyutlar = new System.Windows.Forms.GroupBox();
            this.rdbBuyuk = new System.Windows.Forms.RadioButton();
            this.rdbOrta = new System.Windows.Forms.RadioButton();
            this.rdbKucuk = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flpEkstraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.grbBoyutlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(-2, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Seçiniz :";
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(3, 280);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(306, 24);
            this.cmbMenuler.TabIndex = 2;
            this.cmbMenuler.SelectedIndexChanged += new System.EventHandler(this.cmbMenuler_SelectedIndexChanged);
            // 
            // grbBoyutlar
            // 
            this.grbBoyutlar.Controls.Add(this.rdbBuyuk);
            this.grbBoyutlar.Controls.Add(this.rdbOrta);
            this.grbBoyutlar.Controls.Add(this.rdbKucuk);
            this.grbBoyutlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.grbBoyutlar.Location = new System.Drawing.Point(3, 331);
            this.grbBoyutlar.Name = "grbBoyutlar";
            this.grbBoyutlar.Size = new System.Drawing.Size(306, 75);
            this.grbBoyutlar.TabIndex = 3;
            this.grbBoyutlar.TabStop = false;
            this.grbBoyutlar.Text = "Boyut Seçiniz : ";
            // 
            // rdbBuyuk
            // 
            this.rdbBuyuk.AutoSize = true;
            this.rdbBuyuk.Location = new System.Drawing.Point(201, 29);
            this.rdbBuyuk.Name = "rdbBuyuk";
            this.rdbBuyuk.Size = new System.Drawing.Size(88, 29);
            this.rdbBuyuk.TabIndex = 0;
            this.rdbBuyuk.TabStop = true;
            this.rdbBuyuk.Text = "Büyük";
            this.rdbBuyuk.UseVisualStyleBackColor = true;
            this.rdbBuyuk.CheckedChanged += new System.EventHandler(this.rdbBuyuk_CheckedChanged);
            // 
            // rdbOrta
            // 
            this.rdbOrta.AutoSize = true;
            this.rdbOrta.Location = new System.Drawing.Point(124, 29);
            this.rdbOrta.Name = "rdbOrta";
            this.rdbOrta.Size = new System.Drawing.Size(71, 29);
            this.rdbOrta.TabIndex = 0;
            this.rdbOrta.TabStop = true;
            this.rdbOrta.Text = "Orta";
            this.rdbOrta.UseVisualStyleBackColor = true;
            this.rdbOrta.CheckedChanged += new System.EventHandler(this.rdbOrta_CheckedChanged);
            // 
            // rdbKucuk
            // 
            this.rdbKucuk.AutoSize = true;
            this.rdbKucuk.Location = new System.Drawing.Point(21, 29);
            this.rdbKucuk.Name = "rdbKucuk";
            this.rdbKucuk.Size = new System.Drawing.Size(89, 29);
            this.rdbKucuk.TabIndex = 0;
            this.rdbKucuk.TabStop = true;
            this.rdbKucuk.Text = "Küçük";
            this.rdbKucuk.UseVisualStyleBackColor = true;
            this.rdbKucuk.CheckedChanged += new System.EventHandler(this.rdbKucuk_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(-3, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Malzeme Seçiniz :";
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(12, 454);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(331, 211);
            this.flpEkstraMalzemeler.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(7, 668);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adet :";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(74, 673);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(269, 22);
            this.nmrAdet.TabIndex = 5;
            this.nmrAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSiparisEkle.Location = new System.Drawing.Point(81, 707);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(239, 39);
            this.btnSiparisEkle.TabIndex = 6;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.ItemHeight = 16;
            this.lbxSiparisler.Location = new System.Drawing.Point(349, 17);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(642, 676);
            this.lbxSiparisler.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(344, 721);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Tutar :";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplamTutar.Location = new System.Drawing.Point(511, 722);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(23, 25);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "0";
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSiparisTamamla.Location = new System.Drawing.Point(557, 715);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(209, 40);
            this.btnSiparisTamamla.TabIndex = 8;
            this.btnSiparisTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::HAMBURGERCİ.Properties.Resources._33027976;
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(308, 202);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 963);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.flpEkstraMalzemeler);
            this.Controls.Add(this.grbBoyutlar);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxLogo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grbBoyutlar.ResumeLayout(false);
            this.grbBoyutlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbBoyutlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpEkstraMalzemeler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisTamamla;
        public System.Windows.Forms.ComboBox cmbMenuler;
        public System.Windows.Forms.RadioButton rdbBuyuk;
        public System.Windows.Forms.RadioButton rdbOrta;
        public System.Windows.Forms.RadioButton rdbKucuk;
        public System.Windows.Forms.NumericUpDown nmrAdet;
        public System.Windows.Forms.ListBox lbxSiparisler;
    }
}