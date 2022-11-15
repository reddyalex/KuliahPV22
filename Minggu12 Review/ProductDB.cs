using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Minggu12_Review
{
    public static class ProductDB
    {

        public static List<Product> getAllProducts() {
            List<Product> products = new List<Product>();


            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=northwind");
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = new MySqlCommand("select product_id,product_name, category_id, quantity_per_unit, unit_price from products", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product temp = new Product();
                    temp.productID = (int)reader["product_id"];
                    temp.productName = reader["product_name"].ToString();
                    temp.quantityPerUnit = reader["quantity_per_unit"].ToString();
                    temp.unitPrice = (int)reader["unit_price"];
                    int kategoriID = (int)reader["category_id"];

                    temp.Category = CategoryDB.GetCategory(kategoriID);

                    products.Add(temp);
                }

                reader.Close();
                conn.Close();
                return products;

            }
            catch (Exception)
            {

                throw;
            }
            

        }
         



    }
}
