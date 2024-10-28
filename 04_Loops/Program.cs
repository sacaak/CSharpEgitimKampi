using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;
            //for (i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (i = 8; i < 21; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //int number;
            //Console.Write("Adet: ");
            //number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < number; i++) { 

            //    Console.WriteLine("C# öğreniyorum.");

            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //int i;
            //for (i = 1; i <= 100; i++) {
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}


            //int i,total = 0;
            //for (i = 0; i <= 3; i++)
            //{
            //    total += i;
            //}
            //Console.Write(total);


            /* 1 ile 20 arasındaki çift sayıların toplamı */

            //int i;
            //int total = 0;

            //for (i = 1; i <= 20; i++) { 

            //    if (i % 2 == 0) {
            //        Console.WriteLine(i);
            //        total += i;
            //    }
            //}

            //Console.WriteLine("--------");
            //Console.WriteLine(total);

            /* 1-50 arasında 7'ye tam bölünen sayıların sayısı */

            //int i;
            //int count = 0;

            //for(i = 1; i <= 50; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);


            ///* HER SEFERİNDE İKİYE BÖLÜNEN BAKTERİ (24 saat içinde kaç bakteri?) */

            //int bacterium = 1;

            //for (int i = 1; i <=24; i++)
            //{
            //    // 1. saatte -- = 2 bakteri
            //    // 2. saatte -- -- = 4 bakteri
            //    // 3. saatte -- -- -- -- = 8 bakteri
            //    // 4. saatte -- -- -- -- -- -- -- -- 16 bakteri
            //    // yani formül 2 ile çarpmak

            //    bacterium *= 2;
            //    Console.WriteLine( i +". saatte bakteri sayısı : " + bacterium);


            //}




            #endregion

            #region While Döngüsü

            // şart sağlandığı sürece

            //int i = 4;
            //while (i <= 10) { 
            //     Console.WriteLine(i);
            //    i++;

            //int i = 1;
            //while (i <= 10) {
            //    if (i % 3 == 0) {
            //        Console.WriteLine(i);                
            //    } 
            //    i++;
            //}          


            /* 1-10 arasındaki sayıların toplamı */

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);




            #endregion

            #region Örnek Sınav Sorusu

            /* KLAVYEDEN GİRİLEN 3 BASAMAKLI SAYININ BASAMAKLARI TOPLAMI */

            //int birler, onlar, yuzler, inputValue, kalan;
            //int sumValue = 0;

            //Console.Write("Sayıyı giriniz : ");
            //inputValue = int.Parse(Console.ReadLine());

            //if (inputValue < 100 | inputValue >999 )
            //{
            //    Console.WriteLine("Uygun sayı giriniz.");
            //}
            //else
            //{
            //    birler = inputValue % 10;
            //    kalan = inputValue / 10;
            //    onlar = kalan / 10;
            //    yuzler = kalan % 10;

            //    sumValue = birler + onlar + yuzler;

            //}

            //Console.WriteLine("Toplam: " + sumValue);

            // 1. 3 basamaklı olup olmadığını sına
            // daha sonra örneğin 123 girildi.
            // 123/10 kalan 3 
            // bölüm = 12/10 kalan 2 
            // kalan sayı da yüzler basamağı

            #endregion




            Console.Read();
        }
    }
}
