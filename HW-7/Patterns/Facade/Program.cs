using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Examples
{ 
    class MainApp
    {
        public static void Main()
        {
            MicrowaveOven microwaveOven = new MicrowaveOven();
            microwaveOven.TurnOn();
            microwaveOven.TurnOff(); 
            Console.Read();
        }
    }

    class HeatingPlate
    {
        public void TurnOn()
        {
            Console.WriteLine("Heating plate is turned on");
        }

        public void TurnOff()
        { 
            Console.WriteLine("Heating plate is turned off");
        }
    }

    class Magnetron
    {
        public void TurnOn()
        {
            Console.WriteLine("Magnetron is turned on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Magnetron is turned off");
        }
    }
 
    class MicrowaveOven
    {
        private HeatingPlate heatingPlate;

        private Magnetron magnetron;
 
        public MicrowaveOven()
        {
            heatingPlate = new HeatingPlate();
            magnetron = new Magnetron();
        }

        public void TurnOn()
        {
            Console.WriteLine("Microwave oven is turned on");
            heatingPlate.TurnOn();
            magnetron.TurnOn();
        }

        public void TurnOff()
        {
            Console.WriteLine("Microwave oven is turned off");
            heatingPlate.TurnOff();
            magnetron.TurnOff();
        }
    }
}
