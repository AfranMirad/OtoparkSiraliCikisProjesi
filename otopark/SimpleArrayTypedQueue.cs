using ODEV_1__V1_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayTypedQueue
{
    public class SimpleArrayTypedQueue:Araba, IQueue
    {
        PriorityQueue pq;
        public object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public float average;

        public SimpleArrayTypedQueue(int size)                //Kuyruğa Boyutu Belirle
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)                          //Kuyruğa Eleman Ekle
        {
            if ((count == size) || (rear == size -1))
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;
            
            Queue[++rear] = o;
            count++;
        }
        public object Remove()                                //Kuyruktan Eleman Sil
        {
            if (IsEmpty())
                throw new Exception("Queue boş.");
            
            object temp = Queue[front];
            Queue[front] = null;
            front++;
            count--;

            return temp;
        }
        public bool IsEmpty()                                 //Count Değerini Kontrol Et
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
                temp += ("\n"+((Araba)Queue[i]).plaka + " plakasına sahip aracın bekleme süresi : ");             //Aracların Bekleme Süreleri temp e Atılır
                temp += ((Araba)Queue[i]).beklemeSuresi+Environment.NewLine;
            }
            for (int i = 0; i < size; i++)
            {
                if (i != 0)
                    ((Araba)Queue[i]).waitTime = ((Araba)Queue[i - 1]).beklemeSuresi + ((Araba)Queue[i - 1]).waitTime;

                tempWait += ("\n" + ((Araba)Queue[i]).plaka + " plakasına sahip aracın islem süresi : " + ((Araba)Queue[i]).waitTime+Environment.NewLine);
            }
            average = ((Araba)Queue[size-1]).waitTime/size;                                                  //Aracın İşlem Süreleri Hesaplanır.

            SendTemp += temp + tempWait + "\n\nOrtalama bekleme süresi : " + average + Environment.NewLine;
            return SendTemp;                                                                          //Ortalama Bekleme Süreleri Hesdaplanır
           

        }
        public object Send(int i)                             //Kuyruktaki Elemanlar Teker Teker Gönderilir
        {
            return Queue[i];
        }                         
    }
}
