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
    public partial class GecmisRandevular : Form
    {
        public GecmisRandevular()
        {
            InitializeComponent();
            kayitgetir();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HastaneVeriTABANI.mdf;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public bool TcDogruMu()
        {
            string kimlikno = txtTc.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                MessageBox.Show("Hastanın TC Kimlik Numarasını eksik girdiniz!\nLütfen tekrar deneyin.");
                txtTc.Focus();
                txtTc.Text = "";
                
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
        private void kayitgetir()
        {
            baglanti.Open();
            DateTime bugun = DateTime.Today;
            string kayit = "SELECT * from Randevular where RandevuTarih <'20230104'";
            komut = new SqlCommand(kayit, baglanti);
            da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            TcDogruMu();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(("select * from Randevular where RandevuTc like '%" + txtTc.Text + "%'"), baglanti);
            komut.Parameters.AddWithValue("@TC", txtTc.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            txtTc.MaxLength = 11;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            TcDogruMu();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(("select * from Randevular where RandevuTarih <'20230104' AND RandevuTc like '%" + txtTc.Text + "%'"), baglanti);
            komut.Parameters.AddWithValue("@TC", txtTc.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
            baglanti.Close();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
