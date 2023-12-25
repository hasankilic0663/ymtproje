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
    public partial class Destek : Form
    {
        public Destek()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100003470646136");
        }

        private void Destek_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/hasankilic0627");
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/hasan-h%C3%BCseyin-kili%C3%A7-368439228/");

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/hasankilic0663/");


        }
    }
}
