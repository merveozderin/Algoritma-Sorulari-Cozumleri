using System;
using System.Collections;

namespace Algoritma_Soruları_Ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir tam sayi giriniz: ") ;
            int n = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Girdiğiniz sayi: " + n) ;

            ArrayList sayilar = new ArrayList();
            int i = 0;
            while (i < n) 
            {
                Console.WriteLine("{0}. Sayıyı Giriniz: ", i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());

                if ( sayi % 2== 0)
                {
                    sayilar.Add(sayi) ;
                    i++ ;
                }
                else
                    i++;
                
            }
            Console.WriteLine("--- Girdiğiniz Çift Sayılar ---");
            foreach (var a in sayilar)
            {   Console.WriteLine(a);}

            if( sayilar.Count == 0)
                Console.WriteLine("Girilen tüm sayılar tek sayıdır.") ;

            
        }
    }
}
