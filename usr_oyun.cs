using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CloudApp
{
    public partial class usr_oyun : UserControl
    {
        public string link;
        public usr_oyun()
        {
            InitializeComponent();
        }
       
        private void usr_oyun_Click(object sender, EventArgs e)
        {   frm_oyun ac = new frm_oyun();
            ac.Text = lbl_ad.Text; 
           ac.asf_oyun.LoadMovie(0, "http://mustafauzun0.16mb.com/OYUN/" + link); //linkdeki flash dosyasını frm_oyun sayfasındaki asf_oyun nesnesine yükler
           //ac.asf_oyun.Movie = "http://mustafauzun0.16mb.com/OYUN/" + link; //Başka bir yolu
            ac.ShowDialog();
        }
    }
}
