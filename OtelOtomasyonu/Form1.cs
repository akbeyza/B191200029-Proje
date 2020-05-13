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
    public partial class Form1 : Form
    {
        private Form CurrentChildForm;
        public Form1()
        {
            InitializeComponent();
        }
        /*protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
                {
                case 0x84:
                    base.WndProc(ref m);
                    if((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                    return;
            }
            base.WndProc(ref m);
        }*/

        private void OpenChildForm(Form childForm)
        {
            if (CurrentChildForm != null)
            {
                //open only form
                CurrentChildForm.Close();
            }
            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(childForm);
            Wrapper.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();           
        }
        private void Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kucult_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Buyult_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

            
        }
        
        
        private void button6_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMusteriKayit());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOdalar());
        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGazeteOku());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new musteriEkrani());
        }
    }
}
