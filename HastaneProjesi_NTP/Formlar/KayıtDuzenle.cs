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
    public partial class KayıtDuzenle : Form
    {
        public KayıtDuzenle()
        {
            InitializeComponent();
            tik.Visible = false;
            lblcancel.Visible = false;
        }
        static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HastaneVeriTABANI.mdf;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        void telefonNoKontrol()
        {
            string telno = mskTelefon.Text;
            telno = telno.Trim();
            if (telno.Length < 10)
            {
                MessageBox.Show("Hastanın Telefon Numarasını eksik girdiniz!\nLütfen tekrar deneyin.");
                mskTelefon.Focus();
                mskTelefon.Text = "";
            }
        }
        public bool TcDogruMu()
        {
            string kimlikno = mskTCbilgiGetir.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                MessageBox.Show("Hastanın TC Kimlik Numarasını eksik girdiniz!\nLütfen tekrar deneyin.");
                txtadsoyad.Focus();
                txtadsoyad.Text = "";
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
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            TcDogruMu();
            telefonNoKontrol();
            baglanti.Open();

            string kayit = "update Tbl_Hastalar set /*HastaTC=@tcno,*/HastaAdSoyad=@adsoyad,HastaTelefon=@telefon,HastaDogumTarihi=@dogum,HastaCinsiyet=@cinsiyet where HastaTC=@hastaTC";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", mskTelefon.Text);
            komut.Parameters.AddWithValue("@cinsiyet", txtcinsiyet.Text);
            komut.Parameters.AddWithValue("@hastaTC", mskTCbilgiGetir.Text);
            komut.Parameters.AddWithValue("@dogum", txtdogumtarihi.Value.Date);
            komut.ExecuteNonQuery();
            baglanti.Close();
            tik.Visible = true;
            lblcancel.Visible = true;



           






        }

        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            TcDogruMu();
            baglanti.Open();
            string kayit = "SELECT * from Tbl_Hastalar where HastaTC=@HastaTC";

            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@HastaTC", mskTCbilgiGetir.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtadsoyad.Text = dr["HastaAdSoyad"].ToString();
                txtdogumtarihi.Text = dr["HastaDogumTarihi"].ToString();

                mskTelefon.Text = dr["HastaTelefon"].ToString();
                mskTC.Text = dr["HastaTC"].ToString();
                txtcinsiyet.Text = dr["HastaCinsiyet"].ToString();

            }
            else
                MessageBox.Show("Hasta Bulunamadı.");
            tik.Visible = false;
            lblcancel.Visible = false;
            baglanti.Close();
        }

        private void mskTCbilgiGetir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void mskTC_TextChanged(object sender, EventArgs e)
        {
            mskTC.MaxLength = 11;
        }

        private void mskTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            mskTelefon.MaxLength = 11;

        }

        private void txtdogumtarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tik_Click(object sender, EventArgs e)
        {

        }

        private void mskTCbilgiGetir_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mskTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void mskTC_MouseClick(object sender, MouseEventArgs e)
        {
          
        }
    }
}

