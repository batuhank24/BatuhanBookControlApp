
namespace BatuhanKitaplık
{
    partial class BookCElements
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
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazari = new System.Windows.Forms.Label();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.lblBasimYili = new System.Windows.Forms.Label();
            this.lblFiyati = new System.Windows.Forms.Label();
            this.lblKitapID = new System.Windows.Forms.Label();
            this.txtFiyati = new System.Windows.Forms.TextBox();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.btn_KitapEkle = new System.Windows.Forms.Button();
            this.btn_KitapAra = new System.Windows.Forms.Button();
            this.btn_KitapKaldir = new System.Windows.Forms.Button();
            this.btn_KitapGuncelle = new System.Windows.Forms.Button();
            this.lblBasimevi = new System.Windows.Forms.Label();
            this.txtBasimEvi = new System.Windows.Forms.TextBox();
            this.btn_GoogleSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(197, 128);
            this.txtKitapAdi.MaxLength = 100;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(283, 20);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.Location = new System.Drawing.Point(118, 129);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(61, 16);
            this.lblKitapAdi.TabIndex = 1;
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // lblYazari
            // 
            this.lblYazari.AutoSize = true;
            this.lblYazari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazari.Location = new System.Drawing.Point(133, 169);
            this.lblYazari.Name = "lblYazari";
            this.lblYazari.Size = new System.Drawing.Size(46, 16);
            this.lblYazari.TabIndex = 2;
            this.lblYazari.Text = "Yazarı";
            // 
            // txtYazari
            // 
            this.txtYazari.Location = new System.Drawing.Point(197, 168);
            this.txtYazari.MaxLength = 100;
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(231, 20);
            this.txtYazari.TabIndex = 3;
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Location = new System.Drawing.Point(197, 244);
            this.txtBasimYili.MaxLength = 4;
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(141, 20);
            this.txtBasimYili.TabIndex = 4;
            // 
            // lblBasimYili
            // 
            this.lblBasimYili.AutoSize = true;
            this.lblBasimYili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasimYili.Location = new System.Drawing.Point(111, 244);
            this.lblBasimYili.Name = "lblBasimYili";
            this.lblBasimYili.Size = new System.Drawing.Size(67, 16);
            this.lblBasimYili.TabIndex = 5;
            this.lblBasimYili.Text = "Basım Yılı";
            // 
            // lblFiyati
            // 
            this.lblFiyati.AutoSize = true;
            this.lblFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyati.Location = new System.Drawing.Point(138, 285);
            this.lblFiyati.Name = "lblFiyati";
            this.lblFiyati.Size = new System.Drawing.Size(40, 16);
            this.lblFiyati.TabIndex = 6;
            this.lblFiyati.Text = "Fiyatı";
            // 
            // lblKitapID
            // 
            this.lblKitapID.AutoSize = true;
            this.lblKitapID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapID.Location = new System.Drawing.Point(118, 89);
            this.lblKitapID.Name = "lblKitapID";
            this.lblKitapID.Size = new System.Drawing.Size(62, 16);
            this.lblKitapID.TabIndex = 7;
            this.lblKitapID.Text = "Kitap ID";
            // 
            // txtFiyati
            // 
            this.txtFiyati.Location = new System.Drawing.Point(197, 285);
            this.txtFiyati.MaxLength = 20;
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Size = new System.Drawing.Size(112, 20);
            this.txtFiyati.TabIndex = 9;
            // 
            // txtKitapID
            // 
            this.txtKitapID.Enabled = false;
            this.txtKitapID.Location = new System.Drawing.Point(197, 88);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(112, 20);
            this.txtKitapID.TabIndex = 10;
            // 
            // btn_KitapEkle
            // 
            this.btn_KitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapEkle.Location = new System.Drawing.Point(651, 114);
            this.btn_KitapEkle.Name = "btn_KitapEkle";
            this.btn_KitapEkle.Size = new System.Drawing.Size(110, 47);
            this.btn_KitapEkle.TabIndex = 11;
            this.btn_KitapEkle.Text = "Kitap Ekle";
            this.btn_KitapEkle.UseVisualStyleBackColor = true;
            this.btn_KitapEkle.Click += new System.EventHandler(this.btn_KitapEkle_Click);
            // 
            // btn_KitapAra
            // 
            this.btn_KitapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapAra.Location = new System.Drawing.Point(651, 191);
            this.btn_KitapAra.Name = "btn_KitapAra";
            this.btn_KitapAra.Size = new System.Drawing.Size(110, 47);
            this.btn_KitapAra.TabIndex = 12;
            this.btn_KitapAra.Text = "Kitap Ara";
            this.btn_KitapAra.UseVisualStyleBackColor = true;
            this.btn_KitapAra.Click += new System.EventHandler(this.btn_KitapAra_Click);
            // 
            // btn_KitapKaldir
            // 
            this.btn_KitapKaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapKaldir.Location = new System.Drawing.Point(468, 349);
            this.btn_KitapKaldir.Name = "btn_KitapKaldir";
            this.btn_KitapKaldir.Size = new System.Drawing.Size(110, 47);
            this.btn_KitapKaldir.TabIndex = 13;
            this.btn_KitapKaldir.Text = "Kitap Kaldır";
            this.btn_KitapKaldir.UseVisualStyleBackColor = true;
            this.btn_KitapKaldir.Click += new System.EventHandler(this.btn_KitapKaldir_Click);
            // 
            // btn_KitapGuncelle
            // 
            this.btn_KitapGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapGuncelle.Location = new System.Drawing.Point(318, 349);
            this.btn_KitapGuncelle.Name = "btn_KitapGuncelle";
            this.btn_KitapGuncelle.Size = new System.Drawing.Size(110, 47);
            this.btn_KitapGuncelle.TabIndex = 14;
            this.btn_KitapGuncelle.Text = "Kitap Güncelle";
            this.btn_KitapGuncelle.UseVisualStyleBackColor = true;
            this.btn_KitapGuncelle.Click += new System.EventHandler(this.btn_KitapGuncelle_Click);
            // 
            // lblBasimevi
            // 
            this.lblBasimevi.AutoSize = true;
            this.lblBasimevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasimevi.Location = new System.Drawing.Point(114, 206);
            this.lblBasimevi.Name = "lblBasimevi";
            this.lblBasimevi.Size = new System.Drawing.Size(64, 16);
            this.lblBasimevi.TabIndex = 15;
            this.lblBasimevi.Text = "Basımevi";
            // 
            // txtBasimEvi
            // 
            this.txtBasimEvi.Location = new System.Drawing.Point(197, 205);
            this.txtBasimEvi.MaxLength = 50;
            this.txtBasimEvi.Name = "txtBasimEvi";
            this.txtBasimEvi.Size = new System.Drawing.Size(181, 20);
            this.txtBasimEvi.TabIndex = 16;
            // 
            // btn_GoogleSearch
            // 
            this.btn_GoogleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GoogleSearch.Location = new System.Drawing.Point(651, 270);
            this.btn_GoogleSearch.Name = "btn_GoogleSearch";
            this.btn_GoogleSearch.Size = new System.Drawing.Size(110, 47);
            this.btn_GoogleSearch.TabIndex = 17;
            this.btn_GoogleSearch.Text = "Google\'da Ara";
            this.btn_GoogleSearch.UseVisualStyleBackColor = true;
            this.btn_GoogleSearch.Click += new System.EventHandler(this.btn_GoogleSearch_Click);
            // 
            // BookCElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 433);
            this.Controls.Add(this.btn_GoogleSearch);
            this.Controls.Add(this.txtBasimEvi);
            this.Controls.Add(this.lblBasimevi);
            this.Controls.Add(this.btn_KitapGuncelle);
            this.Controls.Add(this.btn_KitapKaldir);
            this.Controls.Add(this.btn_KitapAra);
            this.Controls.Add(this.btn_KitapEkle);
            this.Controls.Add(this.txtKitapID);
            this.Controls.Add(this.txtFiyati);
            this.Controls.Add(this.lblKitapID);
            this.Controls.Add(this.lblFiyati);
            this.Controls.Add(this.lblBasimYili);
            this.Controls.Add(this.txtBasimYili);
            this.Controls.Add(this.txtYazari);
            this.Controls.Add(this.lblYazari);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.txtKitapAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookCElements";
            this.Text = "Batuhan Kitaplık";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazari;
        public System.Windows.Forms.TextBox txtYazari;
        public System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.Label lblBasimYili;
        private System.Windows.Forms.Label lblFiyati;
        private System.Windows.Forms.Label lblKitapID;
        public System.Windows.Forms.TextBox txtFiyati;
        public System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.Button btn_KitapEkle;
        private System.Windows.Forms.Button btn_KitapAra;
        private System.Windows.Forms.Button btn_KitapKaldir;
        private System.Windows.Forms.Button btn_KitapGuncelle;
        private System.Windows.Forms.Label lblBasimevi;
        public System.Windows.Forms.TextBox txtBasimEvi;
        private System.Windows.Forms.Button btn_GoogleSearch;
    }
}

