using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];

            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";



            //for (int i = 0; i <4; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //string[] colors = new string[4];

            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";



            //for (int i = 0; i <4; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //string[] cities = new string[5];

            //cities[0] = "Ankara";
            //cities[1] = "İstanbul";
            //cities[2] = "İzmir";
            //cities[3] = "Diyarbakır";
            //cities[4] = "Adana";

            //Console.WriteLine(cities[4]);

            //int[] number = new int[3];

            //number[0] = 175;
            //number[1] = 296;

            //Console.WriteLine(number[2]); // tanımlanmamışsa 0 değeri döndürür
            //Console.WriteLine(number[1]);


            /* STR İÇİNDE TANIMLAMA */

            //string[] cities = {"Prag", "Roma", "Atina", "Ankara", "Bursa"};




            #endregion

            #region Dizideki Elemanları Listeleme

            //string[] colors = { "Kırmızı", "Mavi", "Sarı", "Mor", "Siyah" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 48, 85, 52, 456, 1200, 1745, 150, };

            //for (int i = 0; i < numbers.Length; i++) {

            //    if (numbers[i] %3 == 0) {

            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            #endregion

            #region Dizideki En Büyük Elemanı Bulma

            //int[] numbers = { 1, 45, 93, 124, 56, 62, 789, 5584 };

            //int maxValue = 1;

            //for (int i = 0; i < numbers.Length; i++)
            //{


            //    if (maxValue < numbers[i])
            //    {
            //        maxValue = numbers[i];
            //    }
            //}

            //    Console.WriteLine(maxValue);

            #endregion

            #region Dizi Methodları

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };

            //Console.WriteLine(persons.Length);

            //int[] numbers = { 1, 2, 45, 83, 0, 75, 99, 12, 25 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) {
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 1, 2, 45, 83, 0, 75, 99, 12, 25 };
            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);


            //string[] customers = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };
            //int index = Array.IndexOf(customers, "Ayşe");
            //Console.WriteLine(index);
            // yoksa -1 döndürüyor.

            //int[] numbers = { 1, 2, 45, 83, 0, 75, 99, 12, 25 };
            //Console.WriteLine("Dizinin en büyük elemanı = " + numbers.Max());
            //Console.WriteLine("Dizinin en küçük elemanı = " + numbers.Min());

            #endregion

            #region Klavyeden Dizi Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++) {
            //    Console.Write($"{i + 1}. şehri giriniz : ");
            //    cities[i]= Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------------");

            //for (int i = 0; i < cities.Length; i++) { 
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++) {

            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);



            #endregion



            Console.Read();
        }
    }
}
