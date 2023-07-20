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
    public partial class SicakIceceklerForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public SicakIceceklerForm()
        {
            InitializeComponent();
        }

        private void btnMenuDon11_Click(object sender, EventArgs e) //Menuye geri dönmek için
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void SicakIceceklerForm_Load(object sender, EventArgs e)
        {
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnCay_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnCay.Text, Convert.ToInt32(lblCay.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnMocha_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnMocha.Text, Convert.ToInt32(lblMocha.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnLatte.Text, Convert.ToInt32(lblLatte.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnCapp_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnCapp.Text, Convert.ToInt32(lblCapp.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnEspresso_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnEspresso.Text, Convert.ToInt32(lblEspresso.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnTurk_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnTurk.Text, Convert.ToInt32(lblTurk.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnDamlaTurk_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnDamlaTurk.Text, Convert.ToInt32(lblDamlaTurk.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnDibek_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnDibek.Text, Convert.ToInt32(lblDibek.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnMenengic_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnMenengic.Text, Convert.ToInt32(lblMenengic.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSahlep_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSahlep.Text, Convert.ToInt32(lblSahlep.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnBalliSut_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnBalliSut.Text, Convert.ToInt32(lblBalliSut.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSicakCiko_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSicakCiko.Text, Convert.ToInt32(lblSicakCiko.Text));
            dgwSicakI.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
