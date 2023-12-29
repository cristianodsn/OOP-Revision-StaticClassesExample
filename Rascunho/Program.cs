using System;
using System.Globalization;

namespace Rascunho
{
    class Program
    {      
        static void Main(string[] args)
        {        

            Console.Write("Input the radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circuference = Calculator.Circuference(radius);
            double volume = Calculator.Volume(radius);

            Console.WriteLine("Circuference: " + circuference.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI value: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }      

    }
}
