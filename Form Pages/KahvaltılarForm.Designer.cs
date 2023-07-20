
namespace KafeOtomasyonu
{
    partial class KahvaltilarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KahvaltilarForm));
            this.split2Kahvalti = new System.Windows.Forms.SplitContainer();
            this.dgwKahvalti = new System.Windows.Forms.DataGridView();
            this.btnMenuDon = new System.Windows.Forms.Button();
            this.lblSimitKah = new System.Windows.Forms.Label();
            this.lblTekKah = new System.Windows.Forms.Label();
            this.lblSerpme = new System.Windows.Forms.Label();
            this.btnSimitKah = new System.Windows.Forms.Button();
            this.btnTekKah = new System.Windows.Forms.Button();
            this.btnSerpmeKah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.split2Kahvalti)).BeginInit();
            this.split2Kahvalti.Panel1.SuspendLayout();
            this.split2Kahvalti.Panel2.SuspendLayout();
            this.split2Kahvalti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKahvalti)).BeginInit();
            this.SuspendLayout();
            // 
            // split2Kahvalti
            // 
            this.split2Kahvalti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split2Kahvalti.Location = new System.Drawing.Point(0, 0);
            this.split2Kahvalti.Name = "split2Kahvalti";
            // 
            // split2Kahvalti.Panel1
            // 
            this.split2Kahvalti.Panel1.Controls.Add(this.dgwKahvalti);
            // 
            // split2Kahvalti.Panel2
            // 
            this.split2Kahvalti.Panel2.Controls.Add(this.btnMenuDon);
            this.split2Kahvalti.Panel2.Controls.Add(this.lblSimitKah);
            this.split2Kahvalti.Panel2.Controls.Add(this.lblTekKah);
            this.split2Kahvalti.Panel2.Controls.Add(this.lblSerpme);
            this.split2Kahvalti.Panel2.Controls.Add(this.btnSimitKah);
            this.split2Kahvalti.Panel2.Controls.Add(this.btnTekKah);
            this.split2Kahvalti.Panel2.Controls.Add(this.btnSerpmeKah);
            this.split2Kahvalti.Size = new System.Drawing.Size(1255, 657);
            this.split2Kahvalti.SplitterDistance = 326;
            this.split2Kahvalti.TabIndex = 0;
            // 
            // dgwKahvalti
            // 
            this.dgwKahvalti.BackgroundColor = System.Drawing.Color.Snow;
            this.dgwKahvalti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKahvalti.Location = new System.Drawing.Point(12, 12);
            this.dgwKahvalti.Name = "dgwKahvalti";
            this.dgwKahvalti.RowHeadersWidth = 62;
            this.dgwKahvalti.RowTemplate.Height = 28;
            this.dgwKahvalti.Size = new System.Drawing.Size(297, 503);
            this.dgwKahvalti.TabIndex = 0;
            // 
            // btnMenuDon
            // 
            this.btnMenuDon.BackColor = System.Drawing.Color.Snow;
            this.btnMenuDon.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnMenuDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenuDon.Location = new System.Drawing.Point(775, 595);
            this.btnMenuDon.Name = "btnMenuDon";
            this.btnMenuDon.Size = new System.Drawing.Size(138, 50);
            this.btnMenuDon.TabIndex = 6;
            this.btnMenuDon.Text = "Geri";
            this.btnMenuDon.UseVisualStyleBackColor = false;
            this.btnMenuDon.Click += new System.EventHandler(this.btnMenuDon_Click);
            // 
            // lblSimitKah
            // 
            this.lblSimitKah.AutoSize = true;
            this.lblSimitKah.BackColor = System.Drawing.Color.Snow;
            this.lblSimitKah.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lblSimitKah.Location = new System.Drawing.Point(462, 165);
            this.lblSimitKah.Name = "lblSimitKah";
            this.lblSimitKah.Size = new System.Drawing.Size(34, 23);
            this.lblSimitKah.TabIndex = 5;
            this.lblSimitKah.Text = "80";
            // 
            // lblTekKah
            // 
            this.lblTekKah.AutoSize = true;
            this.lblTekKah.BackColor = System.Drawing.Color.Snow;
            this.lblTekKah.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lblTekKah.Location = new System.Drawing.Point(268, 165);
            this.lblTekKah.Name = "lblTekKah";
            this.lblTekKah.Size = new System.Drawing.Size(46, 23);
            this.lblTekKah.TabIndex = 4;
            this.lblTekKah.Text = "120";
            // 
            // lblSerpme
            // 
            this.lblSerpme.AutoSize = true;
            this.lblSerpme.BackColor = System.Drawing.Color.Snow;
            this.lblSerpme.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lblSerpme.Location = new System.Drawing.Point(80, 165);
            this.lblSerpme.Name = "lblSerpme";
            this.lblSerpme.Size = new System.Drawing.Size(46, 23);
            this.lblSerpme.TabIndex = 3;
            this.lblSerpme.Text = "250";
            // 
            // btnSimitKah
            // 
            this.btnSimitKah.BackColor = System.Drawing.Color.Snow;
            this.btnSimitKah.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimitKah.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSimitKah.Location = new System.Drawing.Point(388, 12);
            this.btnSimitKah.Name = "btnSimitKah";
            this.btnSimitKah.Size = new System.Drawing.Size(182, 149);
            this.btnSimitKah.TabIndex = 2;
            this.btnSimitKah.Text = "Simitli Kahvaltı";
            this.btnSimitKah.UseVisualStyleBackColor = false;
            this.btnSimitKah.Click += new System.EventHandler(this.btnSimitKah_Click);
            // 
            // btnTekKah
            // 
            this.btnTekKah.BackColor = System.Drawing.Color.Snow;
            this.btnTekKah.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnTekKah.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTekKah.Location = new System.Drawing.Point(200, 12);
            this.btnTekKah.Name = "btnTekKah";
            this.btnTekKah.Size = new System.Drawing.Size(182, 149);
            this.btnTekKah.TabIndex = 1;
            this.btnTekKah.Text = "Tek Kişilik Kahvaltı";
            this.btnTekKah.UseVisualStyleBackColor = false;
            this.btnTekKah.Click += new System.EventHandler(this.btnTekKah_Click);
            // 
            // btnSerpmeKah
            // 
            this.btnSerpmeKah.BackColor = System.Drawing.Color.Snow;
            this.btnSerpmeKah.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSerpmeKah.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnSerpmeKah.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSerpmeKah.Location = new System.Drawing.Point(12, 12);
            this.btnSerpmeKah.Name = "btnSerpmeKah";
            this.btnSerpmeKah.Size = new System.Drawing.Size(182, 149);
            this.btnSerpmeKah.TabIndex = 0;
            this.btnSerpmeKah.Text = "Serpme Kahvaltı";
            this.btnSerpmeKah.UseVisualStyleBackColor = false;
            this.btnSerpmeKah.Click += new System.EventHandler(this.btnSerpmeKah_Click);
            // 
            // KahvaltilarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1255, 657);
            this.Controls.Add(this.split2Kahvalti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KahvaltilarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kahvaltılar";
            this.Load += new System.EventHandler(this.KahvaltilarForm_Load);
            this.split2Kahvalti.Panel1.ResumeLayout(false);
            this.split2Kahvalti.Panel2.ResumeLayout(false);
            this.split2Kahvalti.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split2Kahvalti)).EndInit();
            this.split2Kahvalti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKahvalti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split2Kahvalti;
        private System.Windows.Forms.DataGridView dgwKahvalti;
        private System.Windows.Forms.Label lblSimitKah;
        private System.Windows.Forms.Label lblTekKah;
        private System.Windows.Forms.Label lblSerpme;
        private System.Windows.Forms.Button btnSimitKah;
        private System.Windows.Forms.Button btnTekKah;
        private System.Windows.Forms.Button btnSerpmeKah;
        private System.Windows.Forms.Button btnMenuDon;
    }
}