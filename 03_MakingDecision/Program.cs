using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If & Else
            //string password;

            //Console.Write("Şifreyi giriniz: ");
            //password = Console.ReadLine();

            //if (password == "1234")
            //{
            //    Console.WriteLine("Giriş başarılı..");
            //}

            //else
            //{
            //    Console.WriteLine("Başarısız!");
            //}

            //string capital, country;

            //Console.Write("Başkent: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülke: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Cevabınız doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış");
            //}

            //int number;
            //Console.Write("Sayi giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5) {
            //    Console.WriteLine("Sayı doğru.");
            //    }
            //else
            //{
            //    Console.WriteLine("YANLIŞ!!");
            //}

            //double midtermExam, midterm1, finalExam, average;

            //string result;

            //Console.Write("Midterm = ");
            //midtermExam = int.Parse(Console.ReadLine());

            //Console.Write("Second Midterm = ");
            //midterm1 = int.Parse(Console.ReadLine());

            //Console.Write("Final Exam = ");
            //finalExam = int.Parse(Console.ReadLine());

            //average = (midtermExam + midterm1 + finalExam) / 3;

            //Console.WriteLine("Sınavların Ortalaması: " + average);


            //if (average < 35)
            //{

            //    result = "BAŞARISIZ, FF ile kaldınız.";
            //}
            //if (average >= 35 & average < 45)
            //{
            //    result = "Kötü, DD ile geçtiniz.";
            //}
            //if (average >= 45 & average < 50)
            //{
            //    result = "Kötü, DC ile geçtiniz.";
            //}
            //if (average >= 50 & average < 55)
            //{
            //    result = "Güzel, CC ile geçtiniz.";
            //}
            //if (average >= 55 & average < 63)
            //{
            //    result = "Güzel, CB ile geçtiniz.";
            //}

            //if (average >= 63 & average < 71)
            //{
            //    result = "Tebrikler, BB ile geçtiniz.";
            //}

            //if (average >= 71 & average < 80)
            //{
            //    result = "Tebrikler, BA ile geçtiniz.";
            //}

            //if (average >= 80 & average <= 100)
            //{
            //    result = "Tebrikler, AA ile geçtiniz.";
            //}

            //else
            //{
            //    result = "Hatalı giriş.";
            //}


            //Console.WriteLine(result);


            //string city;
            //Console.Write("Şehir: ");
            //city = Console.ReadLine();

            //if (city == "ankara" | city == "adana" | city == "burse")
            //{
            //    Console.WriteLine("Şehir mevcut!");
            //}
            //else {
            //    Console.WriteLine("Bulunamadı.");
            //}



            //string username, inputUsername;
            //username = "admin";

            //Console.Write("Kullanıcı adı: ");
            //inputUsername = Console.ReadLine();

            //if (inputUsername == username)
            //{
            //    Console.WriteLine("Hoş geldiniz..");
            //}
            //else {
            //    Console.WriteLine("Kullanıcı bulunamadı.");
            //}


            #endregion

            #region Mod İşlemleri

            /*  SAYININ BİRBİRİNE BÖLÜMÜNDEN KALAN */


            //int number = 26;

            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("1. Sayı: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayı: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine(result);


            /*  TEK|ÇİFT ÖRNEĞİ */

            //Console.Write("Kontrol edilecek sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0) {
            //    Console.WriteLine("Sayı çift");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları
            /*  TAKIM UYGULAMASI */

            //char team;

            //Console.Write("Takımınızın baş harfini girin: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("BEŞİKTAŞ");
            //}
            //if (team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("GALATASARAY");
            //}
            //if (team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("FENERBAHÇE");
            //}
            //if (team == 'T' | team == 't')
            //{
            //    Console.WriteLine("TRABZONSPOR");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");

            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("-----------------------------------------");


            //string menuItem;
            //Console.WriteLine();

            //Console.Write("Seçiminizi yazınız: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1") {
            //    Console.WriteLine();
            //    Console.WriteLine("--------------- ANA YEMEKLER ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Fasulye Pilav");
            //    Console.WriteLine("3- Fırında Somon");
            //    Console.WriteLine("4- Patlıcan Musakka");

            //    string anaYemek;
            //    Console.WriteLine();
            //    Console.Write("Ana yemeklerden seçiminizi yazınız: ");
            //    anaYemek = Console.ReadLine();

            //    if (anaYemek == "1")
            //    {
            //        Console.WriteLine("Köri Soslu Tavuk hazılanıyor..");
            //    }

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------  ÇORBALAR ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorbası");
            //    Console.WriteLine("3- Yoğurtlu Çorba");
            //    Console.WriteLine("4- Şehriye Çorbası");

            //    string anaYemek;
            //    Console.WriteLine();
            //    Console.Write("Çorbalardan seçiminizi yazınız: ");
            //    anaYemek = Console.ReadLine();

            //    if (anaYemek == "1")
            //    {
            //        Console.WriteLine("Mercimek Çorbası hazılanıyor..");
            //    }

            //}

            #endregion

            #region Switch Case

            //Console.Write("Ay: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak ayı seçilmiştir.");
            //        break;
            //    case 2: Console.WriteLine("Şubat ayı seçilmiştir.");
            //        break;
            //    case 3: Console.WriteLine("Mart ayı seçilmiştir.");
            //        break;
            //    case 4: Console.WriteLine("Nisan ayı seçilmiştir.");
            //        break;
            //    case 5: Console.WriteLine("Mayıs ayı seçilmiştir.");
            //        break;
            //    case 6: Console.WriteLine("Haziran ayı seçilmiştir.");
            //        break;
            //    case 7: Console.WriteLine("Temmuz ayı seçilmiştir.");
            //        break;
            //    case 8: Console.WriteLine("Ağustos ayı seçilmiştir.");
            //        break;
            //    case 9: Console.WriteLine("Eylül ayı seçilmiştir.");
            //        break;
            //    case 10: Console.WriteLine("Ekim ayı seçilmiştir.");
            //        break;
            //    case 11: Console.WriteLine("Kasım ayı seçilmiştir.");
            //        break;
            //    case 12: Console.WriteLine("Aralık ayı seçilmiştir.");
            //        break;
            //    default: Console.WriteLine("Hatalı veri girişi!");
            //        break;



            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int n1, n2, result;
            //char symbol;

            //Console.Write("1. sayıyı giriniz : ");
            //n1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz : ");
            //n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Seçim yapınız: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch(symbol)
            //{
            //    case '+': 
            //        result = n1 + n2;
            //        Console.WriteLine("Toplam = " + result);
            //        break;
            //    case '-': 
            //        result = n1 - n2;
            //        Console.WriteLine("Fark = " , result);
            //        break;
            //    case '*':
            //        result = n1 * n2;
            //        Console.WriteLine("Fark = ", result);
            //        break;
            //    case '/':
            //        result = n1 / n2;
            //        Console.WriteLine("Fark = ", result);
            //        break;

            //}

            #endregion


            Console.Read();
        }
    }
}
