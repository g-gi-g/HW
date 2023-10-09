namespace ConsApp1;

class River : GeographicObject
{ 
    private readonly decimal flowSpeed;

    private readonly decimal length;

    public River(decimal x, decimal y, string name, string description, decimal flowSpeed, decimal length)
        : base(x, y, name, description)
    {
        if (this.flowSpeed <= 0)
        {
            throw new ArgumentException($"'{nameof(flowSpeed)}' Flow cannot be 0 or less", nameof(River.flowSpeed));
        }

        if (length <= 0)
        {
            throw new ArgumentException($"'{nameof(length)}' Length cannot be 0 or less", nameof(length));
        }

        this.flowSpeed = flowSpeed;

        this.length = length;
    }

    public decimal GetLength()
    {
        return length;
    }

    public decimal GetFlowSpeed()
    {
        return flowSpeed;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"X: {x} Y: {y}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Flow Speed: {flowSpeed}");
        Console.WriteLine($"Length: {length}");
    }

}