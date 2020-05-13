using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }
        
        ArrayList odalar = new ArrayList();
        private void frmOdalar_Load(object sender, EventArgs e)
        {
            string odaAdi = "";
            string yeniDeger = "";
            bool oldumu = false;
            for (int i = 1; i < this.Controls.Count+1; i++)
            {
                odaAdi = Convert.ToString(this.Controls.Find("oda" + i.ToString(), true).FirstOrDefault() as Button);
                yeniDeger = odaAdi.Split(':').Last();
                odalar.Add(yeniDeger);
                oldumu = true;
            }
            if (oldumu == true)
            {
                odalarinDurumu();
            }
            
        }        
        void odalarinDurumu()
        {
            csOdalar oda = new csOdalar();
            try
            {
                foreach(string odaninAdi in odalar)
                {
                    string yeniOda = "";
                    oda.odaDegerleri(odaninAdi, "Dolu");
                    if (oda.durum_oku == "Dolu")
                    {
                        yeniOda = odaninAdi;
                        this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.Red;
                        this.Controls.Find(oda.butonAdi, true)[0].Text = yeniOda + "\n" + oda.alanKisi;
                        oda.durum_oku = "";
                    }
                    if(oda.durum_oku == "Boş")
                    {
                        this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.Green;
                    }
                }
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
        }

        private void frmOdalar_Load_1(object sender, EventArgs e)
        {

        }
    }

    }
