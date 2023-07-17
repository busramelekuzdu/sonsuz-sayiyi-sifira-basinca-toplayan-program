using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for (; ; )
            {

               // sonsuz sayıyı sıfıra basınca toplayan program 
                int sayi,sayac=0, toplam = 0;
                do
                {
                    sayac++;//ortalama bulunurken eklenir 
                    Console.Write("sayıyı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                    toplam += sayi;
                } while (sayi!= 0);
               
                Console.WriteLine("işlemin sonucu:" + toplam);
                Console.WriteLine("ortalama=" +(toplam/(sayac-1)));//-1 yazmamızın mantığı sıfırı işin içinden çıkarmak.

                Console.ReadKey();
            }
        }
    }
}
