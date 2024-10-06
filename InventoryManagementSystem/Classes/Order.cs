using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace InventoryManagementSystem
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; }

        public List<OrderProduct> Products { get; set; } = new List<OrderProduct>();

        public void CreateOrder()
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sqlOrder = "INSERT INTO Orders (UserId, UserName, TotalAmount, OrderStatus, OrderDate) " +
                                  "VALUES (@UserId, @UserName, @TotalAmount, @OrderStatus, @OrderDate); " +
                                  "SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sqlOrder, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", UserId);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                    cmd.Parameters.AddWithValue("@OrderStatus", OrderStatus);
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);  


                    OrderId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void InsertOrderDetails()
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                foreach (var product in Products)
                {
                    string sqlProduct = "INSERT INTO OrderDetails (OrderId, ProductId, ProductName, Quantity, UnitPrice) " +
                                        "VALUES (@OrderId, @ProductId, @ProductName, @Quantity, @UnitPrice)";
                    using (SqlCommand cmd = new SqlCommand(sqlProduct, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderId", OrderId);
                        cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                        cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                        cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                        cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = @"SELECT o.OrderId, o.UserName, o.TotalAmount, o.OrderStatus, 
                              o.OrderDate, od.ProductName, od.Quantity, od.UnitPrice
                       FROM Orders o
                       JOIN OrderDetails od ON o.OrderId = od.OrderId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int orderId = reader.GetInt32(0);
                            var existingOrder = orders.FirstOrDefault(o => o.OrderId == orderId);

                            
                            if (existingOrder == null)
                            {
                                existingOrder = new Order
                                {
                                    OrderId = reader.GetInt32(0),         
                                    UserName = reader.GetString(1),      
                                    TotalAmount = reader.GetDecimal(2),   
                                    OrderStatus = reader.GetString(3),    
                                    OrderDate = reader.GetDateTime(4),    
                                    Products = new List<OrderProduct>()
                                };
                                orders.Add(existingOrder);
                            }

                            
                            existingOrder.Products.Add(new OrderProduct
                            {
                                ProductName = reader.GetString(5),    
                                Quantity = reader.GetInt32(6),     
                                UnitPrice = reader.GetDecimal(7)   
                            });
                        }
                    }
                }
            }
            return orders;
        }

        public static List<Order> GetOrdersByUserId(int userId)
        {
            List<Order> orders = new List<Order>();
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = @"SELECT o.OrderId, o.UserName, o.TotalAmount, o.OrderStatus, 
                              o.OrderDate, od.ProductName, od.Quantity, od.UnitPrice
                       FROM Orders o
                       JOIN OrderDetails od ON o.OrderId = od.OrderId
                       WHERE o.UserId = @UserId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int orderId = reader.GetInt32(0);
                            var existingOrder = orders.FirstOrDefault(o => o.OrderId == orderId);

                            if (existingOrder == null)
                            {
                                existingOrder = new Order
                                {
                                    OrderId = reader.GetInt32(0),         
                                    UserName = reader.GetString(1),       
                                    TotalAmount = reader.GetDecimal(2),   
                                    OrderStatus = reader.GetString(3),    
                                    OrderDate = reader.GetDateTime(4),    
                                    Products = new List<OrderProduct>()
                                };
                                orders.Add(existingOrder);
                            }

                            existingOrder.Products.Add(new OrderProduct
                            {
                                ProductName = reader.GetString(5),    
                                Quantity = reader.GetInt32(6),        
                                UnitPrice = reader.GetDecimal(7)      
                            });
                        }
                    }
                }
            }
            return orders;
        }

    }
}