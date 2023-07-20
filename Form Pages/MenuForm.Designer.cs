
namespace KafeOtomasyonu
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.split1Menu = new System.Windows.Forms.SplitContainer();
            this.btnMasayaDon = new System.Windows.Forms.Button();
            this.dgwMenu = new System.Windows.Forms.DataGridView();
            this.btnSoguk = new System.Windows.Forms.Button();
            this.btnSicak = new System.Windows.Forms.Button();
            this.btnTatli = new System.Windows.Forms.Button();
            this.btnSalata = new System.Windows.Forms.Button();
            this.btnIzgara = new System.Windows.Forms.Button();
            this.btnMakarna = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnSandwich = new System.Windows.Forms.Button();
            this.btnWrap = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.btnTost = new System.Windows.Forms.Button();
            this.btnKahvalti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.split1Menu)).BeginInit();
            this.split1Menu.Panel1.SuspendLayout();
            this.split1Menu.Panel2.SuspendLayout();
            this.split1Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // split1Menu
            // 
            this.split1Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split1Menu.Location = new System.Drawing.Point(0, 0);
            this.split1Menu.Name = "split1Menu";
            // 
            // split1Menu.Panel1
            // 
            this.split1Menu.Panel1.Controls.Add(this.dgwMenu);
            // 
            // split1Menu.Panel2
            // 
            this.split1Menu.Panel2.Controls.Add(this.btnMasayaDon);
            this.split1Menu.Panel2.Controls.Add(this.btnSoguk);
            this.split1Menu.Panel2.Controls.Add(this.btnSicak);
            this.split1Menu.Panel2.Controls.Add(this.btnTatli);
            this.split1Menu.Panel2.Controls.Add(this.btnSalata);
            this.split1Menu.Panel2.Controls.Add(this.btnIzgara);
            this.split1Menu.Panel2.Controls.Add(this.btnMakarna);
            this.split1Menu.Panel2.Controls.Add(this.btnPizza);
            this.split1Menu.Panel2.Controls.Add(this.btnSandwich);
            this.split1Menu.Panel2.Controls.Add(this.btnWrap);
            this.split1Menu.Panel2.Controls.Add(this.btnBurger);
            this.split1Menu.Panel2.Controls.Add(this.btnTost);
            this.split1Menu.Panel2.Controls.Add(this.btnKahvalti);
            this.split1Menu.Size = new System.Drawing.Size(1255, 657);
            this.split1Menu.SplitterDistance = 326;
            this.split1Menu.TabIndex = 7;
            // 
            // btnMasayaDon
            // 
            this.btnMasayaDon.BackColor = System.Drawing.Color.Snow;
            this.btnMasayaDon.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnMasayaDon.Location = new System.Drawing.Point(775, 595);
            this.btnMasayaDon.Name = "btnMasayaDon";
            this.btnMasayaDon.Size = new System.Drawing.Size(138, 50);
            this.btnMasayaDon.TabIndex = 1;
            this.btnMasayaDon.Text = "Geri";
            this.btnMasayaDon.UseVisualStyleBackColor = false;
            this.btnMasayaDon.Click += new System.EventHandler(this.btnMasayaDon_Click);
            // 
            // dgwMenu
            // 
            this.dgwMenu.BackgroundColor = System.Drawing.Color.Snow;
            this.dgwMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMenu.Location = new System.Drawing.Point(12, 12);
            this.dgwMenu.Name = "dgwMenu";
            this.dgwMenu.RowHeadersWidth = 62;
            this.dgwMenu.RowTemplate.Height = 28;
            this.dgwMenu.Size = new System.Drawing.Size(297, 503);
            this.dgwMenu.TabIndex = 0;
            // 
            // btnSoguk
            // 
            this.btnSoguk.BackColor = System.Drawing.Color.Snow;
            this.btnSoguk.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnSoguk.Location = new System.Drawing.Point(687, 398);
            this.btnSoguk.Name = "btnSoguk";
            this.btnSoguk.Size = new System.Drawing.Size(209, 176);
            this.btnSoguk.TabIndex = 12;
            this.btnSoguk.Text = "Soğuk İçecekler";
            this.btnSoguk.UseVisualStyleBackColor = false;
            this.btnSoguk.Click += new System.EventHandler(this.btnSoguk_Click);
            // 
            // btnSicak
            // 
            this.btnSicak.BackColor = System.Drawing.Color.Snow;
            this.btnSicak.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnSicak.Location = new System.Drawing.Point(458, 398);
            this.btnSicak.Name = "btnSicak";
            this.btnSicak.Size = new System.Drawing.Size(209, 176);
            this.btnSicak.TabIndex = 11;
            this.btnSicak.Text = "Sıcak İçecekler";
            this.btnSicak.UseVisualStyleBackColor = false;
            this.btnSicak.Click += new System.EventHandler(this.btnSicak_Click);
            // 
            // btnTatli
            // 
            this.btnTatli.BackColor = System.Drawing.Color.Snow;
            this.btnTatli.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnTatli.Location = new System.Drawing.Point(232, 398);
            this.btnTatli.Name = "btnTatli";
            this.btnTatli.Size = new System.Drawing.Size(209, 176);
            this.btnTatli.TabIndex = 10;
            this.btnTatli.Text = "Tatlılar";
            this.btnTatli.UseVisualStyleBackColor = false;
            this.btnTatli.Click += new System.EventHandler(this.btnTatli_Click);
            // 
            // btnSalata
            // 
            this.btnSalata.BackColor = System.Drawing.Color.Snow;
            this.btnSalata.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalata.Location = new System.Drawing.Point(3, 398);
            this.btnSalata.Name = "btnSalata";
            this.btnSalata.Size = new System.Drawing.Size(209, 176);
            this.btnSalata.TabIndex = 9;
            this.btnSalata.Text = "Salatalar";
            this.btnSalata.UseVisualStyleBackColor = false;
            this.btnSalata.Click += new System.EventHandler(this.btnSalata_Click);
            // 
            // btnIzgara
            // 
            this.btnIzgara.BackColor = System.Drawing.Color.Snow;
            this.btnIzgara.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnIzgara.Location = new System.Drawing.Point(687, 206);
            this.btnIzgara.Name = "btnIzgara";
            this.btnIzgara.Size = new System.Drawing.Size(209, 176);
            this.btnIzgara.TabIndex = 8;
            this.btnIzgara.Text = "Izgaralar";
            this.btnIzgara.UseVisualStyleBackColor = false;
            this.btnIzgara.Click += new System.EventHandler(this.btnIzgara_Click);
            // 
            // btnMakarna
            // 
            this.btnMakarna.BackColor = System.Drawing.Color.Snow;
            this.btnMakarna.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnMakarna.Location = new System.Drawing.Point(458, 206);
            this.btnMakarna.Name = "btnMakarna";
            this.btnMakarna.Size = new System.Drawing.Size(209, 176);
            this.btnMakarna.TabIndex = 7;
            this.btnMakarna.Text = "Makarnalar";
            this.btnMakarna.UseVisualStyleBackColor = false;
            this.btnMakarna.Click += new System.EventHandler(this.btnMakarna_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.BackColor = System.Drawing.Color.Snow;
            this.btnPizza.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnPizza.Location = new System.Drawing.Point(232, 206);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(209, 176);
            this.btnPizza.TabIndex = 6;
            this.btnPizza.Text = "Pizzalar";
            this.btnPizza.UseVisualStyleBackColor = false;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnSandwich
            // 
            this.btnSandwich.BackColor = System.Drawing.Color.Snow;
            this.btnSandwich.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnSandwich.Location = new System.Drawing.Point(3, 206);
            this.btnSandwich.Name = "btnSandwich";
            this.btnSandwich.Size = new System.Drawing.Size(209, 176);
            this.btnSandwich.TabIndex = 5;
            this.btnSandwich.Text = "Sandwichler";
            this.btnSandwich.UseVisualStyleBackColor = false;
            this.btnSandwich.Click += new System.EventHandler(this.btnSandwich_Click);
            // 
            // btnWrap
            // 
            this.btnWrap.BackColor = System.Drawing.Color.Snow;
            this.btnWrap.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnWrap.Location = new System.Drawing.Point(687, 12);
            this.btnWrap.Name = "btnWrap";
            this.btnWrap.Size = new System.Drawing.Size(209, 176);
            this.btnWrap.TabIndex = 4;
            this.btnWrap.Text = "Wrapler";
            this.btnWrap.UseVisualStyleBackColor = false;
            this.btnWrap.Click += new System.EventHandler(this.btnWrap_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.BackColor = System.Drawing.Color.Snow;
            this.btnBurger.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnBurger.Location = new System.Drawing.Point(458, 12);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(209, 176);
            this.btnBurger.TabIndex = 3;
            this.btnBurger.Text = "Burgerler";
            this.btnBurger.UseVisualStyleBackColor = false;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // btnTost
            // 
            this.btnTost.BackColor = System.Drawing.Color.Snow;
            this.btnTost.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnTost.Location = new System.Drawing.Point(232, 12);
            this.btnTost.Name = "btnTost";
            this.btnTost.Size = new System.Drawing.Size(209, 176);
            this.btnTost.TabIndex = 2;
            this.btnTost.Text = "Tostlar";
            this.btnTost.UseVisualStyleBackColor = false;
            this.btnTost.Click += new System.EventHandler(this.btnTost_Click);
            // 
            // btnKahvalti
            // 
            this.btnKahvalti.BackColor = System.Drawing.Color.Snow;
            this.btnKahvalti.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnKahvalti.Location = new System.Drawing.Point(3, 12);
            this.btnKahvalti.Name = "btnKahvalti";
            this.btnKahvalti.Size = new System.Drawing.Size(209, 176);
            this.btnKahvalti.TabIndex = 1;
            this.btnKahvalti.Text = "Kahvaltılar";
            this.btnKahvalti.UseVisualStyleBackColor = false;
            this.btnKahvalti.Click += new System.EventHandler(this.btnKahvalti_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1255, 657);
            this.Controls.Add(this.split1Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.split1Menu.Panel1.ResumeLayout(false);
            this.split1Menu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split1Menu)).EndInit();
            this.split1Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer split1Menu;
        private System.Windows.Forms.DataGridView dgwMenu;
        private System.Windows.Forms.Button btnSoguk;
        private System.Windows.Forms.Button btnSicak;
        private System.Windows.Forms.Button btnTatli;
        private System.Windows.Forms.Button btnSalata;
        private System.Windows.Forms.Button btnIzgara;
        private System.Windows.Forms.Button btnMakarna;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnSandwich;
        private System.Windows.Forms.Button btnWrap;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Button btnTost;
        private System.Windows.Forms.Button btnKahvalti;
        private System.Windows.Forms.Button btnMasayaDon;
    }
}