using ArrayTypedQueue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODEV_1__V1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleArrayTypedQueue sq;
        PriorityQueue pq;
        private void btn_dizigetir_Click(object sender, EventArgs e)                //Elemanlar Diziye Atanır
        {
            
            sq = new SimpleArrayTypedQueue(5);
            Random rnd = new Random();
            sq.Insert(new Araba { plaka = "18 K 720", renk = "Mavi", beklemeSuresi = rnd.Next(10, 300) });
            sq.Insert(new Araba { plaka = "34 I 183", renk = "Kırmızı", beklemeSuresi = rnd.Next(10, 300) });
            sq.Insert(new Araba { plaka = "25 Z 3943", renk = "Sarı", beklemeSuresi = rnd.Next(10, 300) });
            sq.Insert(new Araba { plaka = "45 E 186", renk = "TURKUAZ", beklemeSuresi = rnd.Next(10, 300) });
            sq.Insert(new Araba { plaka = "01 A 234", renk = "GRİ", beklemeSuresi = rnd.Next(10, 300) });
            txt_once.Text=sq.Write();
        }
        private void btn_oncelikli_Click(object sender, EventArgs e)                //Kuyruktaki Elemanları Öncelikli Kuyruğa Eklenir
        {
            pq = new PriorityQueue(5);
            for (int i = 0; i < 5 ; i++)
            {
                pq.Insert(sq.Send(i));
            }
            txt_sonra.Text=pq.Write();
           
        }
        private void btn_karsila_Click(object sender, EventArgs e)                  //Kuyruk İle Öncelikli Kuyruk Bekleme Süresi Karşılaştırılır
        {
            txt_karsila.Text = "";
            for (int i = 0; i < 5; i++)
            {
                
                if (((Araba)pq.Queue[i]).waitTime < ((Araba)sq.Queue[i]).waitTime)
                {
                    txt_karsila.Text += ((Araba)pq.Queue[i]).plaka + " Plakasna Sahip Araç :" + (((Araba)sq.Queue[i]).waitTime - ((Araba)pq.Queue[i]).waitTime) + " Saniye Daha Erken İşlem Bitmiştir"+Environment.NewLine;
                   
                }
            }
        }
        private void btnKazanc_Click(object sender, EventArgs e)                    //Bekleme Süresinin Kazancı Hesaplanır
        {
            txt_kazanc.Text = "Ortalama işlem tamamlanma süresindeki kazanç (%)= " +(sq.average/100-pq.average/100)+Environment.NewLine+
                                "Ortalama işlem tamamlanma süresindeki kazanç (fark)="+(sq.average-pq.average);
        }
    }
}
