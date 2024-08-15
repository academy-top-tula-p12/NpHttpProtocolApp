// Http - hypertext transfer protocol

/*
    GET
    POST
    PUT
    DELETE

    Rest API
*/

HttpClient httpClient = new HttpClient();

//using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://yandex.ru");
//using HttpResponseMessage response = await httpClient.SendAsync(request);

using HttpResponseMessage response = await httpClient.GetAsync("https://yandex.ru");

Console.WriteLine($"Status code: {response.StatusCode}");

Console.WriteLine("Headers:");
foreach(var header in response.Headers)
{
    Console.WriteLine($"header key: {header.Key}");
    foreach(var value in header.Value)
        Console.WriteLine($"\t{value}");
}

Console.WriteLine("\nContent:");
Console.WriteLine(await response.Content.ReadAsStringAsync());
Console.WriteLine();

string content = await httpClient.GetStringAsync("https://yandex.ru");
Console.WriteLine(content);
Console.WriteLine();
    
