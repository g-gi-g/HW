using PrototypeFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PrototypeFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*IFigure figure = new Rectangle(10, 20);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Circle(15);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();*/

            int[] xCoords = {0, 1, 2};
            int[] yCoords = {1, 1, 2};

            IFigure figure = new Triangle(xCoords, yCoords);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }

    interface IFigure
    {
        IFigure Clone();

        void GetInfo();
    }

    class Rectangle : IFigure
    {
        int width;
        int height;

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямокутник довжиною {0} и шириною {1}", height, width);
        }
    }
    class Circle : IFigure
    {
        int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(this.radius);
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг радіусом {0}", radius);
        }
    }

    class Triangle : IFigure 
    {
        private int[] xCoords = new int[3];

        private int[] yCoords = new int[3];

        public Triangle(int[] xCoords, int[] yCoords)
        {
            this.xCoords = xCoords;
            this.yCoords = yCoords;
        }

        public IFigure Clone() 
        {
            return (new Triangle(this.xCoords, this.yCoords));
        }

        public void GetInfo()
        {
            Console.WriteLine("Трикутник з координатами точок (x, y): ({0}, {1}), ({2}, {3}), ({4}, {5})", 
                xCoords[0], yCoords[0], xCoords[1], yCoords[1], xCoords[2], yCoords[2]);
        }
    }
}