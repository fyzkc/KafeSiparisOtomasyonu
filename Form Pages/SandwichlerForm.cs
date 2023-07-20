using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KafeOtomasyonu.Entity;

namespace KafeOtomasyonu
{
    public partial class SandwichlerForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public SandwichlerForm()
        {
            InitializeComponent();
        }

        private void btnMenuDon5_Click(object sender, EventArgs e) //Menuye geri dönmek için
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void SandwichlerForm_Load(object sender, EventArgs e)
        {
            dgwSandwich.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSogukSand_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSogukSand.Text, Convert.ToInt32(lblSogukSand.Text));
            dgwSandwich.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnKofteSand_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnKofteSand.Text, Convert.ToInt32(lblKofteSand.Text));
            dgwSandwich.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSucukSand_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSucukSand.Text, Convert.ToInt32(lblSucukSand.Text));
            dgwSandwich.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnKumruSand_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnKumruSand.Text, Convert.ToInt32(lblKumruSand.Text));
            dgwSandwich.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
