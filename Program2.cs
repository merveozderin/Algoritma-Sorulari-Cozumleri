using System;
using System.Collections;

namespace Algoritma_Soruları_Ödev1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k=0 ;
            ArrayList sayilar = new ArrayList() ;
            Console.WriteLine("İki pozitif tam sayı giriniz: ") ;
            int sayi1 = Convert.ToInt32(Console.ReadLine()) ;
            int sayi2 = Convert.ToInt32(Console.ReadLine()) ;

            Console.WriteLine("{0} tane daha pozitif tam sayı giriniz: ", sayi1) ;
            for (int i = 0; i < sayi1 ; i++)
            {
                int sayi3 =Convert.ToInt32(Console.ReadLine()) ;
                sayilar.Add(sayi3) ;
            }

            Console.WriteLine("---Girdiğiniz sayılardan {0} 'e eşit olan ya da tam bölünen sayılar--- ", sayi2) ;
            foreach (int sayi in sayilar)
            {
                if ( sayi == sayi2 || (sayi)%(sayi2) == 0)
                { Console.WriteLine(sayi) ;
                  k++;
                }
            }

             if(k==0)
            {Console.WriteLine("{0} 'e eşit ya da tam bölünen sayı yok.", sayi2) ;}
        }
    }
}
