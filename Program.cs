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



        }


    }
}
