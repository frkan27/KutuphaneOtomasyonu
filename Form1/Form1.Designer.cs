namespace Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtİşlemleriToolStripMenuItem,
            this.kitapİŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtİşlemleriToolStripMenuItem
            // 
            this.kayıtİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKayıtToolStripMenuItem,
            this.kitapKayıtToolStripMenuItem});
            this.kayıtİşlemleriToolStripMenuItem.Name = "kayıtİşlemleriToolStripMenuItem";
            this.kayıtİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.kayıtİşlemleriToolStripMenuItem.Text = "Kayıt İşlemleri";
            // 
            // öğrenciKayıtToolStripMenuItem
            // 
            this.öğrenciKayıtToolStripMenuItem.Name = "öğrenciKayıtToolStripMenuItem";
            this.öğrenciKayıtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciKayıtToolStripMenuItem.Text = "Öğrenci Kayıt";
            // 
            // kitapKayıtToolStripMenuItem
            // 
            this.kitapKayıtToolStripMenuItem.Name = "kitapKayıtToolStripMenuItem";
            this.kitapKayıtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitapKayıtToolStripMenuItem.Text = "Kitap Kayıt";
            // 
            // kitapİŞToolStripMenuItem
            // 
            this.kitapİŞToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapAlToolStripMenuItem});
            this.kitapİŞToolStripMenuItem.Name = "kitapİŞToolStripMenuItem";
            this.kitapİŞToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.kitapİŞToolStripMenuItem.Text = "Kitap İŞ";
            // 
            // kitapAlToolStripMenuItem
            // 
            this.kitapAlToolStripMenuItem.Name = "kitapAlToolStripMenuItem";
            this.kitapAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitapAlToolStripMenuItem.Text = "Kitap Al";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapAlToolStripMenuItem;
    }
}

