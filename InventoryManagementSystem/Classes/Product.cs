using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public void CreateProduct()
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "INSERT INTO Products (ProductName, Quantity, Price) " +
                             "VALUES (@ProductName, @Quantity, @Price); " +
                             "SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", ProductName);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@Price", Price);

                    ProductId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public static List<Product> GetProductByName(string productName)
        {
            List<Product> products = new List<Product>();
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "SELECT ProductId, ProductName, Quantity, Price FROM Products WHERE ProductName LIKE @ProductName";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", "%" + productName + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductId = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                Quantity = reader.GetInt32(2),
                                Price = reader.GetDecimal(3)
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }

        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "SELECT ProductId, ProductName, Quantity, Price FROM Products";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductId = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                Quantity = reader.GetInt32(2),
                                Price = reader.GetDecimal(3)
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }

        public void UpdateProductName(int productId)
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "UPDATE Products SET ProductName = @ProductName " +
                             "WHERE ProductId = @ProductId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", ProductName);
                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProductQuantity(int productId)
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "UPDATE Products SET Quantity = @Quantity " +
                             "WHERE ProductId = @ProductId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProductPrice(int productId)
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "UPDATE Products SET Price = @Price " +
                             "WHERE ProductId = @ProductId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DecreaseQuantity(int productId, int orderQuantity)
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "UPDATE Products SET Quantity = Quantity - @OrderQuantity " +
                             "WHERE ProductId = @ProductId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderQuantity", orderQuantity);
                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteProduct(int productId)
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "DELETE FROM Products WHERE ProductId = @ProductId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
