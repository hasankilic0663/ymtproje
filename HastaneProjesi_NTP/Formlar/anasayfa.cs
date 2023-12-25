using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProjesi_NTP.Formlar
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();

        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void anasayfa_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbltarih_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToLongDateString();
            lblsaat.Text = DateTime.Now.ToLongTimeString();
        }
        
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            loadform(new RandevuVer());
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            loadform(new KayıtEkle());
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            loadform(new KayıtDuzenle());
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            loadform(new KayitSil());

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            loadform(new AktifRandevular());

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            loadform(new GecmisRandevular());

        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            loadform(new Destek());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            loadform(new RandevuSil());
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Kapatılacak Emin Misiniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Kapatılacak Emin Misiniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void lblsaat_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
