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
    public partial class KayıtEkle : Form
    {
        public KayıtEkle()
        {
            InitializeComponent();
            tik.Visible = false;
            lblcancel.Visible = false;
            cancel.Visible = false;
            label6.Visible = false;
            
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HastaneVeriTABANI.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        void verigetir()
        {
            cmd.CommandText = "SELECT * From Tbl_Hastalar";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

            }
            con.Close();

        }

        void telefon()
        {
            string telefon = MskTelefon.Text;
            telefon = telefon.Trim();
            if (telefon.Length < 10)
            {
                MessageBox.Show("Hastanın Telefon Numarasını eksik girdiniz!\nLütfen tekrar deneyin .");
                MskTelefon.Focus();
                MskTelefon.Text = "";
                
            }
        }
        void tc()
        {
            string kimlikNo = MskTC.Text;
            kimlikNo = kimlikNo.Trim();
            if (kimlikNo.Length != 11)
            {
                MessageBox.Show("Hastanın TC Kimlik Numarasını eksik girdiniz!\nLütfen tekrar deneyin .");
                MskTC.Focus();
                MskTC.Text = "";
                
            }
        }

        void kayıt()
        {
            tc();
            telefon();
            if (!(TxtAd.Text == "") && !(MskTelefon.Text == "") && !(CbCinsiyet.Text == ""))
            {
                if (con.State == ConnectionState.Closed)
                {

                    con.Open();

                    try
                    {

                        string kayit = "insert into Tbl_Hastalar (HastaTC,HastaAdSoyad,HastaDogumTarihi,HastaCinsiyet,HastaTelefon) values (@HastaTC,@HastaAdSoyad,@HastaDogumTarihi,@HastaCinsiyet,@HastaTelefon)";

                        SqlCommand komut = new SqlCommand(kayit, con);

                        komut.Parameters.AddWithValue("@HastaTC", MskTC.Text);
                        komut.Parameters.AddWithValue("@HastaAdSoyad", TxtAd.Text);
                        komut.Parameters.AddWithValue("@HastaDogumTarihi", dateTimePicker1.Value.Date);
                        komut.Parameters.AddWithValue("@HastaCinsiyet", CbCinsiyet.Text);
                        komut.Parameters.AddWithValue("@HastaTelefon", MskTelefon.Text);

                        komut.ExecuteNonQuery();
                        con.Close();
                        tik.Visible = true;
                        lblcancel.Visible = true;
                        cancel.Visible = false;
                        label6.Visible = false;
                       




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("KAYIT EKSİK");
                    }
                    finally
                    {
                        try
                        {

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }



            }

            else
            {
                tik.Visible = false;
                lblcancel.Visible = false;
                cancel.Visible = true;
                label6.Visible = true;
            }

        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            if (!(TxtAd.Text == "") && !(MskTelefon.Text == "") && !(MskTC.Text == "") && !(CbCinsiyet.Text == ""))
            {

                kayıt();

            }

            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                tik.Visible = false;
                lblcancel.Visible = false;
                cancel.Visible = true;
                label6.Visible = true;
                MskTC.MaxLength = 11;
            }
        }

        private void MskTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MskTC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MskTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void MskTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblcancel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
