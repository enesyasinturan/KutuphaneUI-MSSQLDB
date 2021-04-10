
namespace KutuphaneUI.Sayfalar
{
    partial class Kullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanicilar));
            this.dataGridViewKullanicilar = new System.Windows.Forms.DataGridView();
            this.ButtonYetkiDegistir = new FontAwesome.Sharp.IconButton();
            this.ButtonKullaniciAdiDegistir = new FontAwesome.Sharp.IconButton();
            this.ButtonKullaniciSil = new FontAwesome.Sharp.IconButton();
            this.labelFormGirisPanelCizgi1 = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.labelKitapAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownYetki = new System.Windows.Forms.NumericUpDown();
            this.ButtonTemizle = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYetki)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKullanicilar
            // 
            this.dataGridViewKullanicilar.AllowUserToAddRows = false;
            this.dataGridViewKullanicilar.AllowUserToDeleteRows = false;
            this.dataGridViewKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKullanicilar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanicilar.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            this.dataGridViewKullanicilar.ReadOnly = true;
            this.dataGridViewKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKullanicilar.Size = new System.Drawing.Size(909, 279);
            this.dataGridViewKullanicilar.TabIndex = 0;
            this.dataGridViewKullanicilar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKullanicilar_CellDoubleClick);
            // 
            // ButtonYetkiDegistir
            // 
            this.ButtonYetkiDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonYetkiDegistir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonYetkiDegistir.FlatAppearance.BorderSize = 0;
            this.ButtonYetkiDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonYetkiDegistir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonYetkiDegistir.ForeColor = System.Drawing.Color.GhostWhite;
            this.ButtonYetkiDegistir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonYetkiDegistir.IconColor = System.Drawing.Color.Black;
            this.ButtonYetkiDegistir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonYetkiDegistir.Location = new System.Drawing.Point(343, 538);
            this.ButtonYetkiDegistir.Name = "ButtonYetkiDegistir";
            this.ButtonYetkiDegistir.Size = new System.Drawing.Size(266, 50);
            this.ButtonYetkiDegistir.TabIndex = 9;
            this.ButtonYetkiDegistir.Text = "YETKİ DEĞİŞTİR";
            this.ButtonYetkiDegistir.UseVisualStyleBackColor = false;
            this.ButtonYetkiDegistir.Click += new System.EventHandler(this.ButtonYetkiDegistir_Click);
            // 
            // ButtonKullaniciAdiDegistir
            // 
            this.ButtonKullaniciAdiDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonKullaniciAdiDegistir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonKullaniciAdiDegistir.FlatAppearance.BorderSize = 0;
            this.ButtonKullaniciAdiDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonKullaniciAdiDegistir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonKullaniciAdiDegistir.ForeColor = System.Drawing.Color.GhostWhite;
            this.ButtonKullaniciAdiDegistir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonKullaniciAdiDegistir.IconColor = System.Drawing.Color.Black;
            this.ButtonKullaniciAdiDegistir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonKullaniciAdiDegistir.Location = new System.Drawing.Point(39, 538);
            this.ButtonKullaniciAdiDegistir.Name = "ButtonKullaniciAdiDegistir";
            this.ButtonKullaniciAdiDegistir.Size = new System.Drawing.Size(266, 50);
            this.ButtonKullaniciAdiDegistir.TabIndex = 10;
            this.ButtonKullaniciAdiDegistir.Text = "KULLANICI ADI DEĞİŞTİR";
            this.ButtonKullaniciAdiDegistir.UseVisualStyleBackColor = false;
            this.ButtonKullaniciAdiDegistir.Click += new System.EventHandler(this.ButtonKullaniciAdiDegistir_Click);
            // 
            // ButtonKullaniciSil
            // 
            this.ButtonKullaniciSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonKullaniciSil.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonKullaniciSil.FlatAppearance.BorderSize = 0;
            this.ButtonKullaniciSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonKullaniciSil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonKullaniciSil.ForeColor = System.Drawing.Color.GhostWhite;
            this.ButtonKullaniciSil.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonKullaniciSil.IconColor = System.Drawing.Color.Black;
            this.ButtonKullaniciSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonKullaniciSil.Location = new System.Drawing.Point(641, 538);
            this.ButtonKullaniciSil.Name = "ButtonKullaniciSil";
            this.ButtonKullaniciSil.Size = new System.Drawing.Size(266, 50);
            this.ButtonKullaniciSil.TabIndex = 11;
            this.ButtonKullaniciSil.Text = "SEÇİLİ KULLANICIYI SİL";
            this.ButtonKullaniciSil.UseVisualStyleBackColor = false;
            this.ButtonKullaniciSil.Click += new System.EventHandler(this.ButtonKullaniciSil_Click);
            // 
            // labelFormGirisPanelCizgi1
            // 
            this.labelFormGirisPanelCizgi1.AutoSize = true;
            this.labelFormGirisPanelCizgi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.labelFormGirisPanelCizgi1.Location = new System.Drawing.Point(37, 503);
            this.labelFormGirisPanelCizgi1.Name = "labelFormGirisPanelCizgi1";
            this.labelFormGirisPanelCizgi1.Size = new System.Drawing.Size(271, 13);
            this.labelFormGirisPanelCizgi1.TabIndex = 44;
            this.labelFormGirisPanelCizgi1.Text = "____________________________________________";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(40, 484);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(265, 17);
            this.textBoxKullaniciAdi.TabIndex = 42;
            // 
            // labelKitapAdi
            // 
            this.labelKitapAdi.AutoSize = true;
            this.labelKitapAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKitapAdi.Location = new System.Drawing.Point(122, 451);
            this.labelKitapAdi.Name = "labelKitapAdi";
            this.labelKitapAdi.Size = new System.Drawing.Size(98, 17);
            this.labelKitapAdi.TabIndex = 43;
            this.labelKitapAdi.Text = "KULLANICI ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(339, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "____________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(447, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "YETKİ";
            // 
            // numericUpDownYetki
            // 
            this.numericUpDownYetki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownYetki.Location = new System.Drawing.Point(343, 484);
            this.numericUpDownYetki.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownYetki.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownYetki.Name = "numericUpDownYetki";
            this.numericUpDownYetki.Size = new System.Drawing.Size(266, 16);
            this.numericUpDownYetki.TabIndex = 48;
            this.numericUpDownYetki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownYetki.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonTemizle
            // 
            this.ButtonTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTemizle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonTemizle.FlatAppearance.BorderSize = 0;
            this.ButtonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTemizle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonTemizle.ForeColor = System.Drawing.Color.GhostWhite;
            this.ButtonTemizle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonTemizle.IconColor = System.Drawing.Color.Black;
            this.ButtonTemizle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonTemizle.Location = new System.Drawing.Point(641, 482);
            this.ButtonTemizle.Name = "ButtonTemizle";
            this.ButtonTemizle.Size = new System.Drawing.Size(266, 50);
            this.ButtonTemizle.TabIndex = 49;
            this.ButtonTemizle.Text = "TEMİZLE";
            this.ButtonTemizle.UseVisualStyleBackColor = false;
            this.ButtonTemizle.Click += new System.EventHandler(this.ButtonTemizle_Click);
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.ButtonTemizle);
            this.Controls.Add(this.numericUpDownYetki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFormGirisPanelCizgi1);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.labelKitapAdi);
            this.Controls.Add(this.ButtonKullaniciSil);
            this.Controls.Add(this.ButtonKullaniciAdiDegistir);
            this.Controls.Add(this.ButtonYetkiDegistir);
            this.Controls.Add(this.dataGridViewKullanicilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kullanicilar";
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYetki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
        private FontAwesome.Sharp.IconButton ButtonYetkiDegistir;
        private FontAwesome.Sharp.IconButton ButtonKullaniciAdiDegistir;
        private FontAwesome.Sharp.IconButton ButtonKullaniciSil;
        private System.Windows.Forms.Label labelFormGirisPanelCizgi1;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.Label labelKitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownYetki;
        private FontAwesome.Sharp.IconButton ButtonTemizle;
    }
}