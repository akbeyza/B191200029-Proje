namespace OtelOtomasyonu
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
            this.MenuTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.Kapat = new System.Windows.Forms.PictureBox();
            this.Buyult = new System.Windows.Forms.PictureBox();
            this.Kucult = new System.Windows.Forms.PictureBox();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.MenuTop.SuspendLayout();
            this.SidebarWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buyult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.Kapat);
            this.MenuTop.Controls.Add(this.Buyult);
            this.MenuTop.Controls.Add(this.Kucult);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Margin = new System.Windows.Forms.Padding(2);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(650, 42);
            this.MenuTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.button4);
            this.SidebarWrapper.Controls.Add(this.button3);
            this.SidebarWrapper.Controls.Add(this.button2);
            this.SidebarWrapper.Controls.Add(this.button1);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 42);
            this.SidebarWrapper.Margin = new System.Windows.Forms.Padding(2);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(150, 384);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 141);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(150, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "GAZETE OKU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 47);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(150, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "ODALAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 94);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(150, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "MÜŞTERİ BİLGİLERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(150, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "YENİ MÜŞTERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(150, 42);
            this.Wrapper.Margin = new System.Windows.Forms.Padding(2);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(500, 384);
            this.Wrapper.TabIndex = 2;
            this.Wrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.Wrapper_Paint);
            // 
            // Kapat
            // 
            this.Kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Kapat.Image = global::OtelOtomasyonu.Properties.Resources.close_1__1_;
            this.Kapat.Location = new System.Drawing.Point(614, 11);
            this.Kapat.Margin = new System.Windows.Forms.Padding(2);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(16, 20);
            this.Kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kapat.TabIndex = 4;
            this.Kapat.TabStop = false;
            this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
            // 
            // Buyult
            // 
            this.Buyult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buyult.Image = global::OtelOtomasyonu.Properties.Resources.size;
            this.Buyult.Location = new System.Drawing.Point(590, 11);
            this.Buyult.Margin = new System.Windows.Forms.Padding(2);
            this.Buyult.Name = "Buyult";
            this.Buyult.Size = new System.Drawing.Size(16, 20);
            this.Buyult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Buyult.TabIndex = 3;
            this.Buyult.TabStop = false;
            this.Buyult.Click += new System.EventHandler(this.Buyult_Click);
            // 
            // Kucult
            // 
            this.Kucult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Kucult.Image = global::OtelOtomasyonu.Properties.Resources.minimize_21;
            this.Kucult.Location = new System.Drawing.Point(564, 11);
            this.Kucult.Margin = new System.Windows.Forms.Padding(2);
            this.Kucult.Name = "Kucult";
            this.Kucult.Size = new System.Drawing.Size(16, 20);
            this.Kucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kucult.TabIndex = 2;
            this.Kucult.TabStop = false;
            this.Kucult.Click += new System.EventHandler(this.Kucult_Click);
            // 
            // MenuSidebar
            // 
            this.MenuSidebar.Image = global::OtelOtomasyonu.Properties.Resources.menu;
            this.MenuSidebar.Location = new System.Drawing.Point(12, 11);
            this.MenuSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(16, 20);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 426);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            this.SidebarWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buyult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.PictureBox Kucult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Kapat;
        private System.Windows.Forms.PictureBox Buyult;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

