using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // multiply by 50
            Console.WriteLine("Enter a number: ");
            float num_1 = float.Parse( Console.ReadLine() );
            Console.WriteLine("Your number multiplied by 50 is: " + Convert.ToString( num_1 * 50.0 ));

            // add 25   
            Console.WriteLine("Enter a number: ");
            float num_2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Your number plus 25 is: " + Convert.ToString(num_2 + 25.0));

            // divide by 12.5
            Console.WriteLine("Enter a number: ");
            float num_3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Your number divided by 12.5 is: " + Convert.ToString(num_3 / 12.5));

            // greater than 50?
            Console.WriteLine("Enter a number: ");
            float num_4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Your number is greater than 50 - true/false: " + Convert.ToString(num_4 > 50));

            // remainder 
            Console.WriteLine("Enter a number: ");
            float num_5 = float.Parse(Console.ReadLine());
            Console.WriteLine("The remainder from dividing your number by 7 is: " + Convert.ToString(num_5 % 7));
        }
    }
}
