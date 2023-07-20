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
    public partial class SogukIceceklerForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public SogukIceceklerForm()
        {
            InitializeComponent();
        }

        private void btnMenuDon12_Click(object sender, EventArgs e) //Menuye geri dönmek için
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void SogukIceceklerForm_Load(object sender, EventArgs e)
        {
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSu_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSu.Text, Convert.ToInt32(lblSu.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnIcedMocha_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnIcedMocha.Text, Convert.ToInt32(lblIcedMocha.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnIcedLatte_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnIcedLatte.Text, Convert.ToInt32(lblIcedLatte.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnIcedCapp_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnIcedCapp.Text, Convert.ToInt32(lblIcedCapp.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnIcedEspresso_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnIcedEspresso.Text, Convert.ToInt32(lblIcedEspresso.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnCilekMilks_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnCilekMilks.Text, Convert.ToInt32(lblCilekMilks.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnCikoMilks_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnCikoMilks.Text, Convert.ToInt32(lblCikoMilks.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnVanilyaMilks_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnVanilyaMilks.Text, Convert.ToInt32(lblVanilyaMilks.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnOreoMilks_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnOreoMilks.Text, Convert.ToInt32(lblOreoMilks.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnLimonata_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnLimonata.Text, Convert.ToInt32(lblLimonata.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnPortakalSu_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnPortakalSu.Text, Convert.ToInt32(lblPortakalSu.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnAtom_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnAtom.Text, Convert.ToInt32(lblAtom.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnCola.Text, Convert.ToInt32(lblCola.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnFanta.Text, Convert.ToInt32(lblFanta.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSprite_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSprite.Text, Convert.ToInt32(lblSprite.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnIceTeaSef_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnIceTeaSef.Text, Convert.ToInt32(lblIceTeaSef.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnIceTeaLim_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnIceTeaLim.Text, Convert.ToInt32(lblIceTeaLim.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSadeSoda_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSadeSoda.Text, Convert.ToInt32(lblSadeSoda.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnMeyveSoda_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnMeyveSoda.Text, Convert.ToInt32(lblMeyveSoda.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnRedbull_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnRedbull.Text, Convert.ToInt32(lblRedbull.Text));
            dgwSogukI.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
