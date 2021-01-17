namespace PaintApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CizimEkrani = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Altigen = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Ucgen = new System.Windows.Forms.Button();
            this.Daire = new System.Windows.Forms.Button();
            this.Kare = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Kahverengi = new System.Windows.Forms.Button();
            this.Beyaz = new System.Windows.Forms.Button();
            this.Siyah = new System.Windows.Forms.Button();
            this.Yesil = new System.Windows.Forms.Button();
            this.Turuncu = new System.Windows.Forms.Button();
            this.Mor = new System.Windows.Forms.Button();
            this.Sari = new System.Windows.Forms.Button();
            this.Mavi = new System.Windows.Forms.Button();
            this.Kirmizi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SekilSil = new System.Windows.Forms.Button();
            this.SekilSec = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DosyaAc = new System.Windows.Forms.Button();
            this.Kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CizimEkrani)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CizimEkrani
            // 
            this.CizimEkrani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CizimEkrani.Location = new System.Drawing.Point(12, 12);
            this.CizimEkrani.Name = "CizimEkrani";
            this.CizimEkrani.Size = new System.Drawing.Size(565, 469);
            this.CizimEkrani.TabIndex = 0;
            this.CizimEkrani.TabStop = false;
            this.CizimEkrani.Paint += new System.Windows.Forms.PaintEventHandler(this.CizimEkrani_Paint);
            this.CizimEkrani.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CizimEkrani_MouseDown);
            this.CizimEkrani.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CizimEkrani_MouseMove);
            this.CizimEkrani.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CizimEkrani_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.Altigen);
            this.groupBox1.Controls.Add(this.Ucgen);
            this.groupBox1.Controls.Add(this.Daire);
            this.groupBox1.Controls.Add(this.Kare);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(583, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çizim Şekli";
            // 
            // Altigen
            // 
            this.Altigen.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.Altigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Altigen.ImageKey = "hexagon-shape-by-Vexels.png";
            this.Altigen.ImageList = this.ımageList1;
            this.Altigen.Location = new System.Drawing.Point(120, 85);
            this.Altigen.Name = "Altigen";
            this.Altigen.Size = new System.Drawing.Size(75, 59);
            this.Altigen.TabIndex = 3;
            this.Altigen.UseVisualStyleBackColor = true;
            this.Altigen.Click += new System.EventHandler(this.Altigen_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "circle-48.png");
            this.ımageList1.Images.SetKeyName(1, "hexagon-shape-by-Vexels.png");
            this.ımageList1.Images.SetKeyName(2, "one_finger.png");
            this.ımageList1.Images.SetKeyName(3, "open_folder_yellow.png");
            this.ımageList1.Images.SetKeyName(4, "save.png");
            this.ımageList1.Images.SetKeyName(5, "square-rounded-square-by-Vexels.png");
            this.ımageList1.Images.SetKeyName(6, "trash_recyclebin_empty_closed.png");
            this.ımageList1.Images.SetKeyName(7, "triangle-sign-by-Vexels.png");
            // 
            // Ucgen
            // 
            this.Ucgen.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.Ucgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ucgen.ImageKey = "triangle-sign-by-Vexels.png";
            this.Ucgen.ImageList = this.ımageList1;
            this.Ucgen.Location = new System.Drawing.Point(22, 85);
            this.Ucgen.Name = "Ucgen";
            this.Ucgen.Size = new System.Drawing.Size(75, 59);
            this.Ucgen.TabIndex = 2;
            this.Ucgen.UseVisualStyleBackColor = true;
            this.Ucgen.Click += new System.EventHandler(this.Ucgen_Click);
            // 
            // Daire
            // 
            this.Daire.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.Daire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Daire.ImageKey = "circle-48.png";
            this.Daire.ImageList = this.ımageList1;
            this.Daire.Location = new System.Drawing.Point(120, 23);
            this.Daire.Name = "Daire";
            this.Daire.Size = new System.Drawing.Size(75, 59);
            this.Daire.TabIndex = 1;
            this.Daire.UseVisualStyleBackColor = true;
            this.Daire.Click += new System.EventHandler(this.Daire_Click);
            // 
            // Kare
            // 
            this.Kare.BackColor = System.Drawing.Color.Khaki;
            this.Kare.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.Kare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kare.ForeColor = System.Drawing.Color.Black;
            this.Kare.ImageKey = "square-rounded-square-by-Vexels.png";
            this.Kare.ImageList = this.ımageList1;
            this.Kare.Location = new System.Drawing.Point(22, 23);
            this.Kare.Name = "Kare";
            this.Kare.Size = new System.Drawing.Size(75, 56);
            this.Kare.TabIndex = 0;
            this.Kare.UseVisualStyleBackColor = false;
            this.Kare.Click += new System.EventHandler(this.Kare_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Khaki;
            this.groupBox2.Controls.Add(this.Kahverengi);
            this.groupBox2.Controls.Add(this.Beyaz);
            this.groupBox2.Controls.Add(this.Siyah);
            this.groupBox2.Controls.Add(this.Yesil);
            this.groupBox2.Controls.Add(this.Turuncu);
            this.groupBox2.Controls.Add(this.Mor);
            this.groupBox2.Controls.Add(this.Sari);
            this.groupBox2.Controls.Add(this.Mavi);
            this.groupBox2.Controls.Add(this.Kirmizi);
            this.groupBox2.Location = new System.Drawing.Point(583, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renkler";
            // 
            // Kahverengi
            // 
            this.Kahverengi.BackColor = System.Drawing.Color.Brown;
            this.Kahverengi.Location = new System.Drawing.Point(80, 92);
            this.Kahverengi.Name = "Kahverengi";
            this.Kahverengi.Size = new System.Drawing.Size(39, 29);
            this.Kahverengi.TabIndex = 8;
            this.Kahverengi.UseVisualStyleBackColor = false;
            this.Kahverengi.Click += new System.EventHandler(this.Kahverengi_Click);
            // 
            // Beyaz
            // 
            this.Beyaz.BackColor = System.Drawing.Color.White;
            this.Beyaz.Location = new System.Drawing.Point(136, 92);
            this.Beyaz.Name = "Beyaz";
            this.Beyaz.Size = new System.Drawing.Size(39, 29);
            this.Beyaz.TabIndex = 7;
            this.Beyaz.UseVisualStyleBackColor = false;
            this.Beyaz.Click += new System.EventHandler(this.Beyaz_Click);
            // 
            // Siyah
            // 
            this.Siyah.BackColor = System.Drawing.Color.Black;
            this.Siyah.Location = new System.Drawing.Point(80, 57);
            this.Siyah.Name = "Siyah";
            this.Siyah.Size = new System.Drawing.Size(39, 29);
            this.Siyah.TabIndex = 6;
            this.Siyah.UseVisualStyleBackColor = false;
            this.Siyah.Click += new System.EventHandler(this.Siyah_Click);
            // 
            // Yesil
            // 
            this.Yesil.BackColor = System.Drawing.Color.Green;
            this.Yesil.Location = new System.Drawing.Point(136, 19);
            this.Yesil.Name = "Yesil";
            this.Yesil.Size = new System.Drawing.Size(39, 29);
            this.Yesil.TabIndex = 5;
            this.Yesil.UseVisualStyleBackColor = false;
            this.Yesil.Click += new System.EventHandler(this.Yesil_Click);
            // 
            // Turuncu
            // 
            this.Turuncu.BackColor = System.Drawing.Color.Orange;
            this.Turuncu.Location = new System.Drawing.Point(22, 57);
            this.Turuncu.Name = "Turuncu";
            this.Turuncu.Size = new System.Drawing.Size(39, 29);
            this.Turuncu.TabIndex = 4;
            this.Turuncu.UseVisualStyleBackColor = false;
            this.Turuncu.Click += new System.EventHandler(this.Turuncu_Click);
            // 
            // Mor
            // 
            this.Mor.BackColor = System.Drawing.Color.Purple;
            this.Mor.Location = new System.Drawing.Point(22, 92);
            this.Mor.Name = "Mor";
            this.Mor.Size = new System.Drawing.Size(39, 29);
            this.Mor.TabIndex = 3;
            this.Mor.UseVisualStyleBackColor = false;
            this.Mor.Click += new System.EventHandler(this.Mor_Click);
            // 
            // Sari
            // 
            this.Sari.BackColor = System.Drawing.Color.Yellow;
            this.Sari.Location = new System.Drawing.Point(136, 54);
            this.Sari.Name = "Sari";
            this.Sari.Size = new System.Drawing.Size(39, 29);
            this.Sari.TabIndex = 2;
            this.Sari.UseVisualStyleBackColor = false;
            this.Sari.Click += new System.EventHandler(this.Sari_Click);
            // 
            // Mavi
            // 
            this.Mavi.BackColor = System.Drawing.Color.Blue;
            this.Mavi.Location = new System.Drawing.Point(80, 19);
            this.Mavi.Name = "Mavi";
            this.Mavi.Size = new System.Drawing.Size(39, 29);
            this.Mavi.TabIndex = 1;
            this.Mavi.UseVisualStyleBackColor = false;
            this.Mavi.Click += new System.EventHandler(this.Mavi_Click);
            // 
            // Kirmizi
            // 
            this.Kirmizi.BackColor = System.Drawing.Color.Red;
            this.Kirmizi.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.Kirmizi.Location = new System.Drawing.Point(22, 19);
            this.Kirmizi.Name = "Kirmizi";
            this.Kirmizi.Size = new System.Drawing.Size(39, 29);
            this.Kirmizi.TabIndex = 0;
            this.Kirmizi.UseVisualStyleBackColor = false;
            this.Kirmizi.Click += new System.EventHandler(this.Kirmizi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Khaki;
            this.groupBox3.Controls.Add(this.SekilSil);
            this.groupBox3.Controls.Add(this.SekilSec);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(583, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 88);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Şekil İşlemleri";
            // 
            // SekilSil
            // 
            this.SekilSil.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.SekilSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SekilSil.ImageKey = "trash_recyclebin_empty_closed.png";
            this.SekilSil.ImageList = this.ımageList1;
            this.SekilSil.Location = new System.Drawing.Point(120, 19);
            this.SekilSil.Name = "SekilSil";
            this.SekilSil.Size = new System.Drawing.Size(75, 54);
            this.SekilSil.TabIndex = 1;
            this.SekilSil.UseVisualStyleBackColor = true;
            this.SekilSil.Click += new System.EventHandler(this.SekilSil_Click);
            // 
            // SekilSec
            // 
            this.SekilSec.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.SekilSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SekilSec.ImageKey = "one_finger.png";
            this.SekilSec.ImageList = this.ımageList1;
            this.SekilSec.Location = new System.Drawing.Point(22, 19);
            this.SekilSec.Name = "SekilSec";
            this.SekilSec.Size = new System.Drawing.Size(75, 54);
            this.SekilSec.TabIndex = 0;
            this.SekilSec.UseVisualStyleBackColor = true;
            this.SekilSec.Click += new System.EventHandler(this.SekilSec_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Khaki;
            this.groupBox4.Controls.Add(this.DosyaAc);
            this.groupBox4.Controls.Add(this.Kaydet);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(583, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 90);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dosya İşlemleri";
            // 
            // DosyaAc
            // 
            this.DosyaAc.BackColor = System.Drawing.Color.Khaki;
            this.DosyaAc.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.DosyaAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DosyaAc.ImageKey = "open_folder_yellow.png";
            this.DosyaAc.ImageList = this.ımageList1;
            this.DosyaAc.Location = new System.Drawing.Point(15, 19);
            this.DosyaAc.Name = "DosyaAc";
            this.DosyaAc.Size = new System.Drawing.Size(75, 51);
            this.DosyaAc.TabIndex = 1;
            this.DosyaAc.UseVisualStyleBackColor = false;
            this.DosyaAc.Click += new System.EventHandler(this.DosyaAc_Click);
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.Color.Khaki;
            this.Kaydet.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kaydet.ImageKey = "save.png";
            this.Kaydet.ImageList = this.ımageList1;
            this.Kaydet.Location = new System.Drawing.Point(98, 19);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 51);
            this.Kaydet.TabIndex = 0;
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 493);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CizimEkrani);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CizimEkrani)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CizimEkrani;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Altigen;
        private System.Windows.Forms.Button Ucgen;
        private System.Windows.Forms.Button Daire;
        private System.Windows.Forms.Button Kare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Kahverengi;
        private System.Windows.Forms.Button Beyaz;
        private System.Windows.Forms.Button Siyah;
        private System.Windows.Forms.Button Yesil;
        private System.Windows.Forms.Button Turuncu;
        private System.Windows.Forms.Button Mor;
        private System.Windows.Forms.Button Sari;
        private System.Windows.Forms.Button Mavi;
        private System.Windows.Forms.Button Kirmizi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SekilSil;
        private System.Windows.Forms.Button SekilSec;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button DosyaAc;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

