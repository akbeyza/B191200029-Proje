namespace OtelOtomasyonu
{
    partial class frmGazeteOku
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.milliyetSonDakikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hürriyetSonDakikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vatanGazetesiSonDakikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sabahSonDakikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGazete = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.milliyetSonDakikaToolStripMenuItem,
            this.hürriyetSonDakikaToolStripMenuItem,
            this.vatanGazetesiSonDakikaToolStripMenuItem,
            this.sabahSonDakikaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // milliyetSonDakikaToolStripMenuItem
            // 
            this.milliyetSonDakikaToolStripMenuItem.Name = "milliyetSonDakikaToolStripMenuItem";
            this.milliyetSonDakikaToolStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.milliyetSonDakikaToolStripMenuItem.Text = "Milliyet Son Dakika";
            this.milliyetSonDakikaToolStripMenuItem.Click += new System.EventHandler(this.milliyetSonDakikaToolStripMenuItem_Click);
            // 
            // hürriyetSonDakikaToolStripMenuItem
            // 
            this.hürriyetSonDakikaToolStripMenuItem.Name = "hürriyetSonDakikaToolStripMenuItem";
            this.hürriyetSonDakikaToolStripMenuItem.Size = new System.Drawing.Size(247, 36);
            this.hürriyetSonDakikaToolStripMenuItem.Text = "Hürriyet Son Dakika";
            this.hürriyetSonDakikaToolStripMenuItem.Click += new System.EventHandler(this.hürriyetSonDakikaToolStripMenuItem_Click);
            // 
            // vatanGazetesiSonDakikaToolStripMenuItem
            // 
            this.vatanGazetesiSonDakikaToolStripMenuItem.Name = "vatanGazetesiSonDakikaToolStripMenuItem";
            this.vatanGazetesiSonDakikaToolStripMenuItem.Size = new System.Drawing.Size(220, 36);
            this.vatanGazetesiSonDakikaToolStripMenuItem.Text = "Vatan Son Dakika";
            this.vatanGazetesiSonDakikaToolStripMenuItem.Click += new System.EventHandler(this.vatanGazetesiSonDakikaToolStripMenuItem_Click);
            // 
            // sabahSonDakikaToolStripMenuItem
            // 
            this.sabahSonDakikaToolStripMenuItem.Name = "sabahSonDakikaToolStripMenuItem";
            this.sabahSonDakikaToolStripMenuItem.Size = new System.Drawing.Size(226, 36);
            this.sabahSonDakikaToolStripMenuItem.Text = "Sabah Son Dakika";
            this.sabahSonDakikaToolStripMenuItem.Click += new System.EventHandler(this.sabahSonDakikaToolStripMenuItem_Click);
            // 
            // pnlGazete
            // 
            this.pnlGazete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGazete.Location = new System.Drawing.Point(0, 44);
            this.pnlGazete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlGazete.Name = "pnlGazete";
            this.pnlGazete.Size = new System.Drawing.Size(968, 619);
            this.pnlGazete.TabIndex = 1;
            this.pnlGazete.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGazete_Paint);
            // 
            // frmGazeteOku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(968, 663);
            this.Controls.Add(this.pnlGazete);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmGazeteOku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gazete Okuma Sayfası";
            this.Load += new System.EventHandler(this.frmGazeteOku_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem milliyetSonDakikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hürriyetSonDakikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vatanGazetesiSonDakikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sabahSonDakikaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGazete;
    }
}