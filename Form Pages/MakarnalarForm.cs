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
    public partial class MakarnalarForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public MakarnalarForm()
        {
            InitializeComponent();
        }

        private void btnMenuDon7_Click(object sender, EventArgs e) //Menuye geri dönmek için
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void MakarnalarForm_Load(object sender, EventArgs e)
        {
            dgwMakarna.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSadeMakarna_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSadeMakarna.Text, Convert.ToInt32(lblSadeMakarna.Text));
            dgwMakarna.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnPenneArabiata_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnPenneArabiata.Text, Convert.ToInt32(lblPenneArabiata.Text));
            dgwMakarna.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnPesto_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnPesto.Text, Convert.ToInt32(lblPesto.Text));
            dgwMakarna.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnTavukluMakarna_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnTavukluMakarna.Text, Convert.ToInt32(lblTavukluMakarna.Text));
            dgwMakarna.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnTonMakarna_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnTonMakarna.Text, Convert.ToInt32(lblTonMakarna.Text));
            dgwMakarna.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnMac_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnMac.Text, Convert.ToInt32(lblMac.Text));
            dgwMakarna.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnBolonez_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnBolonez.Text, Convert.ToInt32(lblBolonez.Text));
            dgwMakarna.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
