using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;

namespace CloudApp
{
public partial class frm_liste : Form
{

    public frm_liste()
    {
        InitializeComponent();
    }
    void LinkKonsol(string htmlLink, FlowLayoutPanel flp, UserControl usr)
    {
        string htmlVeri;
        using (WebClient client = new WebClient()) 
        {
            client.Encoding = Encoding.UTF8; //türkçe karakterleri çevir
            htmlVeri = client.DownloadString(htmlLink); //site htmlini çek

        }
        Regex r = new Regex(@"<a.*?href=(""|')(?<href>.*?)(""|').*?>(?<value>.*?)</a>");
        for (int i = 1; i < r.Matches(htmlVeri).Count; i++)
        {
            usr = new usr_konsol();
            string[] isim = r.Matches(htmlVeri)[i].Groups["value"].Value.Split('.'); //html sayfasındaki linklerin isimlerini al
            for (int x = 0; x < isim.Length - 1; x++)
            {
                ((usr_konsol)usr).lbl_ad.Text += isim[x];
            }

            ((usr_konsol)usr).link = r.Matches(htmlVeri)[i].Groups["href"].Value;  //html sayfasında ki linkleri al
            flp.Controls.Add(usr);
        }
    }
    void LinkForm(string htmlLink, FlowLayoutPanel flp, UserControl usr)
    {
        string htmlVeri;
        using (WebClient client = new WebClient())
        {
            client.Encoding = Encoding.UTF8;
            htmlVeri = client.DownloadString(htmlLink);

        }
        Regex r = new Regex(@"<a.*?href=(""|')(?<href>.*?)(""|').*?>(?<value>.*?)</a>");
        for (int i = 1; i < r.Matches(htmlVeri).Count; i++)
        {
            usr = new usr_form();
            string[] isim = r.Matches(htmlVeri)[i].Groups["value"].Value.Split('.');
            for (int x = 0; x < isim.Length - 1; x++)
            {
                ((usr_form)usr).lbl_ad.Text += isim[x];
            }

            ((usr_form)usr).link = r.Matches(htmlVeri)[i].Groups["href"].Value;
            flp.Controls.Add(usr);
        }
    }
    void LinkOyun(string htmlLink, FlowLayoutPanel flp, UserControl usr)
    {
        string htmlVeri;
        using (WebClient client = new WebClient())
        {
            client.Encoding = Encoding.UTF8;
            htmlVeri = client.DownloadString(htmlLink);

        }
        Regex r = new Regex(@"<a.*?href=(""|')(?<href>.*?)(""|').*?>(?<value>.*?)</a>");
        for (int i = 1; i < r.Matches(htmlVeri).Count; i++)
        {
            usr = new usr_oyun();
            string[] isim = r.Matches(htmlVeri)[i].Groups["value"].Value.Split('.');
            for (int x = 0; x < isim.Length - 1; x++)
            {
                ((usr_oyun)usr).lbl_ad.Text += isim[x];
            }

            ((usr_oyun)usr).link = r.Matches(htmlVeri)[i].Groups["href"].Value;
            flp.Controls.Add(usr);
        }

    }

    private void pcr_uygulama_Click(object sender, EventArgs e)
    {
      
        flp_liste.Controls.Clear();
        usr_konsol usrListe = new usr_konsol();
        LinkKonsol("http://mustafauzun0.16mb.com/KONSOL/", flp_liste, usrListe);
    }

    private void frm_liste_Load(object sender, EventArgs e)
    {
        flp_liste.Controls.Clear();
        usr_konsol usrListe = new usr_konsol();
        LinkKonsol("http://mustafauzun0.16mb.com/KONSOL/", flp_liste, usrListe);
    }

    private void pcr_oyun_Click(object sender, EventArgs e)
    {
        flp_liste.Controls.Clear();
        usr_oyun usrListe = new usr_oyun();
        LinkOyun("http://mustafauzun0.16mb.com/OYUN/", flp_liste, usrListe);
    }

    private void pcr_form_Click(object sender, EventArgs e)
    {
        flp_liste.Controls.Clear();
        usr_form usrListe = new usr_form();
        LinkForm("http://mustafauzun0.16mb.com/FORM/", flp_liste, usrListe);
    }
}
}
