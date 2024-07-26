using System;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Collections.Generic;

namespace AsyncAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            SummonDogLocally();
            GetDataFromUrl();
            Console.Read();
        }
        static async Task SummonDogLocally()
        {
            using (FileStream fileStream = new FileStream("D:/Devanshu/C-Sharp-Learning/dog.txt", FileMode.Open, FileAccess.Read, FileShare.None, bufferSize: 4096, useAsync: true))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    String dog = await reader.ReadToEndAsync();
                    Console.WriteLine(dog);
                }
            }
        }
        static async Task GetDataFromUrl()
        {
            using(HttpClient client = new HttpClient())
            {
                String url = "https://api.coindesk.com/v1/bpi/currentprice.json";
                string result = await client.GetStringAsync(url);
                Console.WriteLine(result);
            }
        }
    }
}
