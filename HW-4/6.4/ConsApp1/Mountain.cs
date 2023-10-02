using System.Xml.Linq;

namespace ConsApp1
{

    class Mauntain : GeoObj
    {

        private decimal HighestPoint;

        public Mauntain(decimal x, decimal y, string name, string description,
            decimal highestPoint) : base(x, y, name, description)
        { 
            HighestPoint = highestPoint;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"X: {XCoord} Y: {YCoord}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Highest point: {HighestPoint}");
        }

    }

}