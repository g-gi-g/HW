namespace Program;

class Converter
{ 
    
    public decimal DollarRatio { get; set; }

    public decimal EuroRatio { get; set; }

    public Converter(decimal dollarRatio, decimal euroRatio)
    {
        ValidateUnit(dollarRatio);

        ValidateUnit(euroRatio);

        DollarRatio = dollarRatio;

        EuroRatio = euroRatio;
    }

    private void ValidateUnit(decimal value) 
    {
        if (value <= 0)
        {
            Console.WriteLine("Курс не може бути не додатним");

            throw new Exception();
        }
    }

    public decimal ExchangeHryvniaToDollar(decimal hryvnia)
    {
        ValidateUnit(hryvnia);

        decimal result = hryvnia/DollarRatio;

        return result;
    }

    public decimal ExchangeHryvniaToEuro(decimal hryvnia)
    {
        ValidateUnit(hryvnia);

        decimal result = hryvnia / EuroRatio;

        return result;
    }

    public decimal ExchangeDollarToHryvnia(decimal dollar)
    {
        ValidateUnit(dollar);

        decimal result = dollar * DollarRatio;

        return result;
    }

    public decimal ExchangeEuroToHryvnia(decimal euro)
    {
        ValidateUnit(euro);

        decimal result = euro * EuroRatio;

        return result;
    }
}