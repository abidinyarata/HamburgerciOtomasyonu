
namespace Hamburgerci.UI
{
    partial class Form3
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
            this.grpMalzemeEkle = new System.Windows.Forms.GroupBox();
            this.btnMalzemeKaydet = new System.Windows.Forms.Button();
            this.nmrEkstraMalzemeFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMalzemeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMalzemeEkle
            // 
            this.grpMalzemeEkle.Controls.Add(this.btnMalzemeKaydet);
            this.grpMalzemeEkle.Controls.Add(this.nmrEkstraMalzemeFiyati);
            this.grpMalzemeEkle.Controls.Add(this.txtEkstraMalzemeAdi);
            this.grpMalzemeEkle.Controls.Add(this.label2);
            this.grpMalzemeEkle.Controls.Add(this.label1);
            this.grpMalzemeEkle.Location = new System.Drawing.Point(14, 16);
            this.grpMalzemeEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMalzemeEkle.Name = "grpMalzemeEkle";
            this.grpMalzemeEkle.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMalzemeEkle.Size = new System.Drawing.Size(350, 260);
            this.grpMalzemeEkle.TabIndex = 1;
            this.grpMalzemeEkle.TabStop = false;
            this.grpMalzemeEkle.Text = "Ekstra Malzeme";
            // 
            // btnMalzemeKaydet
            // 
            this.btnMalzemeKaydet.Location = new System.Drawing.Point(144, 176);
            this.btnMalzemeKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnMalzemeKaydet.Name = "btnMalzemeKaydet";
            this.btnMalzemeKaydet.Size = new System.Drawing.Size(198, 63);
            this.btnMalzemeKaydet.TabIndex = 4;
            this.btnMalzemeKaydet.Text = "KAYDET";
            this.btnMalzemeKaydet.UseVisualStyleBackColor = true;
            this.btnMalzemeKaydet.Click += new System.EventHandler(this.btnMalzemeKaydet_Click);
            // 
            // nmrEkstraMalzemeFiyati
            // 
            this.nmrEkstraMalzemeFiyati.Location = new System.Drawing.Point(144, 127);
            this.nmrEkstraMalzemeFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.nmrEkstraMalzemeFiyati.Name = "nmrEkstraMalzemeFiyati";
            this.nmrEkstraMalzemeFiyati.Size = new System.Drawing.Size(198, 24);
            this.nmrEkstraMalzemeFiyati.TabIndex = 3;
            // 
            // txtEkstraMalzemeAdi
            // 
            this.txtEkstraMalzemeAdi.Location = new System.Drawing.Point(144, 64);
            this.txtEkstraMalzemeAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            this.txtEkstraMalzemeAdi.Size = new System.Drawing.Size(198, 24);
            this.txtEkstraMalzemeAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 286);
            this.Controls.Add(this.grpMalzemeEkle);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grpMalzemeEkle.ResumeLayout(false);
            this.grpMalzemeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMalzemeEkle;
        private System.Windows.Forms.Button btnMalzemeKaydet;
        private System.Windows.Forms.NumericUpDown nmrEkstraMalzemeFiyati;
        private System.Windows.Forms.TextBox txtEkstraMalzemeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}