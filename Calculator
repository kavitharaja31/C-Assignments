using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class AppCalculator
{

    public static void Main(string[] args)
    {
        Console.WriteLine("APPLICATION FOR CALCULATOR");

        Console.WriteLine("Enter 1 for Addition");
        Console.WriteLine("Enter 2 for Subtraction");
        Console.WriteLine("Enter 3 for Multiplication");
        Console.WriteLine("Enter 4 for Division");

        Console.WriteLine("Enter first no");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second no");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("To perform the operations");
        Console.WriteLine("Enter any of the above options");
        int action = Convert.ToInt32(Console.ReadLine());

        switch (action)
        {
            case 1:
                Console.WriteLine("Result= {0}", a + b);
                break;
            case 2:
                Console.WriteLine("Result= {0}", a - b);
                break;
            case 3:
                Console.WriteLine("Result= {0}", a * b);
                break;
            case 4:
                    Console.WriteLine("Result= {0}", a / b);
                break;
            default:
                Console.WriteLine("error,try again");
                break;
        }
        Console.ReadKey();
    }
}

