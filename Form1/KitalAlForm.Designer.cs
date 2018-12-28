namespace Form1
{
    partial class KitalAlForm
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
            this.lstUyeler = new System.Windows.Forms.ListBox();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.cmbKitaplar = new System.Windows.Forms.ComboBox();
            this.btnKitapAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUyeler
            // 
            this.lstUyeler.FormattingEnabled = true;
            this.lstUyeler.Location = new System.Drawing.Point(59, 86);
            this.lstUyeler.Name = "lstUyeler";
            this.lstUyeler.Size = new System.Drawing.Size(120, 212);
            this.lstUyeler.TabIndex = 0;
            // 
            // cmbTurler
            // 
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(276, 27);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(121, 21);
            this.cmbTurler.TabIndex = 1;
            // 
            // cmbKitaplar
            // 
            this.cmbKitaplar.FormattingEnabled = true;
            this.cmbKitaplar.Location = new System.Drawing.Point(459, 27);
            this.cmbKitaplar.Name = "cmbKitaplar";
            this.cmbKitaplar.Size = new System.Drawing.Size(121, 21);
            this.cmbKitaplar.TabIndex = 2;
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.Location = new System.Drawing.Point(533, 126);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(75, 23);
            this.btnKitapAl.TabIndex = 3;
            this.btnKitapAl.Text = "KitapAl";
            this.btnKitapAl.UseVisualStyleBackColor = true;
            // 
            // KitalAlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKitapAl);
            this.Controls.Add(this.cmbKitaplar);
            this.Controls.Add(this.cmbTurler);
            this.Controls.Add(this.lstUyeler);
            this.Name = "KitalAlForm";
            this.Text = "KitalAlForm";
            this.Load += new System.EventHandler(this.KitalAlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUyeler;
        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.ComboBox cmbKitaplar;
        private System.Windows.Forms.Button btnKitapAl;
    }
}