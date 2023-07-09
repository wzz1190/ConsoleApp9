using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sexdou
{
    class Program
    {
        public static void Main(string[] args)
        {
            //  string lu = Directory.GetCurrentDirectory();
             // connectionString = "Data Source=" + lu + "/mydb.db";
           // Console.WriteLine(connectionString);
           // hg();
            wihe(lu);
        }


        public static string connectionString = "";

        public static void hg()
        {



            User_listItem person = JsonConvert.DeserializeObject<User_listItem>(sqlbd.sqlcheck(connectionString).ToString());
            HttpPost.Ss(person.uid, person.sec_uid, connectionString);
            ConcurrentDictionary<int, string> ddc = SQLiteHelper.DoWorksqlwe(connectionString);
            godic(ddc);

        }

        static async Task<string> GetValueAsync(int key, string Value)
        {
            User_listItem person = JsonConvert.DeserializeObject<User_listItem>(Value);
            List<string> pp = HttpPost.goaweme(person.sec_uid);
            if (pp == null)
            {
                List<Item> items = new List<Item> { new Item { Name = key.ToString(), Value = 9 } };
                await SQLiteHelper.WriteDataAsync(connectionString, "", items);
                //sqlbd.whisex(idc, 9);
                return null;
            }
            int xt = 0;
            foreach (var item in pp)
            {
                robojosns.roboRoot rr = null;
                do
                {
                    rr = UploadLocal.stcc(item).Result;
                } while (rr == null);

                if (rr.predictions.Count > 0)
                {
                    if (rr.predictions[0].@class == "Girl" | rr.predictions[0].@class == "Woman")
                    {
                        xt++;
                    }
                }

            }
            if (xt > 5)
            {
                List<Item> items = new List<Item> { new Item { Name = key.ToString(), Value = 1 } };
                await SQLiteHelper.WriteDataAsync(connectionString, "", items);
                //sqlbd.whisex(idc, 1);
            }
            else
            {
                List<Item> items = new List<Item> { new Item { Name = key.ToString(), Value = 2 } };
                await SQLiteHelper.WriteDataAsync(connectionString, "", items);
            }
            return key.ToString();
        }

        public static void godic(ConcurrentDictionary<int, string> dictionary)
        {
            var semaphoreSlim = new SemaphoreSlim(3);

            // 启动多个异步任务并行处理字典中的键
            var tasks = new List<Task>();
            foreach (var key in dictionary.Keys)
            {
                tasks.Add(Task.Run(async () =>
                {
                    await semaphoreSlim.WaitAsync(); // 请求信号量

                    try
                    {
                        // 获取内容
                        var value = await GetValueAsync(key, dictionary[key]);

                        // 删除键
                        if (dictionary.TryRemove(key, out _))
                        {
                            Console.WriteLine($"Key '{key}' removed. Value: {value}");
                        }
                        else
                        {
                            Console.WriteLine($"Failed to remove key '{key}'");
                        }
                    }
                    finally
                    {
                        semaphoreSlim.Release(); // 释放信号量
                    }
                }));
            }

            // 等待所有任务完成
            Task.WhenAll(tasks);
            int six = 0;
            while (six!=tasks.Count) {
                six = 0;
                //WaitingForActivation
                //RanToCompletion  ok
                Thread.Sleep(100);
                foreach (var task in tasks)
                { 
                    var cas = task.Status.ToString();
                    if (cas== "RanToCompletion")
                    {
                        six++;
                    }
                };
            }


        }

        public static void wihe(string lu)
        {
            var s = SQLiteHelper.mdwihe(connectionString);
            using (StreamWriter writer = new StreamWriter("README.md", true))
            {
                foreach (var line in s)
                {
                    writer.WriteLine(line.Value+"\r\n");
                }
            }
            using (StreamWriter sw = new StreamWriter("README.md", true))
            {
                for (int i = 0; i < 3; i++)
                {
                    sw.WriteLine("\r\n" + DateTime.Now.ToString("HH:mm:ss") + "\r\n");
                }

            }



        }




    }
}
