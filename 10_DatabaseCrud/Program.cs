using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD İşlemleri
            //Create Read Update Delete

            Console.WriteLine("**** Menü Sipariş işlem paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------------------");
            #region Kategori ekleme işlemleri
            //Console.Write("Eklemek istediğiniz Kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=HUSEYINT\\SQLEXPRESS; initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Kategori eklendi.");
            //connection.Close();
            #endregion

            #region Ürün Ekleme İşlemleri

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün fiyatı: ");
            //productPrice = Convert.ToDecimal(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=HUSEYINT\\SQLEXPRESS; initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün eklendi.");


            #endregion

            #region Ürün Listeleme İşlemleri

            //SqlConnection connection = new SqlConnection("Data Source=HUSEYINT\\SQLEXPRESS; initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    Console.WriteLine("Ürün Adı: " + row["ProductName"]);
            //    Console.WriteLine("Ürün Fiyatı: " + row["ProductPrice"]);
            //    Console.WriteLine("Ürün Durumu: " + row["ProductStatus"]);
            //    Console.WriteLine("-------------------------------");
            //}
            //connection.Close();
            #endregion

            #region Ürün silme işlemleri
            //Console.WriteLine("Silmek istediğiniz ürün id'sini giriniz: ");
            //int productId=int.Parse(Console.ReadLine());  
            //SqlConnection connection = new SqlConnection("Data Source=HUSEYINT\\SQLEXPRESS; initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün silindi.");

            #endregion

            #region Ürün Güncelleme işlemleri
            //Console.Write("Güncellemek istediğiniz ürün id'sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Yeni Ürün adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Yeni Ürün fiyatı: ");
            //decimal productPrice = Convert.ToDecimal(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=HUSEYINT\\SQLEXPRESS; initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update  TblProduct set ProductName=@productName, ProductPrice=@productPrice where ProductID=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün Güncellendi.");


            #endregion

            Console.Read();
        }
    }
}
