
namespace KafeOtomasyonu
{
    partial class KasaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasaForm));
            this.dgwKasa = new System.Windows.Forms.DataGridView();
            this.btnCikisKasa = new System.Windows.Forms.Button();
            this.btnMasayaDonKasa = new System.Windows.Forms.Button();
            this.btnSiparisiSil = new System.Windows.Forms.Button();
            this.txtSiparisiSil = new System.Windows.Forms.TextBox();
            this.lblSiparisiSil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKasa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKasa
            // 
            this.dgwKasa.BackgroundColor = System.Drawing.Color.Snow;
            this.dgwKasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKasa.Location = new System.Drawing.Point(12, 12);
            this.dgwKasa.Name = "dgwKasa";
            this.dgwKasa.RowHeadersWidth = 62;
            this.dgwKasa.RowTemplate.Height = 28;
            this.dgwKasa.Size = new System.Drawing.Size(1231, 523);
            this.dgwKasa.TabIndex = 0;
            // 
            // btnCikisKasa
            // 
            this.btnCikisKasa.BackColor = System.Drawing.Color.Snow;
            this.btnCikisKasa.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnCikisKasa.Location = new System.Drawing.Point(1086, 583);
            this.btnCikisKasa.Name = "btnCikisKasa";
            this.btnCikisKasa.Size = new System.Drawing.Size(135, 53);
            this.btnCikisKasa.TabIndex = 41;
            this.btnCikisKasa.Text = "Çıkış";
            this.btnCikisKasa.UseVisualStyleBackColor = false;
            this.btnCikisKasa.Click += new System.EventHandler(this.btnCikisKasa_Click);
            // 
            // btnMasayaDonKasa
            // 
            this.btnMasayaDonKasa.BackColor = System.Drawing.Color.Snow;
            this.btnMasayaDonKasa.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnMasayaDonKasa.Location = new System.Drawing.Point(930, 583);
            this.btnMasayaDonKasa.Name = "btnMasayaDonKasa";
            this.btnMasayaDonKasa.Size = new System.Drawing.Size(135, 53);
            this.btnMasayaDonKasa.TabIndex = 42;
            this.btnMasayaDonKasa.Text = "Geri";
            this.btnMasayaDonKasa.UseVisualStyleBackColor = false;
            this.btnMasayaDonKasa.Click += new System.EventHandler(this.btnMasayaDonKasa_Click);
            // 
            // btnSiparisiSil
            // 
            this.btnSiparisiSil.BackColor = System.Drawing.Color.Snow;
            this.btnSiparisiSil.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnSiparisiSil.Location = new System.Drawing.Point(338, 597);
            this.btnSiparisiSil.Name = "btnSiparisiSil";
            this.btnSiparisiSil.Size = new System.Drawing.Size(120, 48);
            this.btnSiparisiSil.TabIndex = 43;
            this.btnSiparisiSil.Text = "Siparişi sil";
            this.btnSiparisiSil.UseVisualStyleBackColor = false;
            this.btnSiparisiSil.Click += new System.EventHandler(this.btnSiparisiSil_Click);
            // 
            // txtSiparisiSil
            // 
            this.txtSiparisiSil.BackColor = System.Drawing.Color.Snow;
            this.txtSiparisiSil.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.txtSiparisiSil.Location = new System.Drawing.Point(47, 614);
            this.txtSiparisiSil.Name = "txtSiparisiSil";
            this.txtSiparisiSil.Size = new System.Drawing.Size(285, 31);
            this.txtSiparisiSil.TabIndex = 44;
            // 
            // lblSiparisiSil
            // 
            this.lblSiparisiSil.AutoSize = true;
            this.lblSiparisiSil.BackColor = System.Drawing.Color.RosyBrown;
            this.lblSiparisiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSiparisiSil.ForeColor = System.Drawing.Color.Snow;
            this.lblSiparisiSil.Location = new System.Drawing.Point(49, 556);
            this.lblSiparisiSil.Name = "lblSiparisiSil";
            this.lblSiparisiSil.Size = new System.Drawing.Size(460, 29);
            this.lblSiparisiSil.TabIndex = 45;
            this.lblSiparisiSil.Text = "Siparişi ödenen masanın numarasını girin:";
            // 
            // KasaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1255, 657);
            this.Controls.Add(this.lblSiparisiSil);
            this.Controls.Add(this.txtSiparisiSil);
            this.Controls.Add(this.btnSiparisiSil);
            this.Controls.Add(this.btnMasayaDonKasa);
            this.Controls.Add(this.btnCikisKasa);
            this.Controls.Add(this.dgwKasa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KasaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.KasaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCikisKasa;
        private System.Windows.Forms.Button btnMasayaDonKasa;
        private System.Windows.Forms.Button btnSiparisiSil;
        private System.Windows.Forms.Label lblSiparisiSil;
        internal System.Windows.Forms.TextBox txtSiparisiSil;
        public System.Windows.Forms.DataGridView dgwKasa;
    }
}