namespace HastaneOtomasyonu
{
    partial class HastaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabBtn = new MetroFramework.Controls.MetroTile();
            this.gecmisBtn = new MetroFramework.Controls.MetroTile();
            this.randevuBtn = new MetroFramework.Controls.MetroTile();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labAraBtn = new MetroFramework.Controls.MetroTile();
            this.labDatetime = new System.Windows.Forms.DateTimePicker();
            this.labDatagrid = new System.Windows.Forms.DataGridView();
            this.labContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tahliliGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gecmisDatetime = new System.Windows.Forms.DateTimePicker();
            this.gecmisDatagrid = new System.Windows.Forms.DataGridView();
            this.gecmisContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detaylıBilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.gecmisArabtn = new MetroFramework.Controls.MetroTile();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tarihDatepicker = new System.Windows.Forms.DateTimePicker();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.saatCombo = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.doktorCombo = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.poliklinikCombo = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.acilsifalartimer = new System.Windows.Forms.Timer(this.components);
            this.acilsifalarlabel = new System.Windows.Forms.Label();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labDatagrid)).BeginInit();
            this.labContext.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gecmisDatagrid)).BeginInit();
            this.gecmisContext.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabBtn);
            this.panel1.Controls.Add(this.gecmisBtn);
            this.panel1.Controls.Add(this.randevuBtn);
            this.panel1.Location = new System.Drawing.Point(5, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 260);
            this.panel1.TabIndex = 1;
            // 
            // LabBtn
            // 
            this.LabBtn.Location = new System.Drawing.Point(1, 141);
            this.LabBtn.Name = "LabBtn";
            this.LabBtn.Size = new System.Drawing.Size(267, 62);
            this.LabBtn.TabIndex = 2;
            this.LabBtn.Text = "Laboratuvar sonuçları";
            this.LabBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LabBtn.TileImage = ((System.Drawing.Image)(resources.GetObject("LabBtn.TileImage")));
            this.LabBtn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabBtn.UseTileImage = true;
            this.LabBtn.Click += new System.EventHandler(this.LabBtn_Click);
            // 
            // gecmisBtn
            // 
            this.gecmisBtn.Location = new System.Drawing.Point(1, 76);
            this.gecmisBtn.Name = "gecmisBtn";
            this.gecmisBtn.Size = new System.Drawing.Size(267, 62);
            this.gecmisBtn.TabIndex = 1;
            this.gecmisBtn.Text = "Geçmişi gör";
            this.gecmisBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gecmisBtn.TileImage = ((System.Drawing.Image)(resources.GetObject("gecmisBtn.TileImage")));
            this.gecmisBtn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gecmisBtn.UseTileImage = true;
            this.gecmisBtn.Click += new System.EventHandler(this.gecmisBtn_Click);
            // 
            // randevuBtn
            // 
            this.randevuBtn.Location = new System.Drawing.Point(0, 11);
            this.randevuBtn.Name = "randevuBtn";
            this.randevuBtn.Size = new System.Drawing.Size(268, 62);
            this.randevuBtn.TabIndex = 0;
            this.randevuBtn.Text = "Randevu al";
            this.randevuBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.randevuBtn.TileImage = ((System.Drawing.Image)(resources.GetObject("randevuBtn.TileImage")));
            this.randevuBtn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.randevuBtn.UseTileImage = true;
            this.randevuBtn.Click += new System.EventHandler(this.randevuBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(604, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labAraBtn);
            this.groupBox3.Controls.Add(this.labDatetime);
            this.groupBox3.Controls.Add(this.labDatagrid);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Location = new System.Drawing.Point(1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 419);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Laboratuvar sonuçları";
            // 
            // labAraBtn
            // 
            this.labAraBtn.Location = new System.Drawing.Point(414, 27);
            this.labAraBtn.Name = "labAraBtn";
            this.labAraBtn.Size = new System.Drawing.Size(83, 23);
            this.labAraBtn.TabIndex = 10;
            this.labAraBtn.Text = "Ara";
            this.labAraBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labAraBtn.Click += new System.EventHandler(this.labAraBtn_Click);
            // 
            // labDatetime
            // 
            this.labDatetime.Location = new System.Drawing.Point(208, 30);
            this.labDatetime.Name = "labDatetime";
            this.labDatetime.Size = new System.Drawing.Size(200, 20);
            this.labDatetime.TabIndex = 9;
            // 
            // labDatagrid
            // 
            this.labDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labDatagrid.ContextMenuStrip = this.labContext;
            this.labDatagrid.Location = new System.Drawing.Point(3, 70);
            this.labDatagrid.Name = "labDatagrid";
            this.labDatagrid.ReadOnly = true;
            this.labDatagrid.Size = new System.Drawing.Size(590, 343);
            this.labDatagrid.TabIndex = 8;
            // 
            // labContext
            // 
            this.labContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tahliliGörToolStripMenuItem,
            this.yenileToolStripMenuItem1});
            this.labContext.Name = "labContext";
            this.labContext.Size = new System.Drawing.Size(127, 48);
            // 
            // tahliliGörToolStripMenuItem
            // 
            this.tahliliGörToolStripMenuItem.Name = "tahliliGörToolStripMenuItem";
            this.tahliliGörToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.tahliliGörToolStripMenuItem.Text = "Tahlili gör";
            this.tahliliGörToolStripMenuItem.Click += new System.EventHandler(this.tahliliGörToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem1
            // 
            this.yenileToolStripMenuItem1.Name = "yenileToolStripMenuItem1";
            this.yenileToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.yenileToolStripMenuItem1.Text = "Yenile";
            this.yenileToolStripMenuItem1.Click += new System.EventHandler(this.yenileToolStripMenuItem1_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(96, 29);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Tarih\'e göre ara :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gecmisDatetime);
            this.groupBox2.Controls.Add(this.gecmisDatagrid);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.gecmisArabtn);
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 419);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geçmişi gör";
            // 
            // gecmisDatetime
            // 
            this.gecmisDatetime.Location = new System.Drawing.Point(204, 33);
            this.gecmisDatetime.Name = "gecmisDatetime";
            this.gecmisDatetime.Size = new System.Drawing.Size(200, 20);
            this.gecmisDatetime.TabIndex = 5;
            // 
            // gecmisDatagrid
            // 
            this.gecmisDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gecmisDatagrid.ContextMenuStrip = this.gecmisContext;
            this.gecmisDatagrid.Location = new System.Drawing.Point(5, 73);
            this.gecmisDatagrid.Name = "gecmisDatagrid";
            this.gecmisDatagrid.ReadOnly = true;
            this.gecmisDatagrid.Size = new System.Drawing.Size(587, 339);
            this.gecmisDatagrid.TabIndex = 4;
            // 
            // gecmisContext
            // 
            this.gecmisContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaylıBilgiToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.gecmisContext.Name = "gecmisContext";
            this.gecmisContext.Size = new System.Drawing.Size(137, 48);
            // 
            // detaylıBilgiToolStripMenuItem
            // 
            this.detaylıBilgiToolStripMenuItem.Name = "detaylıBilgiToolStripMenuItem";
            this.detaylıBilgiToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.detaylıBilgiToolStripMenuItem.Text = "Detaylı bilgi";
            this.detaylıBilgiToolStripMenuItem.Click += new System.EventHandler(this.detaylıBilgiToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(92, 32);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Tarih\'e göre ara :";
            // 
            // gecmisArabtn
            // 
            this.gecmisArabtn.Location = new System.Drawing.Point(410, 31);
            this.gecmisArabtn.Name = "gecmisArabtn";
            this.gecmisArabtn.Size = new System.Drawing.Size(83, 23);
            this.gecmisArabtn.TabIndex = 0;
            this.gecmisArabtn.Text = "Ara";
            this.gecmisArabtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gecmisArabtn.Click += new System.EventHandler(this.gecmisArabtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.tarihDatepicker);
            this.groupBox1.Controls.Add(this.metroTile1);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.saatCombo);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.doktorCombo);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.poliklinikCombo);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 419);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu al";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(146, 200);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 19);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "Randevu Tarihi :";
            // 
            // tarihDatepicker
            // 
            this.tarihDatepicker.Location = new System.Drawing.Point(257, 200);
            this.tarihDatepicker.Name = "tarihDatepicker";
            this.tarihDatepicker.Size = new System.Drawing.Size(172, 20);
            this.tarihDatepicker.TabIndex = 35;
            this.tarihDatepicker.ValueChanged += new System.EventHandler(this.tarih_valuechanged);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(301, 308);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(92, 46);
            this.metroTile1.TabIndex = 34;
            this.metroTile1.Text = "Randevu al";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(151, 257);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Randevu Saati :";
            // 
            // saatCombo
            // 
            this.saatCombo.FormattingEnabled = true;
            this.saatCombo.Location = new System.Drawing.Point(257, 255);
            this.saatCombo.Name = "saatCombo";
            this.saatCombo.Size = new System.Drawing.Size(172, 21);
            this.saatCombo.TabIndex = 32;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(193, 143);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Doktor :";
            // 
            // doktorCombo
            // 
            this.doktorCombo.FormattingEnabled = true;
            this.doktorCombo.Location = new System.Drawing.Point(257, 141);
            this.doktorCombo.Name = "doktorCombo";
            this.doktorCombo.Size = new System.Drawing.Size(172, 21);
            this.doktorCombo.TabIndex = 30;
            this.doktorCombo.SelectedIndexChanged += new System.EventHandler(this.doktorCombo_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(185, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Poliklinik :";
            // 
            // poliklinikCombo
            // 
            this.poliklinikCombo.FormattingEnabled = true;
            this.poliklinikCombo.Location = new System.Drawing.Point(257, 76);
            this.poliklinikCombo.Name = "poliklinikCombo";
            this.poliklinikCombo.Size = new System.Drawing.Size(172, 21);
            this.poliklinikCombo.TabIndex = 28;
            this.poliklinikCombo.SelectedIndexChanged += new System.EventHandler(this.poliklinikCombo_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(274, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 445);
            this.tabControl1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // acilsifalartimer
            // 
            this.acilsifalartimer.Interval = 150;
            this.acilsifalartimer.Tick += new System.EventHandler(this.acilsifalartick);
            // 
            // acilsifalarlabel
            // 
            this.acilsifalarlabel.AutoSize = true;
            this.acilsifalarlabel.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acilsifalarlabel.ForeColor = System.Drawing.Color.Red;
            this.acilsifalarlabel.Location = new System.Drawing.Point(10, 414);
            this.acilsifalarlabel.Name = "acilsifalarlabel";
            this.acilsifalarlabel.Size = new System.Drawing.Size(0, 24);
            this.acilsifalarlabel.TabIndex = 8;
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(789, 546);
            this.metroTile4.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(75, 36);
            this.metroTile4.TabIndex = 22;
            this.metroTile4.Text = "Çıkış";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // HastaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 587);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.acilsifalarlabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HastaForm";
            this.Text = "Hasta Profili";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labDatagrid)).EndInit();
            this.labContext.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gecmisDatagrid)).EndInit();
            this.gecmisContext.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile randevuBtn;
        private MetroFramework.Controls.MetroTile LabBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker gecmisDatetime;
        private System.Windows.Forms.DataGridView gecmisDatagrid;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile gecmisArabtn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox saatCombo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox doktorCombo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox poliklinikCombo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker labDatetime;
        private System.Windows.Forms.DataGridView labDatagrid;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DateTimePicker tarihDatepicker;
        private System.Windows.Forms.ContextMenuStrip gecmisContext;
        private System.Windows.Forms.ToolStripMenuItem detaylıBilgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip labContext;
        private System.Windows.Forms.ToolStripMenuItem tahliliGörToolStripMenuItem;
        private MetroFramework.Controls.MetroTile labAraBtn;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer acilsifalartimer;
        private System.Windows.Forms.Label acilsifalarlabel;
        private MetroFramework.Controls.MetroTile gecmisBtn;
        private MetroFramework.Controls.MetroTile metroTile4;

    }
}

