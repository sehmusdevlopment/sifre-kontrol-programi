using System.Text.RegularExpressions;

namespace şifre_kontrol_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kontrolbuton_Click(object sender, EventArgs e)
        {
            string sifre = textBox1.Text;
            int puan = 0;

            //şifre boş ise
            if(string.IsNullOrWhiteSpace(sifre))
            {
                label1.Text = "lütfen bir şifre girin .";
                label1.ForeColor = System.Drawing.Color.Red;
                pgbGuc.Value = 0;
                return;

            }


            //uzunluk kontrolü
            if (sifre.Length >= 8)
                puan += 25;
            else
                label1.Text = "şifre en az 8 karakter olmalı.\n";

            //büyük harf kontrolü
            if (Regex.IsMatch(sifre, @"[A-Z]"))
                puan += 25;

            //özel karakter kontrolü
            if (Regex.IsMatch(sifre, @"[!@#$%^&*(),.?""{}|<>]"))
                puan += 25;


            pgbGuc.Value = puan;
            if(puan==100)
            {
                label1.Text = "şifre güçlü";
                label1.ForeColor = System.Drawing.Color.Green;

            }
            else if(puan>=50)
            {
                label1.Text = "şifre orta seviyede";
                label1.ForeColor = System.Drawing.Color.Orange;

            }
            else

            {
                label1.Text = "şifre zayıf";
                label1.ForeColor = System.Drawing.Color.Red;

            }

        }
    }
}
