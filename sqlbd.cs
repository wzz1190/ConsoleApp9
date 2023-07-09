using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;

class sqlbd
{

   // public static string connectionString = "Data Source=E:\\mydb.db";
    public static void sqls(User_listItem stringitem, string connectionString)
    {
        string json = JsonConvert.SerializeObject(stringitem);
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            byte[] data = Encoding.UTF8.GetBytes(json);

            using (var commands = new SQLiteCommand($"SELECT COUNT(*) FROM People WHERE Uid='" + stringitem.short_id + "'", connection))
            {
                var count = (long)commands.ExecuteScalar();
                if (count == 0)
                {
                    // 不存在则写入
                    using (var command = new SQLiteCommand("INSERT OR IGNORE INTO People (Uid, Sid, Checks, Sex, Data) VALUES (@Uid, @Sid, @Checks, @Sex, @Data)", connection))
                    {
                        command.Parameters.AddWithValue("@Uid", stringitem.uid);
                        command.Parameters.AddWithValue("@Sid", stringitem.sec_uid);
                        command.Parameters.AddWithValue("@Checks", 0);
                        command.Parameters.AddWithValue("@Sex", 0);
                        command.Parameters.AddWithValue("@Data", data);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    // 存在则不写入，可以在这里抛出异常或者记录日志
                }
            }

            connection.Close();

        }
    }

    public static object sqlcheck(string connectionString)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (var command = new SQLiteCommand($"SELECT * FROM People WHERE Checks=0 AND Sex=1 LIMIT 1", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var id = reader.GetInt32(reader.GetOrdinal("Id"));
                        var value = reader.GetString(reader.GetOrdinal("Data"));
                        using (var updateCommand = new SQLiteCommand($"UPDATE People SET Checks=1 WHERE Id={id}", connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        // 返回第一个键值为 0 的数据
                        connection.Close();
                        command.Clone();
                        return value;

                    }
                    else
                    {
                        // 没有找到键值为 0 的数据，可以在这里抛出异常或者记录日志
                        connection.Close();
                        command.Clone();
                        return null;
                    }
                }
            }
        }


    }

    public static object sqlsex(string connectionString, ref int idc)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (var command = new SQLiteCommand($"SELECT * FROM People WHERE Sex=0 LIMIT 1", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idc = reader.GetInt32(reader.GetOrdinal("Id"));
                        var value = reader.GetString(reader.GetOrdinal("Data"));
                        connection.Close();
                        command.Clone();
                        return value;

                    }
                    else
                    {
                        // 没有找到键值为 0 的数据，可以在这里抛出异常或者记录日志
                        connection.Close();
                        command.Clone();
                        return null;
                    }
                }
            }
        }


    }

    public static object sqlsexyun(ref int idc, string connectionString)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (var command = new SQLiteCommand($"SELECT * FROM People WHERE Sex=1 LIMIT 1", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idc = reader.GetInt32(reader.GetOrdinal("Id"));
                        var value = reader.GetString(reader.GetOrdinal("Data"));
                        connection.Close();
                        command.Clone();
                        return value;

                    }
                    else
                    {
                        connection.Close();
                        command.Clone();
                        return null;
                    }
                }
            }
        }


    }

    public static void whisex(int idc,int bt, string connectionString)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (var command = new SQLiteCommand($"SELECT * FROM People WHERE Sex=0 LIMIT 1", connection))
            {
                using (var updateCommand = new SQLiteCommand($"UPDATE People SET Sex={bt} WHERE Id={idc}", connection))
                {
                    updateCommand.ExecuteNonQuery();
                }

                // 返回第一个键值为 0 的数据
                connection.Close();
                command.Clone();
            }
        }


    }

    public static void xixixi(string x, string connectionString)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

                var task = Task.Factory.StartNew(() =>
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                           // int n = i;
                            using (var command = connection.CreateCommand())
                            {
                                
                                command.Transaction = transaction;
                                command.CommandText = x;
                                command.ExecuteNonQuery();
                            }
                            Console.WriteLine($"成功");
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Insert failed: {ex.Message}");
                            throw;
                        }
                    }
                });
                           
            
            try
            {

                Task.WhenAll(task);
            }
            catch (AggregateException ex)
            {
                foreach (var inner in ex.InnerExceptions)
                {
                    Console.WriteLine($"Exception caught: {inner.Message}");
                }
            }
        }
    }
}
