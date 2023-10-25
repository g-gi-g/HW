using System.Text.Json;

namespace JsonProj;

class Program
{
    static async Task Main()
    {
        string path = @"Test.json";

        using FileStream fs = new FileStream(path, FileMode.OpenOrCreate);

        var books = await JsonSerializer.DeserializeAsync<List<Book>>(fs) ?? throw new Exception("List cannot be null");

        foreach (var book in books)
        {
            book.ShowInfo();
        }
    }
}