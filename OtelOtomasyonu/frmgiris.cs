using System;
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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            giris grs = new giris();
            Form1 main = new Form1();
            if (txtKullanici.Text == string.Empty || txtSifre.Text == string.Empty)
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi giriniz.", "HATA | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                grs.girisYap(txtKullanici.Text, txtSifre.Text, DateTime.Now);
                string bilgiTut = txtKullanici.Text + "" + txtSifre.Text.ToString();
                if (grs.girisDurumu == bilgiTut)
                {
                    main.Show();
                    this.Hide();
                }
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            txtKullanici.Text = "admin";
            txtSifre.Text = "admin";
        }

        private void frmgiris_Load(object sender, EventArgs e)
        {

        }
    }
}
