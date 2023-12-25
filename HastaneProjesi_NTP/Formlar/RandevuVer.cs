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
    public partial class RandevuVer : Form
    {
        public RandevuVer()
        {
            InitializeComponent();
            branşekle();
            butonRenk();
            TxtRandevuSaat.Enabled = false;
            


        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HastaneVeriTABANI.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        bool durum;
        bool c;
        bool durum2;
        bool durum3;
        DateTime trh;

        public bool TcDogrumu()
        {
            string kimlikno = MskTc.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                MessageBox.Show("Hastanın Tc Kimlik Numarasını Eksik girdiniz!\nLütfen tekrar deneyin !");
                MskTc.Focus();
                MskTc.Text = "";
                c = false;
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
                c = true;
                return true;
            }
            else
            {
                c = true;
                return false;
            }
        }

        void a()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Randevular where RandevuSaat=@p1 and RandevuBrans=@p2 and RandevuTarih=@p3 and RandevuDoktorAdı=@p4 ", con);
                cmd.Parameters.AddWithValue("@p1", TxtRandevuSaat.Text);
                cmd.Parameters.AddWithValue("@p2", CbBrans.Text);
                cmd.Parameters.AddWithValue("@p3", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@p4", CbDoktor.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    durum = false;
                  

                }
                else
                {
                    durum = true;

                }
                con.Close();

            }
        }
        void hasta()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1 ", con);
                cmd.Parameters.AddWithValue("@p1", MskTc.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    durum2 = true;

                }
                else
                {
                    durum2 = false;

                }
                con.Close();
            }
        }
        private void butonRenk()
        {
           

            // enabled kontrol
            btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true; btn4.Enabled = true;
            btn5.Enabled = true; btn6.Enabled = true; btn7.Enabled = true; btn8.Enabled = true;
            btn9.Enabled = true; btn10.Enabled = true; btn11.Enabled = true; btn12.Enabled = true;
            btn13.Enabled = true; btn14.Enabled = true; btn15.Enabled = true; btn16.Enabled = true;

        }
        private void saatKontrolu()
        {

            con.Open();

            SqlCommand komut = new SqlCommand("select * from Randevular where RandevuSaat=@p1", con);
            komut.Parameters.AddWithValue("@p1", TxtRandevuSaat.Text);
            dr = komut.ExecuteReader();

            while (dr.Read())
            {

                if (dr["RandevuSaat"].ToString() == btn1.Text)
                {
                    btn1.BackColor = Color.Gray;
                    btn1.Enabled = false;
                    con.Close();
                    durum3 = false;
                }


                else if (dr["RandevuSaat"].ToString() == btn2.Text)
                {
                    btn2.BackColor = Color.Gray;
                    btn2.Enabled = false;
                    con.Close();
                    durum3 = false;
                }

                else if (dr["RandevuSaat"].ToString() == btn3.Text)
                {
                    btn3.BackColor = Color.Gray;
                    btn3.Enabled = false;
                    durum3 = true;
                    con.Close();
                }

                else if (dr["Saat"].ToString() == btn4.Text)
                {
                    btn4.BackColor = Color.Gray;
                    btn4.Enabled = false;
                    durum3 = true;
                    con.Close();
                }

                else if (dr["RandevuSaat"].ToString() == btn5.Text)
                {
                    btn5.BackColor = Color.Gray;
                    btn5.Enabled = false;
                    durum3 = true;
                    con.Close();
                }

                else if (dr["RandevuSaat"].ToString() == btn6.Text)
                {
                    btn6.BackColor = Color.Gray;
                    btn6.Enabled = false;
                    con.Close();
                }

                else if (TxtRandevuSaat.Text == btn7.Text)
                {
                    btn7.BackColor = Color.Gray;
                    btn7.Enabled = false;
                    con.Close();
                }

                else if (dr["RandevuSaat"].ToString() == btn8.Text)
                {
                    btn8.BackColor = Color.Gray;
                    btn8.Enabled = false;
                    con.Close();
                }

                else if (dr["RandevuSaat"].ToString() == btn9.Text)
                {
                    btn9.BackColor = Color.Gray;
                    btn9.Enabled = false;
                    con.Close();
                }

                else if (dr["RandevuSaat"].ToString() == btn10.Text)
                {
                    btn10.BackColor = Color.Gray;
                    btn10.Enabled = false;
                    con.Close();
                }

                else if (dr["RandevuSaat"].ToString() == btn11.Text)
                {
                    btn11.BackColor = Color.Gray;
                    btn11.Enabled = false;
                    con.Close();
                }

                else if (dr["RandevuSaat"].ToString() == btn12.Text)
                {
                    btn12.BackColor = Color.Gray;
                    btn12.Enabled = false;
                    con.Close();
                }

                else if (dr["RandevuSaat"].ToString() == btn13.Text)
                {
                    btn13.BackColor = Color.Gray;
                    btn13.Enabled = false;
                    con.Close();
                }

                else if (dr["RandevuSaat"].ToString() == btn14.Text)
                {
                    btn14.BackColor = Color.Gray;
                    btn14.Enabled = false;
                    con.Close();
                }

                else if (dr["RandevuSaat"].ToString() == btn15.Text)
                {
                    btn15.BackColor = Color.Gray;
                    btn15.Enabled = false;
                    con.Close();
                }
                else if (dr["RandevuSaat"].ToString() == btn16.Text)
                {
                    btn16.BackColor = Color.Gray;
                    btn16.Enabled = false;
                    con.Close();
                }



            }
            con.Close();
        }
        int doktorId;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;
            DateTime secimTarih = DateTime.Parse(dateTimePicker1.Text);
            secimTarih = trh;
            string saatsizTarih;


            string[] splittedText = secimTarih.ToString().Split(' ');
            saatsizTarih = splittedText[0];
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

                if (CbBrans.Text != "" && CbDoktor.Text != "")
                {
                    if (secimTarih >= bugun)
                    {

                        if (con.State == ConnectionState.Open)
                            con.Close();
                        a();


                        if (durum == true)
                        {

                            hasta();
                            if (con.State == ConnectionState.Closed)
                                con.Open();

                            if (durum2 == true)
                            {
                                //    TcDogruMu();
                                //    if (c==false)
                                //    {
                                //        txt_tc.Text = "";

                                try
                                {


                                    string kayit = "insert into Randevular (RandevuTc,RandevuDoktorAdı,RandevuBrans,RandevuSaat,RandevuTarih) values (@TC,@DAD,@Branş,@Saat,@Tarih)";

                                    cmd = new SqlCommand(kayit, con);

                                    cmd.Parameters.AddWithValue("@TC", MskTc.Text);
                                    cmd.Parameters.AddWithValue("@DAD", CbDoktor.Text);
                                    cmd.Parameters.AddWithValue("@Branş", CbBrans.Text);
                                    cmd.Parameters.AddWithValue("@Saat", TxtRandevuSaat.Text);
                                    cmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value.Date);

                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show("Kayıt Başarılı");



                                }
                                catch (Exception Ex)
                                {
                                    MessageBox.Show("hata", Ex.Message);
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
                            else
                            {
                                MessageBox.Show("Hastanın Sistemde Kaydı Yoktur!");
                            }
                        }

                        else
                        {
                            MessageBox.Show("bu randevu alınmış");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Bugünden geçmiş bir tarihe randevu alınamaz !");

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
            }
            con.Close();
        }
        void branşekle()
        {



            CbDoktor.Enabled = false;

            con.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Branş ", con);

            komut.Connection = con;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {

                CbBrans.Items.Add(dr["BranşADI"]);

            }

            con.Close();


        }

        private void CbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbDoktor.Enabled = true;
            CbDoktor.Items.Clear();
            CbDoktor.Text = "";



            con.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Doktorlar WHERE DoktorBrans=@d1", con);
            komut.Parameters.AddWithValue("@d1", CbBrans.Text);
            dr = komut.ExecuteReader();

            while  (dr.Read())
            {

                CbDoktor.Items.Add(dr["DoktorAdSoyad"]);

            }
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            trh = dateTimePicker1.Value.Date;
            a();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn9.Text;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn10.Text;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn11.Text;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn12.Text;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn13.Text;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn14.Text;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn15.Text;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            TxtRandevuSaat.Text = "";
            TxtRandevuSaat.Text = btn16.Text;
        }

        private void MskTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void MskTc_TextChanged(object sender, EventArgs e)
        {
            MskTc.MaxLength = 11;
            
        }

        private void RandevuVer_Load(object sender, EventArgs e)
        {
            


        }

        private void MskTc_Load(object sender, EventArgs e)
        {
        }

        private void MskTc_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtRandevuSaat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
