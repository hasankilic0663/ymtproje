using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProjesi_NTP
{
    public partial class AnimasyonGirisEkranı : Form
    {
        public AnimasyonGirisEkranı()
        {
            InitializeComponent();
        }
        bool islem = false;
        private void AnimasyonGirisEkranı_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!islem)
            {
                this.Opacity += 0.008;
            }
            if (this.Opacity==1.0)
            {
                islem = true;

            }
            if (islem)
            {
                this.Opacity -= 0.010;
                if (this.Opacity==0)
                {
                    Form1 gtr = new Form1();
                    gtr.Show();
                    this.Hide();
                    timer1.Enabled = false;
                }
            }
        }
    }
}
