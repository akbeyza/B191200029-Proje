using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** PROJE NUMARASI.........: 01
** ÖĞRENCİ ADI............: Beyza AK
** ÖĞRENCİ NUMARASI.......: B191200029
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/

namespace OtelOtomasyonu
{
    public partial class frmGazeteOku : Form
    {
        public frmGazeteOku()
        {
            InitializeComponent();
        }
        ChromiumWebBrowser chrome;

        private void frmGazeteOku_Load(object sender, EventArgs e)
        {
            CefSettings ayar = new CefSettings();
            if(Cef.IsInitialized == false)          //cef ayarları aktarılmadıysa
            {
                Cef.Initialize(ayar);
                chrome = new ChromiumWebBrowser("http://www.google.com");               
                chrome.Dock = DockStyle.Fill;
            }
            this.pnlGazete.Controls.Add(chrome);
        }

        private void milliyetSonDakikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("http://www.milliyet.com.tr/sondakika/");
        }

        private void hürriyetSonDakikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("http://www.hurriyet.com.tr/son-dakika/");
        }

        private void vatanGazetesiSonDakikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("http://www.gazetevatan.com/son-dakika/");
        }

        private void sabahSonDakikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("http://www.sabah.com.tr/gundem");
        }

        private void pnlGazete_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
