namespace Form1
{
    partial class YazarEkleForm
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
            this.btnKitapAta = new System.Windows.Forms.Button();
            this.chklbKitaplar = new System.Windows.Forms.CheckedListBox();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnKitapAta
            // 
            this.btnKitapAta.Location = new System.Drawing.Point(154, 210);
            this.btnKitapAta.Name = "btnKitapAta";
            this.btnKitapAta.Size = new System.Drawing.Size(75, 23);
            this.btnKitapAta.TabIndex = 0;
            this.btnKitapAta.Text = "KitapAta";
            this.btnKitapAta.UseVisualStyleBackColor = true;
            this.btnKitapAta.Click += new System.EventHandler(this.btnKitapAta_Click);
            // 
            // chklbKitaplar
            // 
            this.chklbKitaplar.FormattingEnabled = true;
            this.chklbKitaplar.Location = new System.Drawing.Point(389, 68);
            this.chklbKitaplar.Name = "chklbKitaplar";
            this.chklbKitaplar.Size = new System.Drawing.Size(120, 94);
            this.chklbKitaplar.TabIndex = 1;
            // 
            // cmbTurler
            // 
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(54, 47);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(121, 21);
            this.cmbTurler.TabIndex = 2;
            this.cmbTurler.SelectedIndexChanged += new System.EventHandler(this.cmbTurler_SelectedIndexChanged);
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.Location = new System.Drawing.Point(238, 54);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(97, 108);
            this.lstYazarlar.TabIndex = 3;
            // 
            // YazarEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstYazarlar);
            this.Controls.Add(this.cmbTurler);
            this.Controls.Add(this.chklbKitaplar);
            this.Controls.Add(this.btnKitapAta);
            this.Name = "YazarEkleForm";
            this.Text = "YazarEkleForm";
            this.Load += new System.EventHandler(this.YazarEkleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitapAta;
        private System.Windows.Forms.CheckedListBox chklbKitaplar;
        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.ListBox lstYazarlar;
    }
}