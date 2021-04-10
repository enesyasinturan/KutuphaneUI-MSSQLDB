
namespace KutuphaneUI.Sayfalar
{
    partial class Kitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplar));
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.ButtonKitaplarGuncelle = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerKitaplarBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.labelBaslamaTarihi = new System.Windows.Forms.Label();
            this.labelFormGirisPanelCizgi1 = new System.Windows.Forms.Label();
            this.textBoxKitaplarKitapAdi = new System.Windows.Forms.TextBox();
            this.labelKitapAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKitaplarYazarAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKitaplarYayineviAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownKitaplarSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSayfaSayisi = new System.Windows.Forms.Label();
            this.ButtonKitaplarTemizle = new FontAwesome.Sharp.IconButton();
            this.ButtonKitaplarSil = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerKitaplarBasimYili = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBasimYili = new System.Windows.Forms.Label();
            this.dateTimePickerKitaplarBitirmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKitaplarSayfaSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AllowUserToAddRows = false;
            this.dataGridViewKitaplar.AllowUserToDeleteRows = false;
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKitaplar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKitaplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(7, 15);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.ReadOnly = true;
            this.dataGridViewKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(910, 199);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellDoubleClick);
            // 
            // ButtonKitaplarGuncelle
            // 
            this.ButtonKitaplarGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonKitaplarGuncelle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonKitaplarGuncelle.FlatAppearance.BorderSize = 0;
            this.ButtonKitaplarGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonKitaplarGuncelle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonKitaplarGuncelle.ForeColor = System.Drawing.Color.GhostWhite;
            this.ButtonKitaplarGuncelle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonKitaplarGuncelle.IconColor = System.Drawing.Color.Black;
            this.ButtonKitaplarGuncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonKitaplarGuncelle.Location = new System.Drawing.Point(358, 467);
            this.ButtonKitaplarGuncelle.Name = "ButtonKitaplarGuncelle";
            this.ButtonKitaplarGuncelle.Size = new System.Drawing.Size(266, 50);
            this.ButtonKitaplarGuncelle.TabIndex = 8;
            this.ButtonKitaplarGuncelle.Text = "GÜNCELLE";
            this.ButtonKitaplarGuncelle.UseVisualStyleBackColor = false;
            this.ButtonKitaplarGuncelle.Click += new System.EventHandler(this.ButtonKitaplarGuncelle_Click);
            // 
            // dateTimePickerKitaplarBaslamaTarihi
            // 
            this.dateTimePickerKitaplarBaslamaTarihi.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePickerKitaplarBaslamaTarihi.CustomFormat = "";
            this.dateTimePickerKitaplarBaslamaTarihi.Location = new System.Drawing.Point(358, 386);
            this.dateTimePickerKitaplarBaslamaTarihi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerKitaplarBaslamaTarihi.Name = "dateTimePickerKitaplarBaslamaTarihi";
            this.dateTimePickerKitaplarBaslamaTarihi.Size = new System.Drawing.Size(259, 20);
            this.dateTimePickerKitaplarBaslamaTarihi.TabIndex = 6;
            this.dateTimePickerKitaplarBaslamaTarihi.ValueChanged += new System.EventHandler(this.dateTimePickerKitaplarBaslamaTarihi_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(355, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "____________________________________________";
            // 
            // labelBaslamaTarihi
            // 
            this.labelBaslamaTarihi.AutoSize = true;
            this.labelBaslamaTarihi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaslamaTarihi.Location = new System.Drawing.Point(436, 348);
            this.labelBaslamaTarihi.Name = "labelBaslamaTarihi";
            this.labelBaslamaTarihi.Size = new System.Drawing.Size(106, 17);
            this.labelBaslamaTarihi.TabIndex = 36;
            this.labelBaslamaTarihi.Text = "BAŞLAMA TARİHİ";
            // 
            // labelFormGirisPanelCizgi1
            // 
            this.labelFormGirisPanelCizgi1.AutoSize = true;
            this.labelFormGirisPanelCizgi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.labelFormGirisPanelCizgi1.Location = new System.Drawing.Point(22, 301);
            this.labelFormGirisPanelCizgi1.Name = "labelFormGirisPanelCizgi1";
            this.labelFormGirisPanelCizgi1.Size = new System.Drawing.Size(271, 13);
            this.labelFormGirisPanelCizgi1.TabIndex = 41;
            this.labelFormGirisPanelCizgi1.Text = "____________________________________________";
            // 
            // textBoxKitaplarKitapAdi
            // 
            this.textBoxKitaplarKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKitaplarKitapAdi.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKitaplarKitapAdi.Location = new System.Drawing.Point(25, 282);
            this.textBoxKitaplarKitapAdi.Multiline = true;
            this.textBoxKitaplarKitapAdi.Name = "textBoxKitaplarKitapAdi";
            this.textBoxKitaplarKitapAdi.Size = new System.Drawing.Size(265, 32);
            this.textBoxKitaplarKitapAdi.TabIndex = 1;
            // 
            // labelKitapAdi
            // 
            this.labelKitapAdi.AutoSize = true;
            this.labelKitapAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKitapAdi.Location = new System.Drawing.Point(107, 249);
            this.labelKitapAdi.Name = "labelKitapAdi";
            this.labelKitapAdi.Size = new System.Drawing.Size(67, 17);
            this.labelKitapAdi.TabIndex = 39;
            this.labelKitapAdi.Text = "KİTAP ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(24, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "____________________________________________";
            // 
            // textBoxKitaplarYazarAdi
            // 
            this.textBoxKitaplarYazarAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKitaplarYazarAdi.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKitaplarYazarAdi.Location = new System.Drawing.Point(27, 387);
            this.textBoxKitaplarYazarAdi.Multiline = true;
            this.textBoxKitaplarYazarAdi.Name = "textBoxKitaplarYazarAdi";
            this.textBoxKitaplarYazarAdi.Size = new System.Drawing.Size(265, 32);
            this.textBoxKitaplarYazarAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "YAZAR ADI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(351, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "____________________________________________";
            // 
            // textBoxKitaplarYayineviAdi
            // 
            this.textBoxKitaplarYayineviAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKitaplarYayineviAdi.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKitaplarYayineviAdi.Location = new System.Drawing.Point(354, 282);
            this.textBoxKitaplarYayineviAdi.Multiline = true;
            this.textBoxKitaplarYayineviAdi.Name = "textBoxKitaplarYayineviAdi";
            this.textBoxKitaplarYayineviAdi.Size = new System.Drawing.Size(265, 32);
            this.textBoxKitaplarYayineviAdi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(436, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "YAYINEVİ ADI";
            // 
            // numericUpDownKitaplarSayfaSayisi
            // 
            this.numericUpDownKitaplarSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownKitaplarSayfaSayisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownKitaplarSayfaSayisi.Location = new System.Drawing.Point(25, 513);
            this.numericUpDownKitaplarSayfaSayisi.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownKitaplarSayfaSayisi.Name = "numericUpDownKitaplarSayfaSayisi";
            this.numericUpDownKitaplarSayfaSayisi.Size = new System.Drawing.Size(268, 19);
            this.numericUpDownKitaplarSayfaSayisi.TabIndex = 3;
            this.numericUpDownKitaplarSayfaSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(22, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "____________________________________________";
            // 
            // labelSayfaSayisi
            // 
            this.labelSayfaSayisi.AutoSize = true;
            this.labelSayfaSayisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSayfaSayisi.Location = new System.Drawing.Point(107, 484);
            this.labelSayfaSayisi.Name = "labelSayfaSayisi";
            this.labelSayfaSayisi.Size = new System.Drawing.Size(83, 17);
            this.labelSayfaSayisi.TabIndex = 51;
            this.labelSayfaSayisi.Text = "SAYFA SAYISI";
            // 
            // ButtonKitaplarTemizle
            // 
            this.ButtonKitaplarTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonKitaplarTemizle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonKitaplarTemizle.FlatAppearance.BorderSize = 0;
            this.ButtonKitaplarTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonKitaplarTemizle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonKitaplarTemizle.ForeColor = System.Drawing.Color.GhostWhite;
            this.ButtonKitaplarTemizle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonKitaplarTemizle.IconColor = System.Drawing.Color.Black;
            this.ButtonKitaplarTemizle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonKitaplarTemizle.Location = new System.Drawing.Point(667, 467);
            this.ButtonKitaplarTemizle.Name = "ButtonKitaplarTemizle";
            this.ButtonKitaplarTemizle.Size = new System.Drawing.Size(266, 50);
            this.ButtonKitaplarTemizle.TabIndex = 9;
            this.ButtonKitaplarTemizle.Text = "TEMİZLE";
            this.ButtonKitaplarTemizle.UseVisualStyleBackColor = false;
            this.ButtonKitaplarTemizle.Click += new System.EventHandler(this.ButtonKitaplarTemizle_Click);
            // 
            // ButtonKitaplarSil
            // 
            this.ButtonKitaplarSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonKitaplarSil.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonKitaplarSil.FlatAppearance.BorderSize = 0;
            this.ButtonKitaplarSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonKitaplarSil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonKitaplarSil.ForeColor = System.Drawing.Color.GhostWhite;
            this.ButtonKitaplarSil.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonKitaplarSil.IconColor = System.Drawing.Color.Black;
            this.ButtonKitaplarSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonKitaplarSil.Location = new System.Drawing.Point(358, 538);
            this.ButtonKitaplarSil.Name = "ButtonKitaplarSil";
            this.ButtonKitaplarSil.Size = new System.Drawing.Size(266, 50);
            this.ButtonKitaplarSil.TabIndex = 10;
            this.ButtonKitaplarSil.Text = "SİL";
            this.ButtonKitaplarSil.UseVisualStyleBackColor = false;
            this.ButtonKitaplarSil.Click += new System.EventHandler(this.ButtonKitaplarSil_Click);
            // 
            // dateTimePickerKitaplarBasimYili
            // 
            this.dateTimePickerKitaplarBasimYili.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePickerKitaplarBasimYili.CustomFormat = "yyyy";
            this.dateTimePickerKitaplarBasimYili.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerKitaplarBasimYili.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerKitaplarBasimYili.Location = new System.Drawing.Point(672, 271);
            this.dateTimePickerKitaplarBasimYili.Name = "dateTimePickerKitaplarBasimYili";
            this.dateTimePickerKitaplarBasimYili.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerKitaplarBasimYili.ShowUpDown = true;
            this.dateTimePickerKitaplarBasimYili.Size = new System.Drawing.Size(259, 23);
            this.dateTimePickerKitaplarBasimYili.TabIndex = 5;
            this.dateTimePickerKitaplarBasimYili.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(664, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "____________________________________________";
            // 
            // labelBasimYili
            // 
            this.labelBasimYili.AutoSize = true;
            this.labelBasimYili.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBasimYili.Location = new System.Drawing.Point(755, 242);
            this.labelBasimYili.Name = "labelBasimYili";
            this.labelBasimYili.Size = new System.Drawing.Size(67, 17);
            this.labelBasimYili.TabIndex = 63;
            this.labelBasimYili.Text = "BASIM YILI";
            // 
            // dateTimePickerKitaplarBitirmeTarihi
            // 
            this.dateTimePickerKitaplarBitirmeTarihi.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePickerKitaplarBitirmeTarihi.CustomFormat = "";
            this.dateTimePickerKitaplarBitirmeTarihi.Location = new System.Drawing.Point(667, 386);
            this.dateTimePickerKitaplarBitirmeTarihi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerKitaplarBitirmeTarihi.Name = "dateTimePickerKitaplarBitirmeTarihi";
            this.dateTimePickerKitaplarBitirmeTarihi.Size = new System.Drawing.Size(259, 20);
            this.dateTimePickerKitaplarBitirmeTarihi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(664, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "____________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(745, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 66;
            this.label8.Text = "BİTİRME TARİHİ";
            // 
            // Kitaplar
            // 
            this.AcceptButton = this.ButtonKitaplarGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.dateTimePickerKitaplarBitirmeTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerKitaplarBasimYili);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelBasimYili);
            this.Controls.Add(this.ButtonKitaplarSil);
            this.Controls.Add(this.ButtonKitaplarTemizle);
            this.Controls.Add(this.numericUpDownKitaplarSayfaSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSayfaSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxKitaplarYayineviAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKitaplarYazarAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFormGirisPanelCizgi1);
            this.Controls.Add(this.textBoxKitaplarKitapAdi);
            this.Controls.Add(this.labelKitapAdi);
            this.Controls.Add(this.dateTimePickerKitaplarBaslamaTarihi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelBaslamaTarihi);
            this.Controls.Add(this.ButtonKitaplarGuncelle);
            this.Controls.Add(this.dataGridViewKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKitaplarSayfaSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private FontAwesome.Sharp.IconButton ButtonKitaplarGuncelle;
        private System.Windows.Forms.DateTimePicker dateTimePickerKitaplarBaslamaTarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelBaslamaTarihi;
        private System.Windows.Forms.Label labelFormGirisPanelCizgi1;
        private System.Windows.Forms.TextBox textBoxKitaplarKitapAdi;
        private System.Windows.Forms.Label labelKitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKitaplarYazarAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKitaplarYayineviAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownKitaplarSayfaSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSayfaSayisi;
        private FontAwesome.Sharp.IconButton ButtonKitaplarTemizle;
        private FontAwesome.Sharp.IconButton ButtonKitaplarSil;
        private System.Windows.Forms.DateTimePicker dateTimePickerKitaplarBasimYili;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBasimYili;
        private System.Windows.Forms.DateTimePicker dateTimePickerKitaplarBitirmeTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}