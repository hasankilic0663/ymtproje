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
    public partial class AktifRandevular : Form
    {
        public AktifRandevular()
        {
            InitializeComponent();
            kayitgetir();
            DoktorPaneli.Visible = false;
            branşekle();
            CbDoktor.Enabled = false;

        }
        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HastaneVeriTABANI.mdf;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;
        void branşekle()
        {



            CbDoktor.Enabled = false;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Branş ", baglanti);

            komut.Connection = baglanti;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {

                CbBrans.Items.Add(dr["BranşADI"]);

            }

            baglanti.Close();


        }
        public bool TcDogruMu()
        {
            string kimlikno = txtTC.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                MessageBox.Show("Hastanın  TC Kimlik Numarasını eksik  girdiniz!\nLütfen tekrar deneyin .");
                txtTC.Focus();
                txtTC.Text = "";
                return false;
            }
            int[] sayilar = new int[11];
            for (int i = 0; i < kimlikno.Length; i++)
            {
                sayilar[i] = Int32.Parse(kimlikno[i].ToString());

            }
            int toplam = 0;
            for (int i = 0; i < kimlikno.Length; i++)
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
            string kayit = "SELECT  * from Randevular where RandevuTarih >='20230104'";
            komut = new SqlCommand(kayit, baglanti);
            da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void AktifRandevular_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcDogruMu();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Randevular where RandevuTc like '%" + txtTC.Text + "%'", baglanti);
            komut.Parameters.AddWithValue("@TC", txtTC.Text);

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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            TcDogruMu();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Randevular where RandevuTc like '%" + txtTC.Text + "%'", baglanti);
            komut.Parameters.AddWithValue("@TC", txtTC.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            DoktorPaneli.Visible = true;
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            DoktorPaneli.Visible = false;
        }

        private void CbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbDoktor.Enabled = true;
            CbDoktor.Items.Clear();
            CbDoktor.Text = "";



            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Doktorlar WHERE DoktorBrans=@d1", baglanti);
            komut.Parameters.AddWithValue("@d1", CbBrans.Text);
            dr = komut.ExecuteReader();

            while (dr.Read())
            {

                CbDoktor.Items.Add(dr["DoktorAdSoyad"]);

            }
            baglanti.Close();
        }

        private void CbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime secimTarih = DateTime.Parse(dateTimePicker1.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Randevular where RandevuDoktorAdı='" + CbDoktor.Text + "'", baglanti);
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
