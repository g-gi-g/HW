
namespace Program
{

    class Program
    {
        private static Converter Converter = null;

        private static void HryvniaToDollar()
        { 
            Console.WriteLine("Введіть кількість гривні для конвертації");

            var numOfHryvnia = Console.ReadLine();

            if (!decimal.TryParse(numOfHryvnia, out var hryvnia))
            {
                Console.WriteLine("Введені невірні дані");
                return;
            }

            decimal result = Converter.HryvniaDollar(hryvnia);
            Console.WriteLine(result.ToString());
        }

        private static void HryvniaToEuro()
        {
            Console.WriteLine("Введіть кількість гривні для конвертації");

            var numOfHryvnia = Console.ReadLine();

            if (!decimal.TryParse(numOfHryvnia, out var hryvnia))
            {
                Console.WriteLine("Введені невірні дані");
                return;
            }

            decimal result = Converter.HryvniaEuro(hryvnia);
            Console.WriteLine(result.ToString());
        }

        private static void DollarToHryvnia()
        {
            Console.WriteLine("Введіть кількість доларів для конвертації");

            var numOfDollars = Console.ReadLine();

            if (!decimal.TryParse(numOfDollars, out var dollars))
            {
                Console.WriteLine("Введені невірні дані");
                return;
            }

            decimal result = Converter.DollarHryvnia(dollars);
            Console.WriteLine(result.ToString());
        }

        private static void EuroToHryvnia()
        {
            Console.WriteLine("Введіть кількість доларів для конвертації");

            var numOfEuro = Console.ReadLine();

            if (!decimal.TryParse(numOfEuro, out var euro))
            {
                Console.WriteLine("Введені невірні дані");
                return;
            }

            decimal result = Converter.EuroHryvnia(euro);
            Console.WriteLine(result.ToString());
        }

        static void Main(string[] args) 
        {
            Console.WriteLine("Програма для конвертації гривні в долар та євро.");
            Console.WriteLine("Введіть курс валют у наступній послідовності: доллар, євро.");
            Console.WriteLine("Вводьте одне число у рядок у вимірі гривня/валюта");
            try
            {
                var dollarStr = Console.ReadLine();
                var euroStr = Console.ReadLine();

                if (!(decimal.TryParse(dollarStr, out var dollarDec)
                    | decimal.TryParse(euroStr, out var euroDec)))
                {
                    Console.WriteLine("Некоректний курс валют");
                    throw new Exception();
                }

                if (euroDec == 0 || dollarDec == 0)
                {
                    Console.WriteLine("Курс валют не може дорівнювати 0");
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

}
