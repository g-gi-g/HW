using System;

/*class Rectangle
{
    public virtual int Width { get; set; }

    public virtual int Height { get; set; }

    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : Rectangle
{
    public override int Width
    {
        get 
        { 
            return base.Width;
        }

        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
    public override int Height
    {
        get 
        { 
            return base.Height;
        }

        set
        {
            base.Height = value;
            base.Width = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();
            rect.Width = 5;
            rect.Height = 10;

            Console.WriteLine(rect.GetRectangleArea());
            //Відповідь 100? Що не так???
            //Порушується принцип заміщення Лісков, бо квадрат не можна використовувати, як прямокутник, хоча він ним є
            //Тому потрібно використати різні інтерфейси, щоб дати користувачам зрозуміти, що в них різна поведінка
            Console.ReadKey();
        }
    }
}*/

interface IRectangle
{
    int Width { get; set; }

    int Height { get; set; }

    int GetRectangleArea();
}

interface ISquare
{ 
    int Side { get; set; }

    int GetSquareArea();
}

class Rectangle : IRectangle
{
    public virtual int Width { get; set; }

    public virtual int Height { get; set; }

    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

class Square : ISquare
{
    public int Side { get; set; }

    public int GetSquareArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IRectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;

        Console.WriteLine(rect.GetRectangleArea());
            
        Console.ReadKey();
    }
}
