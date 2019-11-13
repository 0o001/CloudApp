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
    public partial class usr_form : UserControl
    {
        public string link;
        public usr_form()
        {
            InitializeComponent();
        }

        private void usr_form_Click(object sender, EventArgs e)
        {
            frm_form_yukle ac = new frm_form_yukle();
            ac.link = this.link; //link stringini frm_form_yuklede olan link değişkenine ata
            ac.ShowDialog();
        }
    }
}
