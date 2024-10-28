using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net

            Console.WriteLine("***** C# Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");

            Console.Write("Getirmek istediğiniz tablo numarası : ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------");

            /* SQL CONNECTION */

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ESRRI0C\\SQLEXPRESS;" +
                "initial Catalog=EgitimKampiDb; integrated security= true");
            connection.Open();


            // SqlDataAdapter adapter = new SqlDataAdapter(command,connection);
            SqlCommand command = new SqlCommand("select * from Table_Category", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();


            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
