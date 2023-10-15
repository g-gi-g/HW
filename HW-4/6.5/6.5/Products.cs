
namespace Supply;

public class Products
{
    public int Price { get; set; }
    public string CountryOfOrigin { get; set; }
    public string Name { get; set; }
    public string PackingDate { get; set; }
    public string Description { get; set; }

    public Products(int price, string origin, string name,
        string packing, string description) 
    {
        Price = price;
        CountryOfOrigin = origin;
        Name = name;
        PackingDate = packing;
        Description = description;
    }

}