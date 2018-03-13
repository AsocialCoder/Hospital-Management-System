namespace HastaneOtomasyonu
{
    partial class DoktorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorForm));
            this.labContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tahliliGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hastaadsoyad_txt = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.hastatc_txt = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gecmisDatetime = new System.Windows.Forms.DateTimePicker();
            this.gecmisDatagrid = new System.Windows.Forms.DataGridView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.gecmisArabtn = new MetroFramework.Controls.MetroTile();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labAraBtn = new MetroFramework.Controls.MetroTile();
            this.labDatetime = new System.Windows.Forms.DateTimePicker();
            this.labDatagrid = new System.Windows.Forms.DataGridView();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.receteyazdir_btn = new MetroFramework.Controls.MetroTile();
            this.tahlil_txt = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.eklenendatagrid = new System.Windows.Forms.DataGridView();
            this.muayeneContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.ilac_txt = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.teshis_txt = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tahlilcagir_btn = new MetroFramework.Controls.MetroTile();
            this.hasta_cagir_btn = new MetroFramework.Controls.MetroTile();
            this.hastalardatagrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hasta_list_btn = new MetroFramework.Controls.MetroTile();
            this.muayene_btn = new MetroFramework.Controls.MetroTile();
            this.Lab_sonuc_btn = new MetroFramework.Controls.MetroTile();
            this.hasta_gecmis_btn = new MetroFramework.Controls.MetroTile();
            this.recetePrint = new System.Drawing.Printing.PrintDocument();
            this.recetePreview = new System.Windows.Forms.PrintPreviewDialog();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.labContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gecmisDatagrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labDatagrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eklenendatagrid)).BeginInit();
            this.muayeneContext.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastalardatagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // timer1
            // 
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hastaadsoyad_txt
            // 
            this.hastaadsoyad_txt.Location = new System.Drawing.Point(667, 74);
            this.hastaadsoyad_txt.Name = "hastaadsoyad_txt";
            this.hastaadsoyad_txt.ReadOnly = true;
            this.hastaadsoyad_txt.Size = new System.Drawing.Size(221, 20);
            this.hastaadsoyad_txt.TabIndex = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(547, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Hasta Ad , Soyad :";
            // 
            // hastatc_txt
            // 
            this.hastatc_txt.Location = new System.Drawing.Point(368, 74);
            this.hastatc_txt.Name = "hastatc_txt";
            this.hastatc_txt.ReadOnly = true;
            this.hastatc_txt.Size = new System.Drawing.Size(150, 20);
            this.hastatc_txt.TabIndex = 8;
            this.hastatc_txt.TextChanged += new System.EventHandler(this.hastatc_txt_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(298, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Hasta TC :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(283, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 445);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gecmisDatetime);
            this.groupBox2.Controls.Add(this.gecmisDatagrid);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.gecmisArabtn);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 419);
            this.groupBox2.TabIndex = 30;
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
            this.gecmisDatagrid.Location = new System.Drawing.Point(5, 73);
            this.gecmisDatagrid.Name = "gecmisDatagrid";
            this.gecmisDatagrid.ReadOnly = true;
            this.gecmisDatagrid.Size = new System.Drawing.Size(587, 339);
            this.gecmisDatagrid.TabIndex = 4;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labAraBtn);
            this.groupBox3.Controls.Add(this.labDatetime);
            this.groupBox3.Controls.Add(this.labDatagrid);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Location = new System.Drawing.Point(3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 419);
            this.groupBox3.TabIndex = 32;
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
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(96, 29);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Tarih\'e göre ara :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(604, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.receteyazdir_btn);
            this.groupBox4.Controls.Add(this.tahlil_txt);
            this.groupBox4.Controls.Add(this.metroLabel8);
            this.groupBox4.Controls.Add(this.eklenendatagrid);
            this.groupBox4.Controls.Add(this.metroLabel7);
            this.groupBox4.Controls.Add(this.ilac_txt);
            this.groupBox4.Controls.Add(this.metroLabel4);
            this.groupBox4.Controls.Add(this.teshis_txt);
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Location = new System.Drawing.Point(3, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(598, 419);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Muayene";
            // 
            // receteyazdir_btn
            // 
            this.receteyazdir_btn.Location = new System.Drawing.Point(236, 352);
            this.receteyazdir_btn.Name = "receteyazdir_btn";
            this.receteyazdir_btn.Size = new System.Drawing.Size(101, 61);
            this.receteyazdir_btn.TabIndex = 8;
            this.receteyazdir_btn.Text = "Reçete yazdır";
            this.receteyazdir_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.receteyazdir_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("receteyazdir_btn.TileImage")));
            this.receteyazdir_btn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.receteyazdir_btn.UseTileImage = true;
            this.receteyazdir_btn.Click += new System.EventHandler(this.receteyazdir_btn_Click);
            // 
            // tahlil_txt
            // 
            this.tahlil_txt.Location = new System.Drawing.Point(38, 74);
            this.tahlil_txt.Name = "tahlil_txt";
            this.tahlil_txt.Size = new System.Drawing.Size(140, 20);
            this.tahlil_txt.TabIndex = 7;
            this.tahlil_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tahliliste);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(80, 52);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(60, 19);
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Tahlil iste";
            // 
            // eklenendatagrid
            // 
            this.eklenendatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eklenendatagrid.ContextMenuStrip = this.muayeneContext;
            this.eklenendatagrid.Location = new System.Drawing.Point(3, 158);
            this.eklenendatagrid.Name = "eklenendatagrid";
            this.eklenendatagrid.Size = new System.Drawing.Size(589, 188);
            this.eklenendatagrid.TabIndex = 5;
            // 
            // muayeneContext
            // 
            this.muayeneContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.muayeneContext.Name = "muayeneContext";
            this.muayeneContext.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(165, 126);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(221, 19);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Her eklemeden sonra entere basınız.";
            // 
            // ilac_txt
            // 
            this.ilac_txt.Location = new System.Drawing.Point(296, 89);
            this.ilac_txt.Name = "ilac_txt";
            this.ilac_txt.Size = new System.Drawing.Size(296, 20);
            this.ilac_txt.TabIndex = 3;
            this.ilac_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ilacekle);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(240, 90);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "İlaçlar :";
            // 
            // teshis_txt
            // 
            this.teshis_txt.Location = new System.Drawing.Point(296, 43);
            this.teshis_txt.Name = "teshis_txt";
            this.teshis_txt.Size = new System.Drawing.Size(296, 20);
            this.teshis_txt.TabIndex = 1;
            this.teshis_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teshisekle);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(242, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Teşhis :";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(604, 419);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tahlilcagir_btn);
            this.groupBox1.Controls.Add(this.hasta_cagir_btn);
            this.groupBox1.Controls.Add(this.hastalardatagrid);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 419);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta gör";
            // 
            // tahlilcagir_btn
            // 
            this.tahlilcagir_btn.Location = new System.Drawing.Point(426, 352);
            this.tahlilcagir_btn.Name = "tahlilcagir_btn";
            this.tahlilcagir_btn.Size = new System.Drawing.Size(95, 64);
            this.tahlilcagir_btn.TabIndex = 4;
            this.tahlilcagir_btn.Text = "Tahlil çağır";
            this.tahlilcagir_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tahlilcagir_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("tahlilcagir_btn.TileImage")));
            this.tahlilcagir_btn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tahlilcagir_btn.UseTileImage = true;
            this.tahlilcagir_btn.Click += new System.EventHandler(this.tahlilcagir_btn_Click);
            // 
            // hasta_cagir_btn
            // 
            this.hasta_cagir_btn.Location = new System.Drawing.Point(93, 352);
            this.hasta_cagir_btn.Name = "hasta_cagir_btn";
            this.hasta_cagir_btn.Size = new System.Drawing.Size(95, 64);
            this.hasta_cagir_btn.TabIndex = 3;
            this.hasta_cagir_btn.Text = "Hasta çağır";
            this.hasta_cagir_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hasta_cagir_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("hasta_cagir_btn.TileImage")));
            this.hasta_cagir_btn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hasta_cagir_btn.UseTileImage = true;
            this.hasta_cagir_btn.Click += new System.EventHandler(this.hasta_cagir_btn_Click);
            // 
            // hastalardatagrid
            // 
            this.hastalardatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastalardatagrid.Location = new System.Drawing.Point(3, 16);
            this.hastalardatagrid.Name = "hastalardatagrid";
            this.hastalardatagrid.ReadOnly = true;
            this.hastalardatagrid.Size = new System.Drawing.Size(592, 332);
            this.hastalardatagrid.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hasta_list_btn);
            this.panel1.Controls.Add(this.muayene_btn);
            this.panel1.Controls.Add(this.Lab_sonuc_btn);
            this.panel1.Controls.Add(this.hasta_gecmis_btn);
            this.panel1.Location = new System.Drawing.Point(5, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 342);
            this.panel1.TabIndex = 4;
            // 
            // hasta_list_btn
            // 
            this.hasta_list_btn.Location = new System.Drawing.Point(1, 202);
            this.hasta_list_btn.Name = "hasta_list_btn";
            this.hasta_list_btn.Size = new System.Drawing.Size(267, 62);
            this.hasta_list_btn.TabIndex = 4;
            this.hasta_list_btn.Text = "Hastaları gör";
            this.hasta_list_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hasta_list_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("hasta_list_btn.TileImage")));
            this.hasta_list_btn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hasta_list_btn.UseTileImage = true;
            this.hasta_list_btn.Click += new System.EventHandler(this.hasta_list_btn_Click);
            // 
            // muayene_btn
            // 
            this.muayene_btn.Location = new System.Drawing.Point(1, 136);
            this.muayene_btn.Name = "muayene_btn";
            this.muayene_btn.Size = new System.Drawing.Size(267, 62);
            this.muayene_btn.TabIndex = 3;
            this.muayene_btn.Text = "Muayene";
            this.muayene_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.muayene_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("muayene_btn.TileImage")));
            this.muayene_btn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.muayene_btn.UseTileImage = true;
            this.muayene_btn.Click += new System.EventHandler(this.muayene_btn_Click);
            // 
            // Lab_sonuc_btn
            // 
            this.Lab_sonuc_btn.Location = new System.Drawing.Point(1, 71);
            this.Lab_sonuc_btn.Name = "Lab_sonuc_btn";
            this.Lab_sonuc_btn.Size = new System.Drawing.Size(267, 62);
            this.Lab_sonuc_btn.TabIndex = 2;
            this.Lab_sonuc_btn.Text = "Laboratuvar sonuçları";
            this.Lab_sonuc_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Lab_sonuc_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("Lab_sonuc_btn.TileImage")));
            this.Lab_sonuc_btn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lab_sonuc_btn.UseTileImage = true;
            this.Lab_sonuc_btn.Click += new System.EventHandler(this.Lab_sonuc_btn_Click);
            // 
            // hasta_gecmis_btn
            // 
            this.hasta_gecmis_btn.Location = new System.Drawing.Point(1, 6);
            this.hasta_gecmis_btn.Name = "hasta_gecmis_btn";
            this.hasta_gecmis_btn.Size = new System.Drawing.Size(267, 62);
            this.hasta_gecmis_btn.TabIndex = 1;
            this.hasta_gecmis_btn.Text = "Geçmişi gör";
            this.hasta_gecmis_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hasta_gecmis_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("hasta_gecmis_btn.TileImage")));
            this.hasta_gecmis_btn.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hasta_gecmis_btn.UseTileImage = true;
            this.hasta_gecmis_btn.Click += new System.EventHandler(this.hasta_gecmis_btn_Click);
            // 
            // recetePrint
            // 
            this.recetePrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.recetePrint_PrintPage);
            // 
            // recetePreview
            // 
            this.recetePreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.recetePreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.recetePreview.ClientSize = new System.Drawing.Size(400, 300);
            this.recetePreview.Document = this.recetePrint;
            this.recetePreview.Enabled = true;
            this.recetePreview.Icon = ((System.Drawing.Icon)(resources.GetObject("recetePreview.Icon")));
            this.recetePreview.Name = "recetePreview";
            this.recetePreview.Visible = false;
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(818, 573);
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
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 615);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.hastaadsoyad_txt);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.hastatc_txt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoktorForm";
            this.Text = "Doktor Profili";
            this.Load += new System.EventHandler(this.DoktorForm_Load);
            this.labContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gecmisDatagrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labDatagrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eklenendatagrid)).EndInit();
            this.muayeneContext.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hastalardatagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile muayene_btn;
        private MetroFramework.Controls.MetroTile Lab_sonuc_btn;
        private MetroFramework.Controls.MetroTile hasta_gecmis_btn;
        private MetroFramework.Controls.MetroTile hasta_list_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker gecmisDatetime;
        private System.Windows.Forms.DataGridView gecmisDatagrid;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile gecmisArabtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile labAraBtn;
        private System.Windows.Forms.DateTimePicker labDatetime;
        private System.Windows.Forms.DataGridView labDatagrid;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile hasta_cagir_btn;
        private System.Windows.Forms.DataGridView hastalardatagrid;
        private System.Windows.Forms.TextBox teshis_txt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox hastatc_txt;
        private System.Windows.Forms.TextBox hastaadsoyad_txt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ContextMenuStrip labContext;
        private System.Windows.Forms.ToolStripMenuItem tahliliGörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView eklenendatagrid;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox ilac_txt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox tahlil_txt;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ContextMenuStrip muayeneContext;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private MetroFramework.Controls.MetroTile receteyazdir_btn;
        private System.Drawing.Printing.PrintDocument recetePrint;
        private System.Windows.Forms.PrintPreviewDialog recetePreview;
        private MetroFramework.Controls.MetroTile tahlilcagir_btn;
        private MetroFramework.Controls.MetroTile metroTile4;



    }
}