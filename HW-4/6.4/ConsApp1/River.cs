namespace ConsApp1
{
    class River : GeoObj
    { 
        private decimal FlowSpeed;
        private decimal Length;

        public River(decimal x, decimal y, string name, string description,
            decimal flow, decimal length) : base(x, y, name, description)
        { 
            FlowSpeed = flow;
            Length = length;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"X: {XCoord} Y: {YCoord}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Flow Speed: {FlowSpeed}");
            Console.WriteLine($"Length: {Length}");
        }
    
    }

}