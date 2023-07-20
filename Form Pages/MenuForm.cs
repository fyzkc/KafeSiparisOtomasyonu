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
    public partial class MenuForm : Form
    {
        Context c = new Context();
        
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnMasayaDon_Click(object sender, EventArgs e) //Masalar Formuna geri dönmek için
        {
            MasalarForm msf = new MasalarForm();
            msf.Show();  //Masalar formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnKahvalti_Click(object sender, EventArgs e) //Kahvaltı Menüsünü açmak için
        {
            KahvaltilarForm kf = new KahvaltilarForm();
            kf.Show(); //Kahvaltı formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnTost_Click(object sender, EventArgs e)
        {
            TostlarForm tf = new TostlarForm();
            tf.Show(); //Tostlar formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            BurgerlerForm bf = new BurgerlerForm();
            bf.Show(); //Burgerler formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnWrap_Click(object sender, EventArgs e)
        {
            WraplerForm wf = new WraplerForm();
            wf.Show(); //Wraplar formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnSandwich_Click(object sender, EventArgs e)
        {
            SandwichlerForm sf = new SandwichlerForm();
            sf.Show(); //Sandwich formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            PizzalarForm pf = new PizzalarForm();
            pf.Show(); //Pizza formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnMakarna_Click(object sender, EventArgs e)
        {
            MakarnalarForm mkf = new MakarnalarForm();
            mkf.Show(); //Makarna formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnIzgara_Click(object sender, EventArgs e)
        {
            IzgaralarForm ıf = new IzgaralarForm();
            ıf.Show(); //Izgaralar formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnSalata_Click(object sender, EventArgs e)
        {
            SalatalarForm sf = new SalatalarForm();
            sf.Show(); //Salatalar formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnTatli_Click(object sender, EventArgs e)
        {
            TatlilarForm tf = new TatlilarForm();
            tf.Show(); //Tatlılar formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnSicak_Click(object sender, EventArgs e)
        {
            SicakIceceklerForm scf = new SicakIceceklerForm();
            scf.Show(); //Sıcak İçecekler formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void btnSoguk_Click(object sender, EventArgs e)
        {
            SogukIceceklerForm sgf = new SogukIceceklerForm();
            sgf.Show(); //Soğuk İçecekler formu açıldı
            this.Hide(); //Menü formu kapatıldı.
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            dgwMenu.DataSource = c.SiparislerDBs.ToList();
        }
    }
}
