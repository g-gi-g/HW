using System.Xml.Linq;

namespace ConsApp2
{

    class Mauntain : IGeoObj
    {
        private decimal XCoord;
        private decimal YCoord;

        private string Name;
        private string Description;

        private decimal HighestPoint;

        public Mauntain(decimal x, decimal y, string name, string description,
            decimal highestPoint)
        {
            XCoord = x;
            YCoord = y;
            Name = name;
            Description = description;
            HighestPoint = highestPoint;
        }

        public void GetInfo()
        {
            Console.WriteLine($"X: {XCoord} Y: {YCoord}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Highest point: {HighestPoint}");
        }

    }

}