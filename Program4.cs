using System;
using System.Collections;

namespace Algoritma_Soruları_Ödev1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList cümle = new ArrayList() ;

            Console.WriteLine("Bir cümle yazınız: ") ;
            string cümle = Console.ReadLine() ;
            string[] kelimeler = cümle.Split(' ') ;
            int k = cümle.Length ;
            int toplam = 0 ;
          
            Console.WriteLine("Cümledeki kelime sayısı: "  +kelimeler.Length) ;

           for (int i = 0; i <k ; i++)
           {
               if ( cümle[i] != ' ')
               toplam++ ;
                
           }

           Console.WriteLine("Cümledeki harf sayısı: " +toplam) ;
        }
    }
}
