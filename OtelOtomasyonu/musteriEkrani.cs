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
    public partial class musteriEkrani : Form
    {
        public musteriEkrani()
        {
            InitializeComponent();
        }

        private void musteriEkrani_Load(object sender, EventArgs e)
        {
            csMusteriEkrani me = new csMusteriEkrani();
            dataGridView1.DataSource = me.tablola();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);   //seçilen satırın çağrılmış verisinin id kolonundaki veriyi alıyor, int e çeviriyor.
             txtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["adi"].Value.ToString();
             txtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells["soyadi"].Value.ToString();
             comboCinsiyet.Text = dataGridView1.Rows[e.RowIndex].Cells["cinsiyet"].Value.ToString();
             txtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells["telefon"].Value.ToString();
             txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells["mail"].Value.ToString();
            txtTc.Text = dataGridView1.Rows[e.RowIndex].Cells["tcNo"].Value.ToString();
             txtOda.Text = dataGridView1.Rows[e.RowIndex].Cells["odaNo"].Value.ToString();
             txtUcret.Text = dataGridView1.Rows[e.RowIndex].Cells["ucret"].Value.ToString();
             dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["girisTarihi"].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["cikisTarihi"].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            csMusteriEkrani me = new csMusteriEkrani();          //me:müşteri ekranı
            dataGridView1.DataSource = me.tablola();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            comboCinsiyet.Text = "";
            txtTelefon.Text = "";
            txtMail.Text = "";
            txtTc.Text = "";
            txtOda.Text = "";
            txtUcret.Text = "";
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(lblID.Text);
            csMusteriEkrani me = new csMusteriEkrani();
            me.musteriSil(id);
            dataGridView1.DataSource = me.tablola();


        }        
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime cikisTarihi = Convert.ToDateTime(dateTimePicker2.Value);
            int id = Convert.ToInt16(lblID.Text);
            csMusteriEkrani me = new csMusteriEkrani();
            me.musteriGuncelle(id, txtAdi.Text, txtSoyadi.Text, comboCinsiyet.Text, txtTelefon.Text, txtMail.Text, txtTc.Text, txtOda.Text, txtUcret.Text, girisTarihi, cikisTarihi);
            dataGridView1.DataSource = me.tablola();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            csMusteriEkrani me = new csMusteriEkrani();
            dataGridView1.DataSource = me.musteriAra(txtAra.Text);
        }
    }
}
