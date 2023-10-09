namespace ConsApp2;

class River : IGeoraphicalObject
{
    private readonly decimal x;

    private readonly decimal y;

    private readonly string name;

    private readonly string description;

    private readonly decimal length;

    private readonly decimal flowSpeed;

    public River(decimal x, decimal y, string name, string description,
        decimal flowSpeed, decimal length)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
        }

        if (string.IsNullOrEmpty(description))
        {
            throw new ArgumentException($"'{nameof(description)}' cannot be null or empty.", nameof(description));
        }
        if (this.flowSpeed <= 0)
        {
            throw new ArgumentException($"'{nameof(flowSpeed)}' Flow cannot be 0 or less", nameof(River.flowSpeed));
        }

        if (length <= 0)
        {
            throw new ArgumentException($"'{nameof(length)}' Length cannot be 0 or less", nameof(length));
        }

        this.x = x;

        this.y = y;

        this.name = name;

        this.description = description;

        this.flowSpeed = flowSpeed;

        this.length = length;
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

    public decimal GetLength() 
    {
        return length;
    }

    public decimal GetFlowSpeed()
    { 
        return flowSpeed;
    }

    public void GetInfo()
    {
        Console.WriteLine($"X: {x} Y: {y}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Flow Speed: {flowSpeed}");
        Console.WriteLine($"Length: {length}");
    }

}
