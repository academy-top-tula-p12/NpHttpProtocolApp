using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpHttpProtocolApp
{
    static class Example
    {
        static async Task HttpClientHandler()
        {
            HttpMessageHandler handler = new HttpClientHandler();

            Console.WriteLine("Start");
            for (int i = 0; i < 1; i++)
            {
                using (var client = new HttpClient(handler, false))
                {
                    using var result = await client.GetAsync("https://yandex.ru");
                    Console.WriteLine(result.ToString());
                }
            }
            Console.WriteLine("Finish");
        }
    }
}
