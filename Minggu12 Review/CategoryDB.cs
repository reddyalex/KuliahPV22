using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minggu12_Review
{
    public static class CategoryDB
    {

        public static Category GetCategory(int categoryID)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=northwind");
            MySqlCommand cmd;
            try
            {
                conn.Open();
                cmd = new MySqlCommand("select * from category where categoryID=@id", conn);

                cmd.Parameters.AddWithValue("@id", categoryID);

                MySqlDataReader reader = cmd.ExecuteReader();
                Category category=null;
                if (reader.Read())
                {
                    category = new Category();
                    category.categoryId = (int)reader["category_id"];
                    category.categoryName = reader["category_name"].ToString();
                    category.description = reader["description"].ToString();
                    byte[] data = (byte[])reader["picture"];

                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(data))
                    {
                        Image image = new Bitmap(ms);
                        category.picture = image;
                    }


                }
                reader.Close();
                conn.Close();
                return category;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            
            



        }
        

    }
}
