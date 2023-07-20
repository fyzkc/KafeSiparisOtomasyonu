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
    public partial class TostlarForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public TostlarForm()
        {
            InitializeComponent();
        }

        private void btnMenuDon2_Click(object sender, EventArgs e) //Menuye geri dönmek için
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void btnKasarli_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnKasarli.Text, Convert.ToInt32(lblKasarli.Text));
            dgwTost.DataSource = c.SiparislerDBs.ToList();
        }

        private void TostlarForm_Load(object sender, EventArgs e)
        {
            dgwTost.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSucuklu_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSucuklu.Text, Convert.ToInt32(lblSucuklu.Text));
            dgwTost.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnKarisik_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnKarisik.Text, Convert.ToInt32(lblKarisik.Text));
            dgwTost.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnBazlamaKasar_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnBazlamaKasar.Text, Convert.ToInt32(lblBazlamaKasar.Text));
            dgwTost.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnBazlamaSucuk_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnBazlamaSucuk.Text, Convert.ToInt32(lblBazlamaSucuk.Text));
            dgwTost.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnBazlamaKarisik_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnBazlamaKarisik.Text, Convert.ToInt32(lblBazlamaKarisik.Text));
            dgwTost.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnAyvalik_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnAyvalik.Text, Convert.ToInt32(lblAyvalik.Text));
            dgwTost.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnPizzaTost_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnPizzaTost.Text, Convert.ToInt32(lblPizzaTost.Text));
            dgwTost.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
