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
    public partial class BurgerlerForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public BurgerlerForm()
        {
            InitializeComponent();
        }

        private void btnMenuDon3_Click(object sender, EventArgs e) //Menuye geri dönmek için
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void btnCheeseBurger_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnCheeseBurger.Text, Convert.ToInt32(lblCheeseBurger.Text));
            dgwBurger.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnChickenBurger_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnChickenBurger.Text, Convert.ToInt32(lblChickenBurger.Text));
            dgwBurger.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnVeganBurger_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnVeganBurger.Text, Convert.ToInt32(lblVeganBurger.Text));
            dgwBurger.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnBarbekuBurger_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnBarbekuBurger.Text, Convert.ToInt32(lblBarbekuBurger.Text));
            dgwBurger.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnMantarBurger_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnMantarBurger.Text, Convert.ToInt32(lblMantarBurger.Text));
            dgwBurger.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnDubleBurger_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnDubleBurger.Text, Convert.ToInt32(lblDubleBurger.Text));
            dgwBurger.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnTripleBurger_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnTripleBurger.Text, Convert.ToInt32(lblTripleBurger.Text));
            dgwBurger.DataSource = c.SiparislerDBs.ToList();
        }

        private void BurgerlerForm_Load(object sender, EventArgs e)
        {
            dgwBurger.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
