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
    public partial class MasalarForm : Form
    {
        

        public static int masaNo;
        public MasalarForm()
        {
            InitializeComponent();
        }
        private void MenuAc() //Menu formu açmak için bir fonksiyon oluşturduk
        {
            MenuForm mf = new MenuForm();
            mf.Show(); //Menu formu açıldı
            this.Hide(); //Masalar formu kapatıldı
        }

        



        //Bütün masa numaralarının olduğu butonlara tıklandığı zaman menü formunu açması için bütün masa butonlarına aynı fonksiyonu uyguladık.

        public void masa1Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo= 1;
        }

        public void masa2Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 2;
        }

        public void masa3Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 3;
        }

        public void masa4Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 4;
        }

        public void masa5Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 5;
        }

        public void masa6Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 6;
        }

        public void masa7Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 7;
        }

        public void masa8Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 8;
        }

        public void masa9Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 9;
        }

        public void masa10Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 10;
        }

        public void masa11Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 11;
        }

        public void masa12Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 12;
        }

        public void masa13Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 13;
        }

        public void masa14Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 14;
        }

        public void masa15Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 15;
        }

        public void masa16Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 16;
        }

        public void masa17Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 17;
        }

        public void masa18Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 18;
        }

        public void masa19Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 19;
        }

        public void masa20Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 20;
        }

        public void masa21Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 21;
        }

        public void masa22Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 22;
        }

        public void masa23Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 23;
        }

        public void masa24Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 24;
        }

        public void masa25Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 25;
        }

        public void masa26Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 26;
        }

        public void masa27Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 27;
        }

        public void masa28Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 28;
        }

        public void masa29Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 29;
        }

        public void masa30Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 30;
        }

        public void masa31Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 31;
        }

        public void masa32Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 32;
        }

        public void masa33Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 33;
        }

        public void masa34Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 34;
        }

        public void masa35Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 35;
        }

        public void masa36Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 36;
        }

        public void masa37Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 37;
        }

        public void masa38Btn_Click(object sender, EventArgs e)
        {
            MenuAc();
            masaNo = 38;
        }

        private void btnCikis_Click(object sender, EventArgs e) //Çıkış yapmak için
        {
            AdminForm af = new AdminForm();
            af.Show();  
            this.Hide();
        }

        private void btnKasa_Click(object sender, EventArgs e) //KasaYı açmak için
        {
            KasaForm ksf = new KasaForm();
            ksf.Show();
            this.Hide();
        }

        private void MasalarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
