
namespace HAMBURGERCİ
{
    partial class Form4
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
            this.btnEkstraMalzeme = new System.Windows.Forms.Button();
            this.nmrEkstraMalzemeFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzeme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkstraMalzeme);
            this.groupBox1.Controls.Add(this.nmrEkstraMalzemeFiyat);
            this.groupBox1.Controls.Add(this.txtEkstraMalzeme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EsktraMalzemeBilgileri";
            // 
            // btnEkstraMalzeme
            // 
            this.btnEkstraMalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEkstraMalzeme.Location = new System.Drawing.Point(146, 113);
            this.btnEkstraMalzeme.Name = "btnEkstraMalzeme";
            this.btnEkstraMalzeme.Size = new System.Drawing.Size(198, 39);
            this.btnEkstraMalzeme.TabIndex = 3;
            this.btnEkstraMalzeme.Text = "Esktra Malzeme Kaydet";
            this.btnEkstraMalzeme.UseVisualStyleBackColor = true;
            this.btnEkstraMalzeme.Click += new System.EventHandler(this.btnEkstraMalzeme_Click);
            // 
            // nmrEkstraMalzemeFiyat
            // 
            this.nmrEkstraMalzemeFiyat.DecimalPlaces = 2;
            this.nmrEkstraMalzemeFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.nmrEkstraMalzemeFiyat.Location = new System.Drawing.Point(146, 75);
            this.nmrEkstraMalzemeFiyat.Name = "nmrEkstraMalzemeFiyat";
            this.nmrEkstraMalzemeFiyat.Size = new System.Drawing.Size(310, 23);
            this.nmrEkstraMalzemeFiyat.TabIndex = 2;
            // 
            // txtEkstraMalzeme
            // 
            this.txtEkstraMalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtEkstraMalzeme.Location = new System.Drawing.Point(146, 36);
            this.txtEkstraMalzeme.Name = "txtEkstraMalzeme";
            this.txtEkstraMalzeme.Size = new System.Drawing.Size(310, 23);
            this.txtEkstraMalzeme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(90, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(0, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esktra Malzeme Adı :";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 203);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkstraMalzeme;
        private System.Windows.Forms.NumericUpDown nmrEkstraMalzemeFiyat;
        private System.Windows.Forms.TextBox txtEkstraMalzeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}