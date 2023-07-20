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
    public partial class SalatalarForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public SalatalarForm()
        {
            InitializeComponent();
        }


        private void SalatalarForm_Load(object sender, EventArgs e)
        {
            dgwSalata.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnMenuDon9_Click(object sender, EventArgs e) //Menuye geri dönmek için
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void btnMevsimSalata_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnMevsimSalata.Text, Convert.ToInt32(lblMevsimSalata.Text));
            dgwSalata.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnPeynirSalata_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnPeynirSalata.Text, Convert.ToInt32(lblPeynirSalata.Text));
            dgwSalata.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnAvokadoSalata_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnAvokadoSalata.Text, Convert.ToInt32(lblAvokadoSalata.Text));
            dgwSalata.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnTavukSalata_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnTavukSalata.Text, Convert.ToInt32(lblTavukluSalata.Text));
            dgwSalata.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnTonSalata_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnTonSalata.Text, Convert.ToInt32(lblTonSalata.Text));
            dgwSalata.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSoyaSalata_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSoyaSalata.Text, Convert.ToInt32(lblSoyaSalata.Text));
            dgwSalata.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnZeytinSalata_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnZeytinSalata.Text, Convert.ToInt32(lblZeytinSalata.Text));
            dgwSalata.DataSource = c.SiparislerDBs.ToList();
        }

        
    }
}
