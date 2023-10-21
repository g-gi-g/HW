using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonProj;

class Program
{
    static async Task Main()
    {
        string path = @"C:\Users\Егор\Desktop\ООП\ДЗ №6\HW_6_JSON\HW_6_JSON\Test.json";

        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            var books = await JsonSerializer.DeserializeAsync<List<Book>>(fs);

            foreach (var book in books)
            {
                book.ShowInfo();
            }
        }
    }
}