
using System;
using System.Data.SqlClient;


namespace lab6_v6_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=lab6;Integrated Security=True";
           
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=lab6;Integrated Security=True";
            // Создание подключения
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }

            Console.Read();
        }
    }
}
