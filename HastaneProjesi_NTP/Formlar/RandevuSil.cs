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
    public partial class RandevuSil : Form
    {
        public RandevuSil()
        {
            InitializeComponent();
            kayitGetir();
            tik.Visible = false;
            lblcancel.Visible = false;
            cancel.Visible = false;
            label4.Visible = false;

        }
        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HastaneVeriTABANI.mdf;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public bool TcDogruMu()
        {
            string kimlikno = textBox1.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                MessageBox.Show("Hastanın TC Kimlik Numarasını eksik girdiniz!\nLütfen tekrar deneyin.");
                textBox1.Focus();
                textBox1.Text = "";
                return false;
            }
            else
            {
                return true;
            }
           
        }
        private void kayitGetir()
        {
            baglanti.Open();
            DateTime bugun = DateTime.Today;


            string kayit = "SELECT * from Randevular where RandevuTarih >= '20220103'";

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

            SqlCommand komut = new SqlCommand(("select * from Randevular where RandevuTc like '%" + textBox1.Text + "%'"), baglanti);
            komut.Parameters.AddWithValue("@TC", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        int ID;
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                baglanti.Open();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                string silmesorgusu = "DELETE  from  Randevular where Randevuid='"+ID+"'";
                SqlCommand silkomutu = new SqlCommand(silmesorgusu, baglanti);
               
                silkomutu.ExecuteNonQuery();
                tik.Visible = true;
                lblcancel.Visible = true;
                cancel.Visible = false;
                label4.Visible = false;
                baglanti.Close();

            }
            else
            {
                tik.Visible = false;
                lblcancel.Visible = false;
                cancel.Visible = true;
                label4.Visible = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void tik_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
