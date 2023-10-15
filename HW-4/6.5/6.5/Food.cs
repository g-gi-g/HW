namespace Supply;

public class Food : Products
{ 
    public string ExpireDate { get; set; }
    public decimal Amount { get; set;}
    public string Unit { get; set;}

    public Food(int price, string origin, string name,
        string packing, string description, string expire,
        decimal amount, string unit) : base(price, origin, name,
        packing, description)
    { 
        ExpireDate = expire;
        Amount = amount;
        Unit = unit;
    }
}