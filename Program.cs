using System;
using System.Collections;

namespace Algoritma_Soruları_Ödev1_3
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList kelimeler = new ArrayList() ;
           
           Console.WriteLine("Pozitif bir sayı giriniz: ") ;
           int n = Convert.ToInt32(Console.ReadLine()) ;

           Console.WriteLine("{0} tane kelime giriniz: ", n) ;

           for (int i = 0; i < n; i++)
           {
               string kelime = Console.ReadLine();
               kelimeler.Add(kelime) ;
           }
           
           Console.WriteLine("---Girdiğiniz kelimelerin sondan başa yazılmış hali---") ;

             kelimeler.Reverse() ;
             foreach (string c in kelimeler)
             {
                 Console.WriteLine(c);
             }
            
          
               
           
        }
    }
}
