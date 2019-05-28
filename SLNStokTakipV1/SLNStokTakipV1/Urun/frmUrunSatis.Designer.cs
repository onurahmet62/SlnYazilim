namespace SLNStokTakipV1.Urun
{
    partial class frmUrunSatis
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAcik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nott = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.urncmb = new System.Windows.Forms.ComboBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtYazi = new System.Windows.Forms.TextBox();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.txtAraToplam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTarih = new System.Windows.Forms.DateTimePicker();
            this.lblVd = new System.Windows.Forms.Label();
            this.lblVno = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFUnvan = new System.Windows.Forms.Label();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.txtFno = new System.Windows.Forms.TextBox();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.txtGenelNo = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCollapse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel2.Controls.Add(this.txtGenelNo);
            this.splitContainer1.Panel2.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Size = new System.Drawing.Size(683, 393);
            this.splitContainer1.SplitterDistance = 481;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ukod,
            this.Lot,
            this.UAcik,
            this.Adet,
            this.Bfiyat,
            this.Tfiyat,
            this.Nott,
            this.UrunNo});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 89);
            this.Liste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Liste.Name = "Liste";
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(457, 185);
            this.Liste.TabIndex = 4;
            this.Liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEndEdit);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Ukod
            // 
            this.Ukod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ukod.HeaderText = "Ürün Kodu";
            this.Ukod.Name = "Ukod";
            // 
            // Lot
            // 
            this.Lot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Lot.HeaderText = "Lot";
            this.Lot.Name = "Lot";
            this.Lot.Width = 47;
            // 
            // UAcik
            // 
            this.UAcik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UAcik.HeaderText = "Aciklama";
            this.UAcik.Name = "UAcik";
            this.UAcik.Width = 75;
            // 
            // Adet
            // 
            this.Adet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.Width = 54;
            // 
            // Bfiyat
            // 
            this.Bfiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Bfiyat.HeaderText = "Birim Fiyat";
            this.Bfiyat.Name = "Bfiyat";
            this.Bfiyat.Width = 79;
            // 
            // Tfiyat
            // 
            this.Tfiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tfiyat.HeaderText = "Toplam Fiyat";
            this.Tfiyat.Name = "Tfiyat";
            this.Tfiyat.Width = 92;
            // 
            // Nott
            // 
            this.Nott.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nott.HeaderText = "Not";
            this.Nott.Name = "Nott";
            this.Nott.Width = 49;
            // 
            // UrunNo
            // 
            this.UrunNo.HeaderText = "Ürün No";
            this.UrunNo.Name = "UrunNo";
            this.UrunNo.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.urncmb);
            this.panel2.Controls.Add(this.btnYazdir);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.txtYazi);
            this.panel2.Controls.Add(this.txtGenelToplam);
            this.panel2.Controls.Add(this.txtKdv);
            this.panel2.Controls.Add(this.txtAraToplam);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 274);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 115);
            this.panel2.TabIndex = 3;
            // 
            // urncmb
            // 
            this.urncmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.urncmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.urncmb.FormattingEnabled = true;
            this.urncmb.Location = new System.Drawing.Point(64, 5);
            this.urncmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.urncmb.Name = "urncmb";
            this.urncmb.Size = new System.Drawing.Size(70, 21);
            this.urncmb.TabIndex = 7;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.OrangeRed;
            this.btnYazdir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(398, 0);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(59, 115);
            this.btnYazdir.TabIndex = 6;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(0, 0);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(59, 115);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // txtYazi
            // 
            this.txtYazi.Location = new System.Drawing.Point(68, 89);
            this.txtYazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(368, 20);
            this.txtYazi.TabIndex = 0;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Location = new System.Drawing.Point(368, 52);
            this.txtGenelToplam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(68, 20);
            this.txtGenelToplam.TabIndex = 0;
            this.txtGenelToplam.TextChanged += new System.EventHandler(this.txtGenelToplam_TextChanged);
            // 
            // txtKdv
            // 
            this.txtKdv.Location = new System.Drawing.Point(368, 29);
            this.txtKdv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(68, 20);
            this.txtKdv.TabIndex = 0;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Location = new System.Drawing.Point(368, 6);
            this.txtAraToplam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Size = new System.Drawing.Size(68, 20);
            this.txtAraToplam.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(268, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Genel Toplam :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(268, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kdv :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(268, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ara Toplam :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtTarih);
            this.panel1.Controls.Add(this.lblVd);
            this.panel1.Controls.Add(this.lblVno);
            this.panel1.Controls.Add(this.lblAdres);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAcik);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFUnvan);
            this.panel1.Controls.Add(this.txtSaat);
            this.panel1.Controls.Add(this.txtFno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 89);
            this.panel1.TabIndex = 3;
            // 
            // txtTarih
            // 
            this.txtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTarih.Location = new System.Drawing.Point(68, 33);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(120, 20);
            this.txtTarih.TabIndex = 2;
            // 
            // lblVd
            // 
            this.lblVd.BackColor = System.Drawing.Color.Azure;
            this.lblVd.Location = new System.Drawing.Point(369, 11);
            this.lblVd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVd.Name = "lblVd";
            this.lblVd.Size = new System.Drawing.Size(111, 15);
            this.lblVd.TabIndex = 1;
            this.lblVd.Text = "V.Dairesi";
            // 
            // lblVno
            // 
            this.lblVno.BackColor = System.Drawing.Color.Azure;
            this.lblVno.Location = new System.Drawing.Point(369, 33);
            this.lblVno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVno.Name = "lblVno";
            this.lblVno.Size = new System.Drawing.Size(111, 15);
            this.lblVno.TabIndex = 1;
            this.lblVno.Text = "Vergi No";
            // 
            // lblAdres
            // 
            this.lblAdres.BackColor = System.Drawing.Color.Azure;
            this.lblAdres.Location = new System.Drawing.Point(191, 33);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(172, 32);
            this.lblAdres.TabIndex = 1;
            this.lblAdres.Text = "Adres";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(2, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Saat :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih :";
            // 
            // txtAcik
            // 
            this.txtAcik.Location = new System.Drawing.Point(368, 58);
            this.txtAcik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAcik.Name = "txtAcik";
            this.txtAcik.Size = new System.Drawing.Size(114, 20);
            this.txtAcik.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firma No :";
            // 
            // lblFUnvan
            // 
            this.lblFUnvan.BackColor = System.Drawing.Color.Azure;
            this.lblFUnvan.Location = new System.Drawing.Point(191, 11);
            this.lblFUnvan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFUnvan.Name = "lblFUnvan";
            this.lblFUnvan.Size = new System.Drawing.Size(172, 15);
            this.lblFUnvan.TabIndex = 1;
            this.lblFUnvan.Text = "F.Unvan";
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(68, 56);
            this.txtSaat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(56, 20);
            this.txtSaat.TabIndex = 0;
            // 
            // txtFno
            // 
            this.txtFno.Location = new System.Drawing.Point(68, 10);
            this.txtFno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFno.Name = "txtFno";
            this.txtFno.Size = new System.Drawing.Size(120, 20);
            this.txtFno.TabIndex = 0;
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCollapse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCollapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCollapse.ForeColor = System.Drawing.Color.White;
            this.btnCollapse.Location = new System.Drawing.Point(457, 0);
            this.btnCollapse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(20, 389);
            this.btnCollapse.TabIndex = 2;
            this.btnCollapse.Text = "GİZLE";
            this.btnCollapse.UseVisualStyleBackColor = false;
            // 
            // txtGenelNo
            // 
            this.txtGenelNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGenelNo.Location = new System.Drawing.Point(0, 48);
            this.txtGenelNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGenelNo.Name = "txtGenelNo";
            this.txtGenelNo.Size = new System.Drawing.Size(195, 20);
            this.txtGenelNo.TabIndex = 2;
            this.txtGenelNo.Text = "***";
            this.txtGenelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(0, 347);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(195, 42);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.Silver;
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(195, 48);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmUrunSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 393);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUrunSatis";
            this.Text = "frmUrunSatis";
            this.Load += new System.EventHandler(this.frmUrunSatis_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox txtGenelNo;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.TextBox txtFno;
        private System.Windows.Forms.Label lblVd;
        private System.Windows.Forms.Label lblVno;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblFUnvan;
        private System.Windows.Forms.DateTimePicker txtTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.ComboBox urncmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAcik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bfiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tfiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nott;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunNo;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.TextBox txtAraToplam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYazi;
        private System.Windows.Forms.TextBox txtAcik;
    }
}