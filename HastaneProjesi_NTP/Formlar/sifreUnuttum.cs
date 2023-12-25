using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace HastaneProjesi_NTP.Formlar
{
    public partial class sifreUnuttum : Form
    {
        public sifreUnuttum()
        {
            InitializeComponent();
            mesajgif.Visible = false;

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
        string random;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txteposta.Text == "hasankilic0627@gmail.com")
                {
                    Random code = new Random();
                    random = code.Next(999999).ToString();
                    MailMessage mailMessage = new MailMessage();
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    mailMessage.From = new MailAddress("hasankilic0627@gmail.com");
                    mailMessage.To.Add(txteposta.Text);
                    mailMessage.Subject = "Şifre Sıfırlama";
                    mailMessage.Body = "kodunuz:" + random;
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("hasankilic0627@gmail.com", "vzuysmmjknepauss");
                    smtp.EnableSsl = true;
                    smtp.Send(mailMessage);
                    MessageBox.Show("mail gönderildi.");
                    mesajgif.Visible = true;
                }
                else
                {
                    MessageBox.Show("Lütfen sisteme kayıtlı epostayı giriniz !");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("mesaj gönderilmedi");
                Console.WriteLine(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtdogrula.Text.Equals(random))
            {
                this.Hide();
                sifreyenile resetle = new  sifreyenile();
                resetle.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("kod hatalı tekrar deneyiniz");
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
