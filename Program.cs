using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {                
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }                                
            }
            int tekToplam=0,ciftToplam=0;
            for (int i = 0; i <=1000; i++)
            {
                if (i%2==1)
                    tekToplam+=i;
                else
                    ciftToplam+=i;           
            }
            Console.WriteLine("tek toplam:"+tekToplam);
            Console.WriteLine("Çift toplam:"+ciftToplam);           
            //break continue
            for (int i = 0; i <=10; i++)
            {
                if (i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }            
        }
    }
}
