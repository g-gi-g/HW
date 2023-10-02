namespace ConsApp1
{
    abstract class GeoObj
    {
        protected decimal XCoord;
        protected decimal YCoord;

        protected string Name;
        protected string Description;

        public GeoObj(decimal x, decimal y, string name, string description)
        { 
            XCoord = x;
            YCoord = y;
            Name = name;
            Description = description;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"X: {XCoord} Y: {YCoord}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
