namespace ConsApp1;

abstract class GeographicObject
{
    protected readonly decimal x;

    protected readonly decimal y;

    protected readonly string name;

    protected readonly string description;

    public GeographicObject(decimal x, decimal y, string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
        }

        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException($"'{nameof(description)}' cannot be null or whitespace.", nameof(description));
        }

        this.x = x;

        this.y = y;

        this.name = name;

        this.description = description;
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

    public virtual void GetInfo()
    {
        Console.WriteLine($"X: {x} Y: {y}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Description: {description}");
    }
}
