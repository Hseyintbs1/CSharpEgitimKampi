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
            //Ado.net

            Console.WriteLine("**** C# Veritabanlı Ürün-Kategori Bilgi sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            String tableNumber;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();


            SqlConnection connection = new SqlConnection("Data Source=HUSEYINT\\SQLEXPRESS; initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command;
            
            command = new SqlCommand("Select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows) 
            {
                foreach (var items in row.ItemArray)
                {
                    Console.Write(items + " ");
                }

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
