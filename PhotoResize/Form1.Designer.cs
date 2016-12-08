namespace PhotoResize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sayfaÖnizlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfaYapısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfaYazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyutunuDegistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efektlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shearingColorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scalingColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resmiDöndürToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sagaDondurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.solaDondurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tersCevirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opaklikAyarlaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parlaklıkAyarlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblW = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDosya = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "W:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "H:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Yazı Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.resimToolStripMenuItem,
            this.programHakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.sayfaÖnizlemeToolStripMenuItem,
            this.sayfaYapısıToolStripMenuItem,
            this.sayfaYazdırToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.açToolStripMenuItem.Text = "Aç...";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet...           ";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(252, 6);
            // 
            // sayfaÖnizlemeToolStripMenuItem
            // 
            this.sayfaÖnizlemeToolStripMenuItem.Name = "sayfaÖnizlemeToolStripMenuItem";
            this.sayfaÖnizlemeToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.sayfaÖnizlemeToolStripMenuItem.Text = "Sayfa Önizleme";
            this.sayfaÖnizlemeToolStripMenuItem.Click += new System.EventHandler(this.sayfaÖnizlemeToolStripMenuItem_Click);
            // 
            // sayfaYapısıToolStripMenuItem
            // 
            this.sayfaYapısıToolStripMenuItem.Name = "sayfaYapısıToolStripMenuItem";
            this.sayfaYapısıToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.sayfaYapısıToolStripMenuItem.Text = "Sayfa Yapısı";
            this.sayfaYapısıToolStripMenuItem.Click += new System.EventHandler(this.sayfaYapısıToolStripMenuItem_Click);
            // 
            // sayfaYazdırToolStripMenuItem
            // 
            this.sayfaYazdırToolStripMenuItem.Name = "sayfaYazdırToolStripMenuItem";
            this.sayfaYazdırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.sayfaYazdırToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.sayfaYazdırToolStripMenuItem.Text = "Sayfa Yazdır";
            this.sayfaYazdırToolStripMenuItem.Click += new System.EventHandler(this.sayfaYazdırToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(252, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.ileriAlToolStripMenuItem,
            this.toolStripSeparator3,
            this.temizleToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // ileriAlToolStripMenuItem
            // 
            this.ileriAlToolStripMenuItem.Name = "ileriAlToolStripMenuItem";
            this.ileriAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.ileriAlToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ileriAlToolStripMenuItem.Text = "İleri Al";
            this.ileriAlToolStripMenuItem.Click += new System.EventHandler(this.ileriAlToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // resimToolStripMenuItem
            // 
            this.resimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boyutunuDegistirToolStripMenuItem,
            this.efektlerToolStripMenuItem,
            this.resmiDöndürToolStripMenuItem1,
            this.opaklikAyarlaToolStripMenuItem1,
            this.parlaklıkAyarlaToolStripMenuItem});
            this.resimToolStripMenuItem.Name = "resimToolStripMenuItem";
            this.resimToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.resimToolStripMenuItem.Text = "Resim";
            // 
            // boyutunuDegistirToolStripMenuItem
            // 
            this.boyutunuDegistirToolStripMenuItem.Name = "boyutunuDegistirToolStripMenuItem";
            this.boyutunuDegistirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.I)));
            this.boyutunuDegistirToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.boyutunuDegistirToolStripMenuItem.Text = "Boyutunu Değiştir";
            this.boyutunuDegistirToolStripMenuItem.Click += new System.EventHandler(this.boyutunuDegistirToolStripMenuItem_Click);
            // 
            // efektlerToolStripMenuItem
            // 
            this.efektlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.invertColorsToolStripMenuItem,
            this.shearingColorsToolStripMenuItem1,
            this.scalingColorsToolStripMenuItem});
            this.efektlerToolStripMenuItem.Name = "efektlerToolStripMenuItem";
            this.efektlerToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.efektlerToolStripMenuItem.Text = "Efektler";
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.originalToolStripMenuItem.Text = "Original";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // invertColorsToolStripMenuItem
            // 
            this.invertColorsToolStripMenuItem.Name = "invertColorsToolStripMenuItem";
            this.invertColorsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.invertColorsToolStripMenuItem.Text = "Invert Colors";
            this.invertColorsToolStripMenuItem.Click += new System.EventHandler(this.invertColorsToolStripMenuItem_Click);
            // 
            // shearingColorsToolStripMenuItem1
            // 
            this.shearingColorsToolStripMenuItem1.Name = "shearingColorsToolStripMenuItem1";
            this.shearingColorsToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.shearingColorsToolStripMenuItem1.Text = "Shearing Colors";
            this.shearingColorsToolStripMenuItem1.Click += new System.EventHandler(this.shearingColorsToolStripMenuItem1_Click);
            // 
            // scalingColorsToolStripMenuItem
            // 
            this.scalingColorsToolStripMenuItem.Name = "scalingColorsToolStripMenuItem";
            this.scalingColorsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.scalingColorsToolStripMenuItem.Text = "Scaling Colors";
            this.scalingColorsToolStripMenuItem.Click += new System.EventHandler(this.scalingColorsToolStripMenuItem_Click);
            // 
            // resmiDöndürToolStripMenuItem1
            // 
            this.resmiDöndürToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sagaDondurToolStripMenuItem1,
            this.solaDondurToolStripMenuItem1,
            this.tersCevirToolStripMenuItem1});
            this.resmiDöndürToolStripMenuItem1.Name = "resmiDöndürToolStripMenuItem1";
            this.resmiDöndürToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.resmiDöndürToolStripMenuItem1.Text = "Resmi Döndür";
            // 
            // sagaDondurToolStripMenuItem1
            // 
            this.sagaDondurToolStripMenuItem1.Name = "sagaDondurToolStripMenuItem1";
            this.sagaDondurToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.sagaDondurToolStripMenuItem1.Text = "Sağa Döndür";
            this.sagaDondurToolStripMenuItem1.Click += new System.EventHandler(this.sagaDondurToolStripMenuItem1_Click);
            // 
            // solaDondurToolStripMenuItem1
            // 
            this.solaDondurToolStripMenuItem1.Name = "solaDondurToolStripMenuItem1";
            this.solaDondurToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.solaDondurToolStripMenuItem1.Text = "Sola Döndür";
            this.solaDondurToolStripMenuItem1.Click += new System.EventHandler(this.solaDondurToolStripMenuItem1_Click);
            // 
            // tersCevirToolStripMenuItem1
            // 
            this.tersCevirToolStripMenuItem1.Name = "tersCevirToolStripMenuItem1";
            this.tersCevirToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.tersCevirToolStripMenuItem1.Text = "Ters Çevir";
            this.tersCevirToolStripMenuItem1.Click += new System.EventHandler(this.tersCevirToolStripMenuItem1_Click);
            // 
            // opaklikAyarlaToolStripMenuItem1
            // 
            this.opaklikAyarlaToolStripMenuItem1.Name = "opaklikAyarlaToolStripMenuItem1";
            this.opaklikAyarlaToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.opaklikAyarlaToolStripMenuItem1.Text = "Opaklık Ayarla";
            this.opaklikAyarlaToolStripMenuItem1.Click += new System.EventHandler(this.opaklikAyarlaToolStripMenuItem1_Click);
            // 
            // parlaklıkAyarlaToolStripMenuItem
            // 
            this.parlaklıkAyarlaToolStripMenuItem.Name = "parlaklıkAyarlaToolStripMenuItem";
            this.parlaklıkAyarlaToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.parlaklıkAyarlaToolStripMenuItem.Text = "Parlaklık Ayarla";
            this.parlaklıkAyarlaToolStripMenuItem.Click += new System.EventHandler(this.parlaklıkAyarlaToolStripMenuItem_Click);
            // 
            // programHakkındaToolStripMenuItem
            // 
            this.programHakkındaToolStripMenuItem.Name = "programHakkındaToolStripMenuItem";
            this.programHakkındaToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.programHakkındaToolStripMenuItem.Text = "Program Hakkında";
            this.programHakkındaToolStripMenuItem.Click += new System.EventHandler(this.programHakkındaToolStripMenuItem_Click);
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(29, 466);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(0, 13);
            this.lblW.TabIndex = 10;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(83, 466);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(0, 13);
            this.lblH.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dosya:";
            // 
            // lblDosya
            // 
            this.lblDosya.AutoSize = true;
            this.lblDosya.Location = new System.Drawing.Point(59, 441);
            this.lblDosya.Name = "lblDosya";
            this.lblDosya.Size = new System.Drawing.Size(0, 13);
            this.lblDosya.TabIndex = 13;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 398);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDosya);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adibe Cemoşop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Label lblW;
        public System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDosya;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfaÖnizlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfaYapısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfaYazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ileriAlToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem resimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyutunuDegistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efektlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resmiDöndürToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opaklikAyarlaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shearingColorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scalingColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sagaDondurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem solaDondurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tersCevirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parlaklıkAyarlaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        public System.Drawing.Printing.PrintDocument printDocument1;
    }
}

