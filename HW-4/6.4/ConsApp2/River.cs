namespace ConsApp2
{
    class River : IGeoObj
    {
        private decimal XCoord;
        private decimal YCoord;

        private string Name;
        private string Description;

        private decimal FlowSpeed;
        private decimal Length;

        public River(decimal x, decimal y, string name, string description,
            decimal flow, decimal length)
        {
            XCoord = x;
            YCoord = y;
            Name = name;
            Description = description;
            FlowSpeed = flow;
            Length = length;
        }

        public void GetInfo()
        {
            Console.WriteLine($"X: {XCoord} Y: {YCoord}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Flow Speed: {FlowSpeed}");
            Console.WriteLine($"Length: {Length}");
        }

    }

}
