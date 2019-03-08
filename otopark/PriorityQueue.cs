using ODEV_1__V1_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayTypedQueue
{
    public class PriorityQueue:Araba, IQueue
    {
        public object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;
        SimpleArrayTypedQueue sq;
        Araba arb;
        public float average;
        public PriorityQueue(int size)     //Kuyruğa Boyutu Belirle
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)       //Kuyruğa Eleman Ekle
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
            {
                int i;
                arb = (Araba)o;
                for (i = count - 1; i >= 0; i--)
                {
                    if (arb.beklemeSuresi < ((Araba)Queue[i]).beklemeSuresi)
                        //if ((string.Compare(urn.Ad,((Urun)Queue[i]).Ad)) == -1)
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
        }
        public object Remove()             //Kuyruktan Eleman Sil
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            object temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }
        public bool IsEmpty()              //Count Değerini Kontrol Et
        {
            return (count == 0);
        }
        public string Write()
        {
            string temp = "";
            string SendTemp = "";
            string tempWait = "";
           
            for (int i = 0; i < size; i++)
            {
                temp += ("\n" + ((Araba)Queue[i]).plaka + " plakasına sahip aracın bekleme süresi : ");    //Aracların Bekleme Süreleri temp e Atılır
                temp += ((Araba)Queue[i]).beklemeSuresi+Environment.NewLine;                             
            }
            ((Araba)Queue[0]).waitTime = 0;
            for (int i = 0; i < size; i++)
            {
                if (i != 0)
                    ((Araba)Queue[i]).waitTime = ((Araba)Queue[i - 1]).beklemeSuresi + ((Araba)Queue[i - 1]).waitTime;

                tempWait += ("\n" + ((Araba)Queue[i]).plaka + " plakasına sahip aracın islem süresi : " + ((Araba)Queue[i]).waitTime+Environment.NewLine);
            }
            average = ((Araba)Queue[size - 1]).waitTime / size;                                           //Aracın İşlem Süreleri Hesaplanır.
            SendTemp += temp  + tempWait + "\n\nOrtalama bekleme süresi : " + average+Environment.NewLine;
            return SendTemp;
        }
    }
}
