namespace HastaneOtomasyonu
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.uyeOlBtn = new MetroFramework.Controls.MetroTile();
            this.girisBtn = new MetroFramework.Controls.MetroTile();
            this.sifreTxt = new MetroFramework.Controls.MetroTextBox();
            this.tcTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uyeOlBtn
            // 
            this.uyeOlBtn.Location = new System.Drawing.Point(567, 257);
            this.uyeOlBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uyeOlBtn.Name = "uyeOlBtn";
            this.uyeOlBtn.Size = new System.Drawing.Size(104, 52);
            this.uyeOlBtn.TabIndex = 21;
            this.uyeOlBtn.Text = "Üye Ol";
            this.uyeOlBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uyeOlBtn.TileImage = ((System.Drawing.Image)(resources.GetObject("uyeOlBtn.TileImage")));
            this.uyeOlBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uyeOlBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.uyeOlBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.uyeOlBtn.UseTileImage = true;
            this.uyeOlBtn.Click += new System.EventHandler(this.uyeOlBtn_Click);
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(429, 257);
            this.girisBtn.Margin = new System.Windows.Forms.Padding(2);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(93, 52);
            this.girisBtn.TabIndex = 20;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.girisBtn.TileImage = ((System.Drawing.Image)(resources.GetObject("girisBtn.TileImage")));
            this.girisBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.girisBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.girisBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.girisBtn.UseTileImage = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(522, 206);
            this.sifreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(149, 19);
            this.sifreTxt.TabIndex = 19;
            // 
            // tcTxt
            // 
            this.tcTxt.Location = new System.Drawing.Point(522, 155);
            this.tcTxt.Margin = new System.Windows.Forms.Padding(2);
            this.tcTxt.MaxLength = 11;
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Size = new System.Drawing.Size(149, 19);
            this.tcTxt.TabIndex = 18;
            this.tcTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcTxt_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(451, 206);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 25);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Şifre : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(399, 155);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 25);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "T.C. Kimlik No :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 314);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 465);
            this.Controls.Add(this.uyeOlBtn);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.tcTxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GirisForm";
            this.Text = "GirisForm";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile uyeOlBtn;
        private MetroFramework.Controls.MetroTile girisBtn;
        private MetroFramework.Controls.MetroTextBox sifreTxt;
        private MetroFramework.Controls.MetroTextBox tcTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}