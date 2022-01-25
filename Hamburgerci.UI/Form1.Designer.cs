
namespace Hamburgerci.UI
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.grpBoyut = new System.Windows.Forms.GroupBox();
            this.rdoKucuk = new System.Windows.Forms.RadioButton();
            this.rdoOrta = new System.Windows.Forms.RadioButton();
            this.rdoBuyuk = new System.Windows.Forms.RadioButton();
            this.flpMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hamburgerci.UI.Properties.Resources.hamburger_resim;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü Seçiniz:";
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(14, 209);
            this.cmbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(215, 24);
            this.cmbMenu.TabIndex = 2;
            // 
            // grpBoyut
            // 
            this.grpBoyut.Controls.Add(this.rdoKucuk);
            this.grpBoyut.Controls.Add(this.rdoOrta);
            this.grpBoyut.Controls.Add(this.rdoBuyuk);
            this.grpBoyut.Location = new System.Drawing.Point(16, 241);
            this.grpBoyut.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoyut.Name = "grpBoyut";
            this.grpBoyut.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoyut.Size = new System.Drawing.Size(213, 61);
            this.grpBoyut.TabIndex = 3;
            this.grpBoyut.TabStop = false;
            this.grpBoyut.Text = "Boyut Seçiniz:";
            // 
            // rdoKucuk
            // 
            this.rdoKucuk.AutoSize = true;
            this.rdoKucuk.Location = new System.Drawing.Point(140, 25);
            this.rdoKucuk.Margin = new System.Windows.Forms.Padding(4);
            this.rdoKucuk.Name = "rdoKucuk";
            this.rdoKucuk.Size = new System.Drawing.Size(65, 21);
            this.rdoKucuk.TabIndex = 2;
            this.rdoKucuk.TabStop = true;
            this.rdoKucuk.Text = "Küçük";
            this.rdoKucuk.UseVisualStyleBackColor = true;
            // 
            // rdoOrta
            // 
            this.rdoOrta.AutoSize = true;
            this.rdoOrta.Location = new System.Drawing.Point(79, 25);
            this.rdoOrta.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOrta.Name = "rdoOrta";
            this.rdoOrta.Size = new System.Drawing.Size(53, 21);
            this.rdoOrta.TabIndex = 1;
            this.rdoOrta.TabStop = true;
            this.rdoOrta.Text = "Orta";
            this.rdoOrta.UseVisualStyleBackColor = true;
            // 
            // rdoBuyuk
            // 
            this.rdoBuyuk.AutoSize = true;
            this.rdoBuyuk.Location = new System.Drawing.Point(7, 23);
            this.rdoBuyuk.Margin = new System.Windows.Forms.Padding(4);
            this.rdoBuyuk.Name = "rdoBuyuk";
            this.rdoBuyuk.Size = new System.Drawing.Size(65, 21);
            this.rdoBuyuk.TabIndex = 0;
            this.rdoBuyuk.TabStop = true;
            this.rdoBuyuk.Text = "Büyük";
            this.rdoBuyuk.UseVisualStyleBackColor = true;
            // 
            // flpMalzemeler
            // 
            this.flpMalzemeler.Location = new System.Drawing.Point(17, 327);
            this.flpMalzemeler.Margin = new System.Windows.Forms.Padding(4);
            this.flpMalzemeler.Name = "flpMalzemeler";
            this.flpMalzemeler.Size = new System.Drawing.Size(213, 301);
            this.flpMalzemeler.TabIndex = 4;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(69, 636);
            this.nmrAdet.Margin = new System.Windows.Forms.Padding(4);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(160, 24);
            this.nmrAdet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ekstra Malzemeler:";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(13, 679);
            this.btnSiparisEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(216, 58);
            this.btnSiparisEkle.TabIndex = 7;
            this.btnSiparisEkle.Text = "SİPARİŞİ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.ItemHeight = 16;
            this.lbxSiparisler.Location = new System.Drawing.Point(237, 14);
            this.lbxSiparisler.Margin = new System.Windows.Forms.Padding(4);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(760, 612);
            this.lbxSiparisler.TabIndex = 8;
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(778, 679);
            this.btnSiparisiTamamla.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(216, 58);
            this.btnSiparisiTamamla.TabIndex = 9;
            this.btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 638);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 679);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Toplam Tutar:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamTutar.Location = new System.Drawing.Point(447, 679);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(39, 19);
            this.lblToplamTutar.TabIndex = 12;
            this.lblToplamTutar.Text = "0 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 744);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.flpMalzemeler);
            this.Controls.Add(this.grpBoyut);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoyut.ResumeLayout(false);
            this.grpBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.GroupBox grpBoyut;
        private System.Windows.Forms.RadioButton rdoKucuk;
        private System.Windows.Forms.RadioButton rdoOrta;
        private System.Windows.Forms.RadioButton rdoBuyuk;
        private System.Windows.Forms.FlowLayoutPanel flpMalzemeler;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.ListBox lbxSiparisler;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}

