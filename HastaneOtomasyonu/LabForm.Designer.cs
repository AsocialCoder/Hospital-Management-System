namespace HastaneOtomasyonu
{
    partial class LabForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabForm));
            this.labDatagrid = new System.Windows.Forms.DataGridView();
            this.labcontext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sonuçYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.labDatagrid)).BeginInit();
            this.labcontext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labDatagrid
            // 
            this.labDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labDatagrid.ContextMenuStrip = this.labcontext;
            this.labDatagrid.Location = new System.Drawing.Point(23, 86);
            this.labDatagrid.Name = "labDatagrid";
            this.labDatagrid.ReadOnly = true;
            this.labDatagrid.Size = new System.Drawing.Size(802, 296);
            this.labDatagrid.TabIndex = 0;
            // 
            // labcontext
            // 
            this.labcontext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sonuçYükleToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.labcontext.Name = "labcontext";
            this.labcontext.Size = new System.Drawing.Size(139, 48);
            // 
            // sonuçYükleToolStripMenuItem
            // 
            this.sonuçYükleToolStripMenuItem.Name = "sonuçYükleToolStripMenuItem";
            this.sonuçYükleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sonuçYükleToolStripMenuItem.Text = "Sonuç yükle";
            this.sonuçYükleToolStripMenuItem.Click += new System.EventHandler(this.sonuçYükleToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(737, 396);
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
            // LabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 437);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labDatagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LabForm";
            this.Text = "LabForm";
            this.Load += new System.EventHandler(this.LabForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labDatagrid)).EndInit();
            this.labcontext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView labDatagrid;
        private System.Windows.Forms.ContextMenuStrip labcontext;
        private System.Windows.Forms.ToolStripMenuItem sonuçYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}