
namespace Converter;
class Program
{
    private static Converter? Converter = null;

    private static decimal ConvertFromStringToDecimal(string input)
    {
        if (!decimal.TryParse(input, out var output))
        {
            throw new Exception("Incorrect data");
        }

        return output;
    }
    private static void ExchangeToDollar()
    {
        Console.WriteLine("Введіть кількість гривні для конвертації");

        var strHryvnia = Console.ReadLine();

        decimal decHryvnia = ConvertFromStringToDecimal(strHryvnia);

        decimal result = Converter!.ConverterToDollar(decHryvnia);

        Console.WriteLine(result.ToString());
    }

    private static void ExchangeToEuro()
    {
        Console.WriteLine("Введіть кількість гривні для конвертації");

        var strHryvnia = Console.ReadLine();

        decimal decHryvnia = ConvertFromStringToDecimal(strHryvnia);

        decimal result = Converter!.ConverterToEuro(decHryvnia);

        Console.WriteLine(result.ToString());
    }

    private static void ExchangeDollarTo()
    {
        Console.WriteLine("Введіть кількість доларів для конвертації");

        var strDollar = Console.ReadLine();

        decimal decDollars = ConvertFromStringToDecimal(strDollar);

        decimal result = Converter!.ConverterDollarTo(decDollars);

        Console.WriteLine(result.ToString());
    }

    private static void ExchangeEuroTo()
    {
        Console.WriteLine("Введіть кількість доларів для конвертації");

        var strEuro = Console.ReadLine();

        decimal decEuro = ConvertFromStringToDecimal(strEuro);

        decimal result = Converter!.ExchangeEuroTo(decEuro);

        Console.WriteLine(result.ToString());
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Програма для конвертації гривні в долар та євро.");
        Console.WriteLine("Вводьте одне число у рядок у вимірі гривня/валюта");

        try
        {
            Console.Write("Гривня до долара: ");

            var dollarStr = Console.ReadLine();

            Console.Write("Гривня до євро: ");

            var euroStr = Console.ReadLine();

            if (!(decimal.TryParse(dollarStr, out var dollarDec)
                | decimal.TryParse(euroStr, out var euroDec)))
            {
                Console.WriteLine("Некоректний курс валют");

                throw new Exception();
            }

            Converter = new Converter(dollarDec, euroDec);

            while (true)
            {
                Console.WriteLine("Виберіть, як хочете конвертувати валюту:");
                Console.WriteLine("1 - з гривні у долар");
                Console.WriteLine("2 - з гривні у євро");
                Console.WriteLine("3 - з долара у гривню");
                Console.WriteLine("4 - з євро у гривню");

                var choice = Console.ReadLine();

                if (!int.TryParse(choice, out var command))
                {
                    throw new Exception("Incorrect command error");
                }

                switch (command)
                {
                    case 1:
                        ExchangeToDollar();
                        break;
                    case 2:
                        ExchangeToEuro();
                        break;
                    case 3:
                        ExchangeDollarTo();
                        break;
                    case 4:
                        ExchangeEuroTo();
                        break;
                    default:
                        Console.WriteLine("Не вірний номер команди");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }

}
