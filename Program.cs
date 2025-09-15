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

            Console.WriteLine("BMI Kalkylator");
            Console.WriteLine("Ange din vikt i kg:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ange din längd:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ange enhet (metric/imperial), standard är metric:");
            string unit = Console.ReadLine();

            Console.WriteLine($"Din BMI är {CalculateBMI(weight, height, unit)}");

            // Vanligt anrop (metric, default)
            double bmi1 = CalculateBMI(weight, height);
            Console.WriteLine($"BMI (metric, default): {bmi1:F2}");

            // Namngivna argument i annan ordning
            double bmi2 = CalculateBMI(weight, height);
            Console.WriteLine($"BMI (metric, named args): {bmi2:F2}");

            // Namngivna argument + explicit enhet
            double bmi3 = CalculateBMI(unit: "imperial", weight: weight, height: height);
            Console.WriteLine($"BMI (imperial): {bmi3:F2}");

        }


    }
}
