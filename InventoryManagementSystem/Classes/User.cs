using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public void CreateUser()
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "INSERT INTO Users (Name, Username, Password, IsAdmin) " +
                             "VALUES (@Name, @Username, @Password, @IsAdmin); " +
                             "SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@IsAdmin", IsAdmin);

                    UserId = Convert.ToInt32(cmd.ExecuteScalar());  // Get the inserted UserId
                }
            }
        }

        public static User GetUserByUsername(string userName)
        {
            User user = null;
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "SELECT UserId, Name, Username, Password, IsAdmin FROM Users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", userName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserId = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Username = reader.GetString(2),
                                Password = reader.GetString(3),
                                IsAdmin = reader.GetBoolean(4)
                            };
                        }
                    }
                }
            }
            return user;
        }

        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "SELECT UserId, Name, Username, Password, IsAdmin FROM Users";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                UserId = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Username = reader.GetString(2),
                                Password = reader.GetString(3),
                                IsAdmin = reader.GetBoolean(4)
                            };
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }

        public void UpdateName(int userId)
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "UPDATE Users SET Name = @Name " +
                             "WHERE UserId = @UserId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateUsername(int userId)
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "UPDATE Users SET Username = @Username " +
                             "WHERE UserId = @UserId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdatePassword(int userId)
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "UPDATE Users SET Password = @Password " +
                             "WHERE UserId = @UserId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteUser(int userId)
        {
            var dbManager = new DatabaseManager();
            using (var conn = dbManager.OpenConnection())
            {
                string sql = "DELETE FROM Users WHERE UserId = @UserId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
