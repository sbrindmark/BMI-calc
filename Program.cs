using System.Reflection.Metadata.Ecma335;

namespace BMI_calc
{
    internal class Program
    {
        static double CalculateBMI(double weight, double height, string unit = "metric")
        {
            if (unit == "metric")
            {
                return weight / (height * height);
            }
            else if (unit == "imperial")
            {
                return 703 * (weight / (height * height));
            }
            else
            {
                Console.WriteLine("Okänd enhet, returnerar 0.");
                return 0;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("BMI Kalkylator\n---------------------");

            // Inmatning med felhantering
            double weight;
            while (true)
            {
                Console.WriteLine("Ange din vikt i kg:");
                if (double.TryParse(Console.ReadLine(), out weight) && weight > 0)
                    break;
                Console.WriteLine("Ogiltig inmatning.");
            }

            double height;
            while (true)
            {
                Console.WriteLine("Ange din längd i meter:");
                if (double.TryParse(Console.ReadLine(), out height) && height > 0)
                    break;
                Console.WriteLine("Ogiltig inmatning.");
            }
            // Val av enhet med felhantering
            string unit;
            while (true)
            {
                Console.WriteLine("Ange enhet (metric/imperial), standard är metric:");
                unit = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(unit) || unit.Equals("metric", StringComparison.OrdinalIgnoreCase) || unit.Equals("imperial", StringComparison.OrdinalIgnoreCase))
                    break;
                Console.WriteLine("Ogiltig inmatning.");
            }


            // Vanligt anrop (metric, default)
            double bmi1 = CalculateBMI(weight, height);
            Console.WriteLine($"\nBMI (metric, default): {bmi1:F2}");

            // Namngivna argument i annan ordning
            double bmi2 = CalculateBMI(weight, height);
            Console.WriteLine($"BMI (metric, named args): {bmi2:F2}");

            // Namngivna argument + explicit enhet
            double bmi3 = CalculateBMI(unit: "imperial", weight: weight, height: height);
            Console.WriteLine($"BMI (imperial): {bmi3:F2}");

        }


    }

}
