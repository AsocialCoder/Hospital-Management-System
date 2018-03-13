namespace HastaneOtomasyonu
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.poliklinikCmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.soyadTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.adTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tcTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // poliklinikCmb
            // 
            this.poliklinikCmb.FormattingEnabled = true;
            this.poliklinikCmb.ItemHeight = 23;
            this.poliklinikCmb.Location = new System.Drawing.Point(355, 249);
            this.poliklinikCmb.Margin = new System.Windows.Forms.Padding(2);
            this.poliklinikCmb.Name = "poliklinikCmb";
            this.poliklinikCmb.Size = new System.Drawing.Size(158, 29);
            this.poliklinikCmb.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(208, 249);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Poliklinik:";
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(355, 213);
            this.soyadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(158, 19);
            this.soyadTxt.TabIndex = 2;
            this.soyadTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyadTxt_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(208, 208);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Soyad:";
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(355, 171);
            this.adTxt.Margin = new System.Windows.Forms.Padding(2);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(158, 19);
            this.adTxt.TabIndex = 1;
            this.adTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adTxt_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(208, 166);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Ad :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(208, 123);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "TC Kimlik No:";
            // 
            // tcTxt
            // 
            this.tcTxt.Location = new System.Drawing.Point(355, 126);
            this.tcTxt.Margin = new System.Windows.Forms.Padding(2);
            this.tcTxt.MaxLength = 11;
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Size = new System.Drawing.Size(158, 19);
            this.tcTxt.TabIndex = 0;
            this.tcTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcTxt_KeyPress);
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(32, 281);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(123, 58);
            this.metroTile3.TabIndex = 15;
            this.metroTile3.Text = "Laborant Ekle";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(32, 200);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(123, 58);
            this.metroTile2.TabIndex = 13;
            this.metroTile2.Text = "Sekreter Ekle";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(32, 120);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(123, 56);
            this.metroTile1.TabIndex = 11;
            this.metroTile1.Text = "Doktor Ekle";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(490, 363);
            this.metroTile4.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(75, 36);
            this.metroTile4.TabIndex = 21;
            this.metroTile4.Text = "Çıkış";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 403);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.poliklinikCmb);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tcTxt);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox poliklinikCmb;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox soyadTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox adTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tcTxt;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}