
namespace HAMBURGERCİ
{
    partial class Form5
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
            this.lbxTümSiparisler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblToplamAdet = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEkstaMalzeme = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSatilanToplamUrun = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÜM SİPARİŞLER :";
            // 
            // lbxTümSiparisler
            // 
            this.lbxTümSiparisler.FormattingEnabled = true;
            this.lbxTümSiparisler.ItemHeight = 16;
            this.lbxTümSiparisler.Location = new System.Drawing.Point(15, 50);
            this.lbxTümSiparisler.Name = "lbxTümSiparisler";
            this.lbxTümSiparisler.Size = new System.Drawing.Size(409, 436);
            this.lbxTümSiparisler.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCiro);
            this.groupBox1.Location = new System.Drawing.Point(441, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciro ";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.ForeColor = System.Drawing.Color.Red;
            this.lblCiro.Location = new System.Drawing.Point(32, 40);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(36, 17);
            this.lblCiro.TabIndex = 0;
            this.lblCiro.Text = "0,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblToplamAdet);
            this.groupBox2.Location = new System.Drawing.Point(441, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam sipariş";
            // 
            // LblToplamAdet
            // 
            this.LblToplamAdet.AutoSize = true;
            this.LblToplamAdet.ForeColor = System.Drawing.Color.Red;
            this.LblToplamAdet.Location = new System.Drawing.Point(32, 41);
            this.LblToplamAdet.Name = "LblToplamAdet";
            this.LblToplamAdet.Size = new System.Drawing.Size(49, 17);
            this.LblToplamAdet.TabIndex = 0;
            this.LblToplamAdet.Text = "0 Adet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEkstaMalzeme);
            this.groupBox3.Location = new System.Drawing.Point(441, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estra Malzeme";
            // 
            // lblEkstaMalzeme
            // 
            this.lblEkstaMalzeme.AutoSize = true;
            this.lblEkstaMalzeme.ForeColor = System.Drawing.Color.Red;
            this.lblEkstaMalzeme.Location = new System.Drawing.Point(32, 39);
            this.lblEkstaMalzeme.Name = "lblEkstaMalzeme";
            this.lblEkstaMalzeme.Size = new System.Drawing.Size(36, 17);
            this.lblEkstaMalzeme.TabIndex = 0;
            this.lblEkstaMalzeme.Text = "0,00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSatilanToplamUrun);
            this.groupBox4.Location = new System.Drawing.Point(441, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satılan Ürün adedi";
            // 
            // lblSatilanToplamUrun
            // 
            this.lblSatilanToplamUrun.AutoSize = true;
            this.lblSatilanToplamUrun.ForeColor = System.Drawing.Color.Red;
            this.lblSatilanToplamUrun.Location = new System.Drawing.Point(32, 45);
            this.lblSatilanToplamUrun.Name = "lblSatilanToplamUrun";
            this.lblSatilanToplamUrun.Size = new System.Drawing.Size(53, 17);
            this.lblSatilanToplamUrun.TabIndex = 0;
            this.lblSatilanToplamUrun.Text = "0 Adet ";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 512);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxTümSiparisler);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxTümSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblToplamAdet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEkstaMalzeme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSatilanToplamUrun;
    }
}