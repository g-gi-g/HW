
using System.Text;

namespace numInputCons {

    class Program {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть будь-яке ціле число: ");
            var num = Console.ReadLine();
            Console.WriteLine($"Ви ввели число {num}");
            Console.ReadKey();
        }

    }

}


