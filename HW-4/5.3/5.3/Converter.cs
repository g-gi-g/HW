namespace Converter;

class Converter
{

    public decimal DollarExchangeRate { get; }

    public decimal EuroExchangeRate { get; }

    private static void ValidateUnit(decimal value)
    {
        if (value <= 0)
        {
            throw new Exception("Exchange rate cannot be 0 or less");
        }
    }

    public Converter(decimal dollarRatio, decimal euroRatio)
    {
        ValidateUnit(dollarRatio);

        ValidateUnit(euroRatio);

        DollarExchangeRate = dollarRatio;

        EuroExchangeRate = euroRatio;
    }

    public decimal ConverterToDollar(decimal hryvnia)
    {
        ValidateUnit(hryvnia);

        decimal result = hryvnia / DollarExchangeRate;

        return result;
    }

    public decimal ConverterToEuro(decimal hryvnia)
    {
        ValidateUnit(hryvnia);

        decimal result = hryvnia / EuroExchangeRate;

        return result;
    }

    public decimal ConverterDollarTo(decimal dollar)
    {
        ValidateUnit(dollar);

        decimal result = dollar * DollarExchangeRate;

        return result;
    }

    public decimal ExchangeEuroTo(decimal euro)
    {
        ValidateUnit(euro);

        decimal result = euro * EuroExchangeRate;

        return result;
    }
}