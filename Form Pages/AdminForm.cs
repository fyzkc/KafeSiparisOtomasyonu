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
using System.Data.SqlClient;


namespace KafeOtomasyonu
{
    public partial class AdminForm : Form
    {
        SqlConnection baglanti;
        SqlDataReader dr;
        SqlCommand komut;
        public AdminForm()
        {
            InitializeComponent();
        }
        
    
    private void btnGiris_Click(object sender, EventArgs e) //Admin giriş bilgilerinin sağlanması için Sql Sorguları kullanıldı.
        {
            
            baglanti = new SqlConnection("Data Source=LAPTOP-83AA7S0U\\SQLEXPRESS;Initial Catalog=KafeOtomasyonu_;Integrated Security=True");
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from AdminDBs where KullaniciAdi = '" + txtKullanici.Text + "'And Sifre = '" + txtSifre.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MasalarForm msf = new MasalarForm();
                msf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            baglanti.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
