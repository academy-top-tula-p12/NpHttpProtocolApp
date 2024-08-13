HttpMessageHandler handler = new HttpClientHandler();

Console.WriteLine("Start");
for(int i = 0; i < 1; i++)
{
    using(var client = new HttpClient(handler, false))
    {
        using var result = await client.GetAsync("https://yandex.ru");
        Console.WriteLine(result.ToString());
    }
}
Console.WriteLine("Finish");