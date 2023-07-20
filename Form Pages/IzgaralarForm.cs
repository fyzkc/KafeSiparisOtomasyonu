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
    public partial class IzgaralarForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public IzgaralarForm()
        {
            InitializeComponent();
        }

        private void btnMenuDon8_Click(object sender, EventArgs e) //Menuye geri dönmek için
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void IzgaralarForm_Load(object sender, EventArgs e)
        {
            dgwIzgara.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnIzgKofte_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnIzgKofte.Text, Convert.ToInt32(lblIzgKofte.Text));
            dgwIzgara.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnIzgBiftek_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnIzgBiftek.Text, Convert.ToInt32(lblIzgBiftek.Text));
            dgwIzgara.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnIzgTavuk_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnIzgTavuk.Text, Convert.ToInt32(lblIzgTavuk.Text));
            dgwIzgara.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnIzgKarisik_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnIzgKarisik.Text, Convert.ToInt32(lblIzgKarisik.Text));
            dgwIzgara.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
