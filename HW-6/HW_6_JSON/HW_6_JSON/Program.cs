using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsApp1;

class Book
{ 
    public int PublishingHouseId { get; }

    public string Title { get; }

    [JsonPropertyName("PublishingHouse")]
    public Dictionary<string, string> publishingHouse;

    public Book(int publishingHouseId, string title)
    {
        PublishingHouseId = publishingHouseId;

        Title = title;

        publishingHouse = new Dictionary<string, string>();
    }

    //public void AddPublishingHouseInfo(string key, string info) 
    //{
        //publishingHouse [key] = info;
    //}

    public void ShowInfo() 
    {
        Console.WriteLine($"Publishing House Id: {PublishingHouseId}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine("Publishing house: ");

        foreach (var element in publishingHouse)
        {
            Console.WriteLine($"{element.Key}: {element.Value}");
        }
    }
}

class Program 
{
    static async Task Main()
    {
        string path = @"C:\Users\Егор\Desktop\ООП\ДЗ №6\Info.json";

        using (FileStream fs = new FileStream(path, FileMode.Create))
        {
            var books = await JsonSerializer.DeserializeAsync<List<Book>>(fs);

            foreach (var book in books)
            {
                book.ShowInfo();
            }
        }
    }
}