namespace ConsApp1;

class Mountain : GeographicObject
{
    private readonly decimal highestPoint;

    public Mountain(decimal x, decimal y, string name, string description, decimal highestPoint)
        : base(x, y, name, description)
    {
        if (highestPoint < 0)
        {
            throw new ArgumentException($"'{nameof(highestPoint)}' connot be lower than 0", nameof(highestPoint));
        }

        this.highestPoint = highestPoint;
    }

    public decimal GetHighestPoint()
    { 
        return highestPoint;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"X: {x} Y: {y}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Highest point: {highestPoint}");
    }
}