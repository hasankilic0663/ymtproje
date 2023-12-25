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

namespace HastaneProjesi_NTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            foreach (var ctl in MskTC.Controls)
            {

                if (ctl.GetType() == typeof(TextBox))

                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = 11;

                }
            }
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HastaneVeriTABANI.mdf;Integrated Security=True");
        
        SqlDataReader dr;
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Formlar.sifreUnuttum fr = new Formlar.sifreUnuttum();
            fr.Show();
            this.Hide();
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_giris_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_sifregöster.Checked == true)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else if (ch_sifregöster.Checked == false)
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void MskTC_TextChanged(object sender, EventArgs e)
        {
            MskTC.MaxLength = 11;
        }

        private void MskTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            String ad = MskTC.Text;
            String sifre = TxtSifre.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Tbl_KullaniciBilgi where KullaniciTc='" + ad + "'AND KullaniciSifre='" + sifre + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                    Formlar.anasayfa frm = new Formlar.anasayfa();
                    frm.Show();
                    this.Hide();
               
            }
            else
            {
                MessageBox.Show("HATALI VEYA EKSİK GİRİŞ YAPTINIZ ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/hasankilic0627");
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100003470646136");

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/hasankilic0663/");

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/hasan-h%C3%BCseyin-kili%C3%A7-368439228/");

        }
    }
}
