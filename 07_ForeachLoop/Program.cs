using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            // Foreach (1;2;3;4)

            // 1: Değişken türü
            // 2: Değişken adı
            // 3: In
            // 4: Liste, koleksiyon, dizi

            //string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Erzurum" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 74, 82, 32, 56, 154, 789, 541, 1024 };
            //foreach (int number in numbers) { 
            //    Console.WriteLine(number);
            //}


            /* DİZİDE Kİ ÇİFT SAYILAR */

            //int[] numbers = { 73, 82, 35, 56, 154, 789, 541, 1024 };

            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            /* DİZİDEKİ SAYILARIN TOPLAMI */
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //int total = 0;

            //foreach (int i in numbers) {

            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> list = new List<int>()
            //{
            //    1,2, 3, 4, 5, 6, 7, 8, 9, 10
            //};

            //foreach (int i in list) { 
            //Console.WriteLine(i);
            //}


            //string word = "Merhaba";

            //// string s in word yazınca çalışmıyor
            //foreach (char s in word) { 
            //Console.WriteLine(s);

            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Uygulaması *****");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();


            Console.Write("Sınıfınızda kaç öğrenci var? : ");
            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];


            for (int i = 0; i < studentCount; i++)
            {

                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;


                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrencinin" +
                        $" {j + 1}. sınav notunu giriniz :");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;

                }

                studentExamAvg[i] = totalExamResult / 3;

            }

            #endregion

            Console.Read();
        }
    }
}
