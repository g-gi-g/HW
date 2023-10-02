
namespace Program;
class Program
{
    private static Converter? Converter = null;

    private static decimal ConvertFromStringToDecimal(string input)
    {
        if (!decimal.TryParse(input, out var output))
        {
            Console.WriteLine("Введені невірні дані");

            throw new Exception();
        }

        return output;
    }
    private static void HryvniaToDollar()
    { 
        Console.WriteLine("Введіть кількість гривні для конвертації");

        var strHryvnia = Console.ReadLine();

        decimal decHryvnia = ConvertFromStringToDecimal(strHryvnia);

        decimal result = Converter!.ExchangeHryvniaToDollar(decHryvnia);

        Console.WriteLine(result.ToString());
    }

    private static void HryvniaToEuro()
    {
        Console.WriteLine("Введіть кількість гривні для конвертації");

        var strHryvnia = Console.ReadLine();

        decimal decHryvnia = ConvertFromStringToDecimal(strHryvnia);

        decimal result = Converter!.ExchangeHryvniaToEuro(decHryvnia);

        Console.WriteLine(result.ToString());
    }

    private static void DollarToHryvnia()
    {
        Console.WriteLine("Введіть кількість доларів для конвертації");

        var strDollar = Console.ReadLine();

        decimal decDollars = ConvertFromStringToDecimal(strDollar);

        decimal result = Converter!.ExchangeDollarToHryvnia(decDollars);

        Console.WriteLine(result.ToString());
    }

    private static void EuroToHryvnia()
    {
        Console.WriteLine("Введіть кількість доларів для конвертації");

        var strEuro = Console.ReadLine();

        decimal decEuro = ConvertFromStringToDecimal(strEuro);

        decimal result = Converter!.ExchangeEuroToHryvnia(decEuro);

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
                    Console.WriteLine("Некоректна команда");
                    throw new Exception();
                }

                switch (command)
                {
                    case 1:
                        HryvniaToDollar();
                        break;
                    case 2:
                        HryvniaToEuro();
                        break;
                    case 3:
                        DollarToHryvnia();
                        break;
                    case 4:
                        EuroToHryvnia();
                        break;
                    default:
                        Console.WriteLine("Не вірний номер команди");
                        break;
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Сталася помилка. Завершення виконання програми");
        }
    }

}
