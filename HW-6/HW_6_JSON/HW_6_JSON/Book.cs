namespace JsonProj;

class Book
{
    //[JsonIgnore] //2 Завдання
    public int PublishingHouseId { get; set; }

    //[JsonPropertyName("Name")] //3 Завдання
    public string? Title { get; set; }

    public PublishingHouse? PublishingHouse { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Publishing House Id: {PublishingHouseId}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine("Publishing house: ");

        Console.WriteLine($"Id: {PublishingHouse.Id}");
        Console.WriteLine($"Name: {PublishingHouse.Name}");
        Console.WriteLine($"Address: {PublishingHouse.Adress}");
    }
}