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
    public partial class WraplerForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public WraplerForm()
        {
            InitializeComponent();
        }

        private void btnMenuDon4_Click(object sender, EventArgs e) //Menuye geri dönmek için
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }


        private void WraplerForm_Load(object sender, EventArgs e)
        {
            dgwWrap.DataSource = c.SiparislerDBs.ToList();
        }


        private void btnKofteWrap_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnKofteWrap.Text, Convert.ToInt32(lblKofteWrap.Text));
            dgwWrap.DataSource = c.SiparislerDBs.ToList();
        }        

        private void btnTavukWrap_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnTavukWrap.Text, Convert.ToInt32(lblTavukWrap.Text));
            dgwWrap.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnMantarWrap_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnMantarWrap.Text, Convert.ToInt32(lblMantarWrap.Text));
            dgwWrap.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnEtWrap_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnEtWrap.Text, Convert.ToInt32(lblEtWrap.Text));
            dgwWrap.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnVeganWrap_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnVeganWrap.Text, Convert.ToInt32(lblVeganWrap.Text));
            dgwWrap.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSebzeWrap_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSebzeWrap.Text, Convert.ToInt32(lblSebzeWrap.Text));
            dgwWrap.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
