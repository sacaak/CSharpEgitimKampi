using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degisken
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangaPrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangaPrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangaPrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");


            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;


            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangaPrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + " Birim Fiyat: " + applePrice + " - Gramaj:" + appleGram
            //    + " - Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal - " + " Birim Fiyat: " + orangaPrice + " - Gramaj:" + orangeGram
            //    + " - Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek - " + " Birim Fiyat: " + strawberryPrice + " - Gramaj:" + strawberryGram
            //    + " - Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates - " + " Birim Fiyat: " + potatoPrice + " - Gramaj:" + potatoGram
            //    + " - Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates - " + " Birim Fiyat: " + tomatoPrice + " - Gramaj:" + tomatoGram 
            //    + " - Toplam Tutar: " + tomatoTotalPrice);

            //Console.WriteLine();
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + strawberryTotalPrice + potatoTotalPrice;
            //Console.WriteLine("Total Price = " + shoppingTotalPrice);

            #endregion

            #region Char Degiskenler

            //char symbol;
            //symbol = 'a'; // tek tırnak arasında yazmak zorunlu charları
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden String Veri Girisi
            //Console.WriteLine("**** CSHARP HAVA YOLLARI ****");
            //Console.WriteLine();

            //string passengerName, passengerId, passengerSurname, passengerDistrict, passengerCity, passengerAge;


            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu ID: ");
            //passengerId = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaşınız: ");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine();


            //Console.WriteLine("-----------------------");
            //Console.WriteLine("TC Kimlik: " + passengerId + " - Yolcu Ad Soyad: " + passengerName + 
            // " " + passengerSurname + " - İl/İlçe: " + passengerDistrict + " / " + passengerCity + " " + 
            //    " - Yolcu Yaşı: " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeAmount, computerAmount, chairAmount, tvAmount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //// bu şekilde yazarsak hata verir çünkü int olarak tanımladık ve
            //// input alırken string olarak alıyoruz.
            // // shoeAmount = Console.ReadLine();

            //shoeAmount = int.Parse(Console.ReadLine());


            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerAmount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairAmount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvAmount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoeAmount * shoePrice) + (computerAmount * computerPrice) +
            //    (chairAmount * chairPrice) + (tvAmount * tvPrice);

            //Console.WriteLine();

            //Console.WriteLine("Toplam ödemeniz gereken tutar = " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double midtermExam, quiz, finalExam, result;

            //Console.Write("Midterm = ");
            //midtermExam = double.Parse(Console.ReadLine());

            //Console.Write("Quiz = ");
            //quiz = double.Parse(Console.ReadLine());

            //Console.Write("Final = ");
            //finalExam = double.Parse(Console.ReadLine());

            //result = (midtermExam +  quiz + finalExam) / 3;

            //Console.WriteLine("Ortamalanız = " + result);



            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Cinsiyetiniz : ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Cinsiyetiniz: " + gender);

            #endregion

            Console.ReadLine();
        }
    }
}