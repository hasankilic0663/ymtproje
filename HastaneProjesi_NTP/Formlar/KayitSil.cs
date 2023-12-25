using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HastaneProjesi_NTP.Formlar
{
    public partial class KayitSil : Form
    {
        public KayitSil()
        {
            InitializeComponent();
            kayitGetir();
            tik.Visible = false;
            lblcancel.Visible = false;
            cancel.Visible = false;
            label4.Visible = false;
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public bool TcDogruMu1()
        {
            string kimlikno = txthastatckayıtsil.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length < 11)
            {
                MessageBox.Show("Hastanın TC Kimlik Numarasını eksik girdiniz!\nLütfen tekrar deneyin.");
                txthastatckayıtsil.Focus();
                txthastatckayıtsil.Text = "";
                kayitGetir();
                return false;

            }
            int[] sayilar = new int[11];
            for (int i = 0; i < kimlikno.Length; i++)
            {
                sayilar[i] = Int32.Parse(kimlikno[i].ToString());
            }
            int toplam = 0;
            for (int i = 0; i < kimlikno.Length - 1; i++)
            {
                toplam += sayilar[i];
            }
            if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
        public bool TcDogruMu()
        {
            string kimlikno = txthastatcgör.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length < 11)
            {
                MessageBox.Show("Hastanın TC Kimlik Numarasını eksik girdiniz!\nLütfen tekrar deneyin.");
                txthastatcgör.Focus();
                txthastatcgör.Text = "";
                kayitGetir();
                return false;
                
            }
            int[] sayilar = new int[11];
            for (int i = 0; i < kimlikno.Length; i++)
            {
                sayilar[i] = Int32.Parse(kimlikno[i].ToString());
            }
            int toplam = 0;
            for (int i = 0; i < kimlikno.Length - 1; i++)
            {
                toplam += sayilar[i];
            }
            if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
        private void kayitGetir()
        {
            baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HastaneVeriTABANI.mdf;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * from Tbl_Hastalar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            TcDogruMu1();
            baglanti.Open();
            string secmesorgusu = "SELECT * from Tbl_Hastalar where HastaTC=@TC";
            SqlCommand secmeKomutu = new SqlCommand(secmesorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@TC", txthastatckayıtsil.Text);
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            if (dr.Read())
            {
                string isim = dr["HastaAdSoyad"].ToString();
                dr.Close();
                DialogResult durum = MessageBox.Show(isim + "  adlı hastanın kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum)
                {
                    string silmesorgusu = "DELETE  from  Tbl_Hastalar where HastaTC=@TC";
                    SqlCommand silkomutu = new SqlCommand(silmesorgusu, baglanti);
                    silkomutu.Parameters.AddWithValue("@TC", txthastatckayıtsil.Text);
                    silkomutu.ExecuteNonQuery();
                    tik.Visible =true;
                    lblcancel.Visible = true;
                    cancel.Visible = false;
                    label4.Visible = false;
                    kayitGetir();
                    baglanti.Close();
                }
            }
            else
            {
                
                baglanti.Close();
                tik.Visible = false;
                lblcancel.Visible = false;
                cancel.Visible = true;
                label4.Visible = true;

            }
        }

        private void txthastatcgör_TextChanged(object sender, EventArgs e)
        {
            txthastatcgör.MaxLength = 11;
        }

        private void txthastatcgör_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcDogruMu();
            baglanti.Open();
            string kayit = "SELECT * from Tbl_Hastalar where HastaTC=@HastaTC";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@HastaTC", txthastatcgör.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void txthastatckayıtsil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txthastatckayıtsil_TextChanged(object sender, EventArgs e)
        {
            txthastatckayıtsil.MaxLength = 11;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
