namespace ConsApp2;

class Mountain : IGeoraphicalObject
{
    private readonly decimal x;

    private readonly decimal y;

    private readonly string name;

    private readonly string description;

    private readonly decimal highestPoint;

    public Mountain(decimal x, decimal y, string name, string description,
        decimal highestPoint)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
        }

        if (string.IsNullOrEmpty(description))
        {
            throw new ArgumentException($"'{nameof(description)}' cannot be null or empty.", nameof(description));
        }

        if (highestPoint < 0)
        {
            throw new ArgumentException("Highest point connot be lower than 0.", nameof(highestPoint));
        }

        this.x = x;

        this.y = y;

        this.name = name;

        this.description = description;

        this.highestPoint = highestPoint;
    }

    public decimal GetXCoord()
    {
        return x;
    }

    public decimal GetYCoord()
    {
        return y;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public decimal GetHighestPoint() 
    { 
        return highestPoint;
    }

    public void GetInfo()
    {
        Console.WriteLine($"X: {x} Y: {y}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Highest point: {highestPoint}");
    }

}