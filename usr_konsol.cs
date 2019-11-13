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
    public partial class usr_konsol : UserControl
    {
        public string link;
        public usr_konsol()
        {
            InitializeComponent();
        }

        private void usr_program_Click(object sender, EventArgs e)
        {
            frm_konsol_yukle ac = new frm_konsol_yukle();
            ac.link = this.link; //link stringini frm_konsol_yuklede olan link değişkenine ata
            ac.ShowDialog();
        }
    }
}
