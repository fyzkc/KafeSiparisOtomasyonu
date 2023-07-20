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
    public partial class KasaForm : Form
    {
        Context c = new Context();
        AlinanSiparisler alinanSiparisler = new AlinanSiparisler();
        public KasaForm()
        {
            InitializeComponent();
        }

        private void KasaForm_Load(object sender, EventArgs e)
        {
            dgwKasa.DataSource = c.SiparislerDBs.ToList();
        }

        private void btnMasayaDonKasa_Click(object sender, EventArgs e)
        {
            MasalarForm msf = new MasalarForm();
            msf.Show();  //Masalar formu açıldı
            this.Hide(); //Kasa formu kapatıldı.
        }

        private void btnCikisKasa_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            this.Hide();
        }

        private void btnSiparisiSil_Click(object sender, EventArgs e)
        {
            Context c = new Context();
            KasaForm kasaForm = new KasaForm();

            int masa = Convert.ToInt32(txtSiparisiSil.Text);
            var sil = c.SiparislerDBs.Where(s => s.MasaNo == masa);
            c.SiparislerDBs.RemoveRange(sil);
            c.SaveChanges();
            dgwKasa.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
