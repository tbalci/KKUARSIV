namespace KKU.Arsiv.App
{
    partial class FrmMain
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
            this.grpKontroller = new System.Windows.Forms.GroupBox();
            this.lblDosya = new System.Windows.Forms.Label();
            this.txtYol = new System.Windows.Forms.TextBox();
            this.BtnSec = new System.Windows.Forms.Button();
            this.grdListe = new System.Windows.Forms.DataGridView();
            this.DrpSayfaListesi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKontroller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKontroller
            // 
            this.grpKontroller.Controls.Add(this.label1);
            this.grpKontroller.Controls.Add(this.DrpSayfaListesi);
            this.grpKontroller.Controls.Add(this.BtnSec);
            this.grpKontroller.Controls.Add(this.txtYol);
            this.grpKontroller.Controls.Add(this.lblDosya);
            this.grpKontroller.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKontroller.Location = new System.Drawing.Point(0, 0);
            this.grpKontroller.Name = "grpKontroller";
            this.grpKontroller.Size = new System.Drawing.Size(964, 85);
            this.grpKontroller.TabIndex = 0;
            this.grpKontroller.TabStop = false;
            this.grpKontroller.Text = "Dosya Seçimi";
            // 
            // lblDosya
            // 
            this.lblDosya.AutoSize = true;
            this.lblDosya.Location = new System.Drawing.Point(13, 27);
            this.lblDosya.Name = "lblDosya";
            this.lblDosya.Size = new System.Drawing.Size(43, 13);
            this.lblDosya.TabIndex = 0;
            this.lblDosya.Text = "Dosya :";
            // 
            // txtYol
            // 
            this.txtYol.Enabled = false;
            this.txtYol.Location = new System.Drawing.Point(83, 24);
            this.txtYol.Name = "txtYol";
            this.txtYol.ReadOnly = true;
            this.txtYol.Size = new System.Drawing.Size(689, 20);
            this.txtYol.TabIndex = 1;
            // 
            // BtnSec
            // 
            this.BtnSec.Location = new System.Drawing.Point(778, 10);
            this.BtnSec.Name = "BtnSec";
            this.BtnSec.Size = new System.Drawing.Size(180, 35);
            this.BtnSec.TabIndex = 2;
            this.BtnSec.Text = "Seç";
            this.BtnSec.UseVisualStyleBackColor = true;
            this.BtnSec.Click += new System.EventHandler(this.BtnSec_Click);
            // 
            // grdListe
            // 
            this.grdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListe.Location = new System.Drawing.Point(0, 85);
            this.grdListe.Name = "grdListe";
            this.grdListe.Size = new System.Drawing.Size(964, 574);
            this.grdListe.TabIndex = 1;
            // 
            // DrpSayfaListesi
            // 
            this.DrpSayfaListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpSayfaListesi.FormattingEnabled = true;
            this.DrpSayfaListesi.Location = new System.Drawing.Point(83, 51);
            this.DrpSayfaListesi.Name = "DrpSayfaListesi";
            this.DrpSayfaListesi.Size = new System.Drawing.Size(689, 21);
            this.DrpSayfaListesi.TabIndex = 3;
            this.DrpSayfaListesi.SelectedIndexChanged += new System.EventHandler(this.DrpSayfaListesi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sayfalar";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 659);
            this.Controls.Add(this.grdListe);
            this.Controls.Add(this.grpKontroller);
            this.Name = "FrmMain";
            this.Text = "KKU Arşiv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpKontroller.ResumeLayout(false);
            this.grpKontroller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKontroller;
        private System.Windows.Forms.Button BtnSec;
        private System.Windows.Forms.TextBox txtYol;
        private System.Windows.Forms.Label lblDosya;
        private System.Windows.Forms.DataGridView grdListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DrpSayfaListesi;
    }
}

