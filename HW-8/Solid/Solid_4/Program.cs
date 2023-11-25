using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

/*interface IItem
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);

    void SetColor(byte color);
    void SetSize(byte size);

    void SetPrice(double price);
}*/

interface IDiscountable
{
    void ApplyDiscount(double discount); //від 0 до 1

    void ApplyPromocode(string promocode);
}

interface IPhysicalParameters
{
    void SetColor(byte color);

    void SetSize(byte size);
}

interface IPrice
{
    void SetPrice(double price);
}

class Book : IDiscountable, IPrice
{ 
    private double price;

    public void SetPrice(double price)
    {
        if (price < 0)
        {
            throw new ArgumentException("Wrong price");
        }

        this.price = price;
    }

    public void ApplyDiscount(double discount)
    { 
        if (discount < 0 || discount > 1) 
        {
            throw new ArgumentException("Wrong discount");
        }

        price -= price * discount;
    }

    public void ApplyPromocode(string promocode) 
    {
        //...
    }

    public double GetPrice()
    {
        return price;
    }
}

class OuterWear : IPhysicalParameters, IPrice
{
    private double price;

    private byte color;

    private byte size;

    public void SetPrice(double price)
    {
        if (price < 0)
        {
            throw new ArgumentException("Wrong price");
        }

        this.price = price;
    }

    public void SetColor(byte color)
    { 
        this.color = color;
    }

    public void SetSize(byte size)
    { 
        this.size = size;
    }

    public byte GetColor()
    { 
        return color; 
    }

    public byte GetSize() 
    { 
        return size; 
    }

    public double GetPrice()
    {
        return price;
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}