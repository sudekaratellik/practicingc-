using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicing1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i=0;
           // while (i < 11)
            {
                //Console.WriteLine(i);
               // i++;
               // Console.ReadKey();
            }

            //kullanıcıdan pozitif sayı girene kadar sayı girişi alan program
           // int sayi =0;
           // while (sayi >=0)
            {
                //Console.WriteLine("pozitif sayı giriniz negatif girerek programdan cıkabilirsiniz:");
                //Console.ReadLine();
                //Console.WriteLine("programdan çıktınız");
                //Console.ReadKey();

            }

            //1 den n e kadar olan sayılaırn toplamı n kullanıcıdan alınacak
           // Console.WriteLine("sayi giriniz:");
           //Console.ReadKey();
            //int n = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //int i = 1;

           // while (i < n)
            {
                //toplam += i;
                //i++;
                
            }
            //Console.WriteLine("1den" + n + "e kadar oalna sayıların toplamı:" + toplam);
            //Console.ReadKey();

            //1'den 20'ye kadar olan tek sayıları while döngüsü kullanarak ekrana yazdıran bir program yazın.
            //int i = 1;
            //while (i <= 20)
            {
                //if (i % 2 != 0)
                {
                    //Console.WriteLine(i);

                }
               // i++;
                //Console.ReadKey();
            }

            //Kullanıcının girdiği bir sayının faktöriyelini hesaplayan bir program yazın.
            Console.WriteLine("bir sayi giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int faktöriyel = 1;
            int i = 1;

            while (i <= n)
            {
                faktöriyel *= i;
                i++;
            }
            Console.WriteLine(n + "!=" + faktöriyel);
            Console.ReadKey();




        }
    }
}
