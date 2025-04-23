namespace YurtKayitSistemi
{
    partial class frmOgrDuzenle
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOgrenciDuzenle = new System.Windows.Forms.Button();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.mskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.mskDogumTarhi = new System.Windows.Forms.MaskedTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.mskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtOgrID = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Heading", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(48, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Öğrenci İd:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btnOgrenciDuzenle
            // 
            this.btnOgrenciDuzenle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOgrenciDuzenle.Location = new System.Drawing.Point(103, 611);
            this.btnOgrenciDuzenle.Name = "btnOgrenciDuzenle";
            this.btnOgrenciDuzenle.Size = new System.Drawing.Size(107, 31);
            this.btnOgrenciDuzenle.TabIndex = 50;
            this.btnOgrenciDuzenle.Text = "Güncelle";
            this.btnOgrenciDuzenle.UseVisualStyleBackColor = false;
            this.btnOgrenciDuzenle.Click += new System.EventHandler(this.btnOgrenciDuzenle_Click);
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(147, 500);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(202, 96);
            this.rchAdres.TabIndex = 49;
            this.rchAdres.Text = "";
            // 
            // mskVeliTelefon
            // 
            this.mskVeliTelefon.Location = new System.Drawing.Point(147, 451);
            this.mskVeliTelefon.Mask = "(999) 000-0000";
            this.mskVeliTelefon.Name = "mskVeliTelefon";
            this.mskVeliTelefon.Size = new System.Drawing.Size(191, 22);
            this.mskVeliTelefon.TabIndex = 48;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(50, 457);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(73, 16);
            this.labelControl11.TabIndex = 47;
            this.labelControl11.Text = "Veli Telefon:";
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(147, 411);
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(191, 22);
            this.txtVeliAdSoyad.TabIndex = 46;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(48, 417);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(84, 16);
            this.labelControl10.TabIndex = 45;
            this.labelControl10.Text = "Veli Ad Soyad:";
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(147, 370);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(191, 24);
            this.cmbOdaNo.TabIndex = 44;
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(147, 275);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(191, 24);
            this.cmbBolum.TabIndex = 43;
            // 
            // mskDogumTarhi
            // 
            this.mskDogumTarhi.Location = new System.Drawing.Point(147, 229);
            this.mskDogumTarhi.Mask = "00/00/0000";
            this.mskDogumTarhi.Name = "mskDogumTarhi";
            this.mskDogumTarhi.Size = new System.Drawing.Size(191, 22);
            this.mskDogumTarhi.TabIndex = 42;
            this.mskDogumTarhi.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(44, 235);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(82, 16);
            this.labelControl9.TabIndex = 41;
            this.labelControl9.Text = "Doğum Tarihi:";
            // 
            // mskOgrTelefon
            // 
            this.mskOgrTelefon.Location = new System.Drawing.Point(147, 186);
            this.mskOgrTelefon.Mask = "(999) 000-0000";
            this.mskOgrTelefon.Name = "mskOgrTelefon";
            this.mskOgrTelefon.Size = new System.Drawing.Size(191, 22);
            this.mskOgrTelefon.TabIndex = 40;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(78, 192);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 16);
            this.labelControl8.TabIndex = 39;
            this.labelControl8.Text = "Telefon:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(147, 144);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(191, 22);
            this.mskTc.TabIndex = 38;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(92, 329);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 16);
            this.labelControl7.TabIndex = 37;
            this.labelControl7.Text = "Mail:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(35, 283);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(88, 16);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Öğrenci Bölüm:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(147, 323);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(191, 22);
            this.txtMail.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(88, 512);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 16);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Adres:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(76, 378);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 16);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Oda No:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(94, 150);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(21, 16);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "TC:";
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(147, 106);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(191, 22);
            this.txtOgrSoyad.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 109);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 16);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Öğrenci Soyadı:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(147, 59);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(191, 22);
            this.txtOgrAd.TabIndex = 29;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(49, 62);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(71, 16);
            this.labelControl12.TabIndex = 28;
            this.labelControl12.Text = "Öğrenci Adı:";
            // 
            // txtOgrID
            // 
            this.txtOgrID.Location = new System.Drawing.Point(147, 12);
            this.txtOgrID.Name = "txtOgrID";
            this.txtOgrID.Size = new System.Drawing.Size(191, 22);
            this.txtOgrID.TabIndex = 52;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Location = new System.Drawing.Point(242, 611);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 31);
            this.btnSil.TabIndex = 53;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmOgrDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(439, 654);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtOgrID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOgrenciDuzenle);
            this.Controls.Add(this.rchAdres);
            this.Controls.Add(this.mskVeliTelefon);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtVeliAdSoyad);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.mskDogumTarhi);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.mskOgrTelefon);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Düzenle";
            this.Load += new System.EventHandler(this.frmOgrDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrenciDuzenle;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.MaskedTextBox mskVeliTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.MaskedTextBox mskDogumTarhi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.MaskedTextBox mskOgrTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtOgrAd;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.TextBox txtOgrID;
        private System.Windows.Forms.Button btnSil;
    }
}