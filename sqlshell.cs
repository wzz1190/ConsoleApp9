using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

public class Item
{
    public string Name { get; set; }
    public int Value { get; set; }
}

public static class SQLiteHelper
{
    private static readonly object LockObject = new object();

    public static async Task WriteDataAsync(string connectionString, string commandText, IEnumerable<Item> items)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            await connection.OpenAsync();

            await Task.WhenAll(items.AsParallel().Select(async item =>
            {
                using (var command = connection.CreateCommand())
                {
                    commandText = $"UPDATE People SET Sex={item.Value} WHERE Id={item.Name}";
                    command.CommandText = commandText;
                    Console.WriteLine(commandText);

                    // 异步执行插入操作
                    await Task.Run(() =>
                    {
                        try
                        {
                            lock (LockObject)
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    });
                }
            }));
        }
    }


    public static ConcurrentDictionary<int, string> DoWorksqlwe(string connectionString)
    {
        // 创建独立的数据库连接
        ConcurrentDictionary<int, string> dic = new ConcurrentDictionary<int, string>();
        using (SQLiteConnection threadConnection = new SQLiteConnection(connectionString))
        {
            threadConnection.Open();

            // 在事务中执行查询操作
            using (SQLiteTransaction transaction = threadConnection.BeginTransaction())
            {
                SQLiteCommand command = threadConnection.CreateCommand();
                command.Transaction = transaction;
                command.CommandText = $"SELECT * FROM People WHERE Sex=0 LIMIT 99";

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dic.TryAdd(reader.GetInt32(reader.GetOrdinal("Id")), reader.GetString(reader.GetOrdinal("Data")));
                       var idc = reader.GetInt32(reader.GetOrdinal("Id"));
                        var value = reader.GetString(reader.GetOrdinal("Data"));
                        Console.WriteLine(idc+";"+ value);
                    }
                }

                transaction.Commit();
            }

            threadConnection.Close();
        }
        return dic;
    }

    public static ConcurrentDictionary<int, string> mdwihe(string connectionString)
    {
        // 创建独立的数据库连接
        ConcurrentDictionary<int, string> dic = new ConcurrentDictionary<int, string>();
        using (SQLiteConnection threadConnection = new SQLiteConnection(connectionString))
        {
            threadConnection.Open();

            // 在事务中执行查询操作
            using (SQLiteTransaction transaction = threadConnection.BeginTransaction())
            {
                SQLiteCommand command = threadConnection.CreateCommand();
                command.Transaction = transaction;
                command.CommandText = $"SELECT * FROM People WHERE Sex = 1";

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dic.TryAdd(reader.GetInt32(reader.GetOrdinal("Id")), reader.GetString(reader.GetOrdinal("Sid")));
                        var idc = reader.GetInt32(reader.GetOrdinal("Id"));
                        var value = reader.GetString(reader.GetOrdinal("Sid"));
                        Console.WriteLine(idc + ";" + value);
                    }
                }

                transaction.Commit();
            }

            threadConnection.Close();
        }
        return dic;
    }

}