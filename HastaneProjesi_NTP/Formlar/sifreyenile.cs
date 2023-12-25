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
    public partial class sifreyenile : Form
    {
        public sifreyenile()
        {
            InitializeComponent();
            lbl1.Visible = false;
            tik.Visible = false;
            cancel.Visible = false;
            lblcancel.Visible = false;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HastaneVeriTABANI.mdf;Integrated Security=True");

        private void sifreyenile_Load(object sender, EventArgs e)
        {

        }

        private void pn_sifreyenile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsifredeğiştir_Click(object sender, EventArgs e)
        {
            if (txtyenisifre.Text == txtyenisifreTekrar.Text)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Tbl_KullaniciBilgi set KullaniciSifre=@sifre WHERE KullaniciTc=@tcno", baglanti);
                komut.Parameters.AddWithValue("@sifre", txtyenisifre.Text);
                komut.Parameters.AddWithValue("@tcno", "12976130650");
                komut.ExecuteNonQuery();
                baglanti.Close();
                lbl1.Visible = true;
                tik.Visible = true;
                cancel.Visible = false;
                lblcancel.Visible = false;



            }
            else
            {
                cancel.Visible = true;
                lblcancel.Visible = true;
                lbl1.Visible = false;
                tik.Visible = false;

            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
