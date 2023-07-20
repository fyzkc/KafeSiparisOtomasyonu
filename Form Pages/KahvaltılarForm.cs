using KafeOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeOtomasyonu
{
    public partial class KahvaltilarForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public KahvaltilarForm()
        {
            InitializeComponent();
        }

        private void btnMenuDon_Click(object sender, EventArgs e) //Menuye geri dönmek için
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void btnSerpmeKah_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSerpmeKah.Text, Convert.ToInt32(lblSerpme.Text));
            dgwKahvalti.DataSource = c.SiparislerDBs.ToList();
        }

        private void KahvaltilarForm_Load(object sender, EventArgs e)
        {
            dgwKahvalti.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnTekKah_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnTekKah.Text, Convert.ToInt32(lblTekKah.Text));
            dgwKahvalti.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSimitKah_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSimitKah.Text, Convert.ToInt32(lblSimitKah.Text));
            dgwKahvalti.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
