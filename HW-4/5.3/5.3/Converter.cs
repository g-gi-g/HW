namespace Program
{

    class Converter
    { 
        
        public static decimal DollarRatio { get; set; }

        public static decimal EuroRatio { get; set; }

        public Converter(decimal dollarRatio, decimal euroRatio)
        {
            DollarRatio = dollarRatio;
            EuroRatio = euroRatio;
        }

        static public decimal HryvniaDollar(decimal hryvnia)
        {
            decimal result = hryvnia/DollarRatio;
            return result;
        }

        static public decimal HryvniaEuro(decimal hryvnia)
        {
            decimal result = hryvnia / EuroRatio;
            return result;
        }

        static public decimal DollarHryvnia(decimal dollar)
        {
            decimal result = dollar * DollarRatio;
            return result;
        }

        static public decimal EuroHryvnia(decimal euro)
        {
            decimal result = euro * EuroRatio;
            return result;
        }
    }
}