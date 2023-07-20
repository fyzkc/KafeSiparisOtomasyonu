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
    public partial class PizzalarForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public PizzalarForm()
        {
            InitializeComponent();
        }

        private void btnMenuDon6_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Hide();
        }

        private void PizzalarForm_Load(object sender, EventArgs e)
        {
            dgwPizza.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnMargarita_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnMargarita.Text, Convert.ToInt32(lblMargarita.Text));
            dgwPizza.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnSucukluPizza_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnSucukluPizza.Text, Convert.ToInt32(lblSucukluPizza.Text));
            dgwPizza.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnKarisikPizza_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnKarisikPizza.Text, Convert.ToInt32(lblKarisikPizza.Text));
            dgwPizza.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnVeganPizza_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnVeganPizza.Text, Convert.ToInt32(lblVeganPizza.Text));
            dgwPizza.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnTonBalikliPizza_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnTonBalikliPizza.Text, Convert.ToInt32(lblTonBalikliPizza.Text));
            dgwPizza.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnDortPeynirPizza_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnDortPeynirPizza.Text, Convert.ToInt32(lblDortPeynirPizza.Text));
            dgwPizza.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnMantarPizza_Click(object sender, EventArgs e)
        {
            alinanSiparisler.SiparisAl(MasalarForm.masaNo, btnMantarPizza.Text, Convert.ToInt32(lblMantarPizza.Text));
            dgwPizza.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
