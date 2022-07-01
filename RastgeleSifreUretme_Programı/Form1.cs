using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSifreUretme_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string karakterler = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇqwertyuıopğüasdfghjklşizxcvbnmö0123456789";
            string sonuc = "";
            int uzunluk = Convert.ToInt16(txtUzunluk.Text);

            

            if(uzunluk >= 8)
            {
                for (int i = 0; i <= uzunluk; i++)
                {
                    sonuc += karakterler[rnd.Next(karakterler.Length)];
                }
                lblSifre.Text = sonuc;
            }
            else
            {
                MessageBox.Show("Şifreniz 8 karakterden az olamaz, kontrol ediniz!", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtKontrol.Text == lblSifre.Text)
            {
                MessageBox.Show("Şifreniz doğru!", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
