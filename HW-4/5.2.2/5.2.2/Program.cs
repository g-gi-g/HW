using System.Text;
using System.Xml.Serialization;

namespace Program
{

    class Prog
    {
        
        private static Team? CurrentTeam = null;
        static string? GetWorkerName()
        {
            Console.WriteLine("Введіть ім'я робітника");
            var name = Console.ReadLine();
            return name;
        }

        private static void AddDeveloper()
        {
            var name = GetWorkerName();

            if (name == null) 
            {
                Console.WriteLine("Некоректні дані");
                return;
            }

            var worker = new Developer(name);

            CurrentTeam.AddMember(worker);
        }

        private static void AddManager()
        {
            var name = GetWorkerName();

            if (name == null)
            {
                Console.WriteLine("Некоректні дані");
                return;
            }

            var worker = new Manager(name);

            CurrentTeam.AddMember(worker);
        }

        private static string? GetTeamName()
        {
            Console.WriteLine("Введіть ім'я команди");
            var name = Console.ReadLine();
            return name;
        }

        private static void AddTeam()
        {
            var name = GetTeamName();

            if (name == null)
            {
                Console.WriteLine("Некоректні дані");
                return;
            }

            CurrentTeam = new Team(name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Програма успішно запустилася. Можна вводити команди.");

            while (true) 
            {
                Console.WriteLine("Список доступних команд: ");

                Console.WriteLine("1 - Додати поточну команду.");

                if (CurrentTeam is not null)
                {
                    Console.WriteLine("2 - Додати розробника.");
                    Console.WriteLine("3 - Додати менеджера.");

                    Console.WriteLine("4 - Провести робочий день.");

                    Console.WriteLine("5 - Вивести список команди.");
                    Console.WriteLine("6 - Вивести деталізований список команди.");
                }

                Console.Write("Введіть номер команди: ");

                var command = Console.ReadLine();

                if (!int.TryParse(command, out var choice))
                {
                    Console.WriteLine("Некоректна команда.");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        AddTeam();
                        break;
                    case 2:
                        if (CurrentTeam is not null) { AddDeveloper(); }
                        else { Console.WriteLine("Ведіть спочатку команду, у яку додаєте розробника"); }
                        break;
                    case 3:
                        if (CurrentTeam is not null) { AddManager(); }
                        else { Console.WriteLine("Ведіть спочатку команду, у яку додаєте менеджера"); }
                        break;
                    case 4:
                        if (CurrentTeam is not null) { CurrentTeam.WorkADay(); }
                        else { Console.WriteLine("Ведіть спочатку команду, з якою будете працювати"); }
                        break;
                    case 5:
                        if (CurrentTeam is not null) { Console.WriteLine(CurrentTeam.GetInfo()); }
                        else { Console.WriteLine("Ведіть спочатку команду, яку хочете продивитися"); }
                        break;
                    case 6:
                        if (CurrentTeam is not null) { Console.WriteLine(CurrentTeam.GetDetailedInfo()); ; }
                        else { Console.WriteLine("Ведіть спочатку команду, яку хочете продивитися"); }
                        break;
                    default:
                        Console.WriteLine("Невідома команда");
                        break;
                
                }
            }
        }

    }

}