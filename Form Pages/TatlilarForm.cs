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
    public partial class TatlilarForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public TatlilarForm()
        {
            InitializeComponent();
        }

        private void btnMenuDon10_Click(object sender, EventArgs e) //Menuye geri dönmek için
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }


        private void TatlilarForm_Load(object sender, EventArgs e)
        {
            dgwTatli.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSanSeb_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSanSeb.Text, Convert.ToInt32(lblSanSeb.Text));
            dgwTatli.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnFramCheesecake_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnFramCheesecake.Text, Convert.ToInt32(lblFramCheesecake.Text));
            dgwTatli.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnLimCheesecake_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnLimCheesecake.Text, Convert.ToInt32(lblLimCheesecake.Text));
            dgwTatli.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnRedVel_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnRedVel.Text, Convert.ToInt32(lblRedVel.Text));
            dgwTatli.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnTrileceK_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnTrileceK.Text, Convert.ToInt32(lblTrileceK.Text));
            dgwTatli.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnTrileceF_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnTrileceF.Text, Convert.ToInt32(lblTrileceF.Text));
            dgwTatli.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnPastaProf_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnPastaProf.Text, Convert.ToInt32(lblPastaProf.Text));
            dgwTatli.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnDilimPCiko_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnDilimPCiko.Text, Convert.ToInt32(lblDilimPCiko.Text));
            dgwTatli.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnDilimPMeyve_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnDilimPMeyve.Text, Convert.ToInt32(lblDilimPMeyve.Text));
            dgwTatli.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnDilimPCilek_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnDilimPCilek.Text, Convert.ToInt32(lblDilimPCilek.Text));
            dgwTatli.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
