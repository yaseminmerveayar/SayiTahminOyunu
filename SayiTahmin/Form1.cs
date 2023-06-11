using System;
using System.Windows.Forms;

namespace SayiTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }
        

            int kuymak = 0, tahminSayisi = 0, binler=0 ,yuzler=0 ,onlar=0 ,birler=0;    
            int bin = 0, yuz = 0, on = 0, bir = 0;    //degiskenlerimiz tum formda etkin olsun diye burada olusturduk
          
            
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            tahminSayisi = 0;
            int i = 0;
            while (i < 1)
            {
                Random tahmin = new Random();        //random sayi olusturuyoruz
                kuymak = tahmin.Next(1000, 10000);
                int sayi = kuymak;

                binler = sayi / 1000;               //sayilari basamaklarina ayiriyoruz
                sayi = sayi - (binler * 1000);      
                yuzler = sayi / 100;
                sayi = sayi - (yuzler * 100);
                onlar = sayi / 10;
                sayi = sayi - (onlar * 10);
                birler = sayi;

                if (binler != yuzler && binler != onlar && binler != birler && yuzler != onlar && yuzler != birler && onlar != birler)
                {
                    i++;              //ayni rakamlara sahip sayilar olusmasın diye sart sunuyoruz
                }
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int j = 0;

            do
            {
                int tahminiSayi = Convert.ToInt32(textBox1.Text);     //kullanicidan sayiyi aliyoruz
                bin = tahminiSayi / 1000;
                tahminiSayi = tahminiSayi - (bin * 1000);      //basamaklarina ayiriyoruz
                yuz = tahminiSayi / 100;
                tahminiSayi = tahminiSayi - (yuz * 100);
                on = tahminiSayi / 10;
                tahminiSayi = tahminiSayi - (on * 10);
                bir = tahminiSayi;

                if (bin != yuz && bin != on && bin != bir && yuz != on && yuz != bir && on != bir)
                    j++;            //ayni rakamdan iki tane olmasin diye sundugumuz sart
                else
                    MessageBox.Show("Gecersiz Sayi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //sayilar ayni olursa uyarmak icin
            } while (j < 0);

            int a = 0, b = 0;
            int kaymak = 0, sarma = 0, yasemin = 0, merve = 0, trabzon = 0, kovuktas = 0, tereyagi = 0, cay = 0;


            if (binler == bin)
                kaymak++;                   //sayilari dogru yerde bildiyse + kismi artırmak icin
            if (yuzler == yuz)
                sarma++;
            if (onlar == on)
                yasemin++;
            if (birler == bir)
                merve++;


            if (binler == yuz || binler == on || binler == bir)   //rakamlari bildiyse - kismi artirmak icin
                trabzon++;
            if (yuzler == bin || yuzler == on || yuzler == bir)
                kovuktas++;
            if (onlar == bin || onlar == yuz || onlar == bir)
                tereyagi++;
            if (birler == bin || birler == yuz || birler == on)
                cay++;

            a = kaymak + sarma + yasemin + merve;
            b = trabzon + kovuktas + tereyagi + cay;

            tahminSayisi++;
            textBox2.Text = "+" + a + ", - " + b;        //ipucuyu yazdiriyoruz



            if (a == 4 && b == 0)
            {
                MessageBox.Show("TEBRİKLER " + kuymak + " sayisini " + Convert.ToString(tahminSayisi) + " tahminde buldunuz", "ZEKİ BIDIK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}




























