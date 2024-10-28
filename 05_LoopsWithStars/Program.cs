using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız

            //for (int i = 0; i <= 10; i++) { 

            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 Tane Yıldız

            //for (int i = 1; i <= 10; i++) { 

            //    Console.Write("*"+ " ");
            //}

            #endregion

            #region Alt Alta ve Yan Yana 10'ar tane yıldız

            //for(int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine("**********" );
            //}
            #endregion

            #region Dik Üçgen

            //for (int i = 1; i <= 5; i++) {

            //    for (int j = 1; j <= i ; j++) {

            //        Console.Write("*");

            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region Ters Dik Üçgen

            //for(int i = 1; i<= 5; i++)
            //{
            //    for(int j = 5; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yarım Elmas
            ///* önce bir üçgen sonra onun tersi */

            //for (int a = 1; a <= 5; a++) {

            //    for (int b = 1; b <= a; b++) {

            //        Console.Write("*");
            //    }
            //Console.WriteLine();
            //}




            //for (int i = 1; i <= 4; i++) {

            //    for (int j = 4; j >= i; j--) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for ( int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k=1; k<= 2* i - 1; k++)
            //    {
            //        Console.Write('*');
            //    }

            //    Console.WriteLine();
            //}

            #endregion



            Console.Read();
        }
    }
}
