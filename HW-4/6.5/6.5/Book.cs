namespace Supply;

public class Book : Products
{
    public int NumberOfPages { get; set; }
    public string PublishingHouse { get; set; }
    public string Writers { get; set; }

    public Book(int price, string origin, string name,
        string packing, string description, int pages, 
        string publisher, string writers) : base(price, origin, name,
        packing, description)
    {
        NumberOfPages = pages;
        PublishingHouse = publisher;
        Writers = writers;
    }
}