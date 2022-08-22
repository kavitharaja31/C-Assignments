using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class AreaAndCircum
    {
    public static void find(double radius)
    {
        double area=Math.PI*radius*radius;
        double circumference = 2 * Math.PI * radius;
        Console.WriteLine("Area of Circle = {0}Cirumference of Circle= {1}",area,circumference); 
        Console.ReadKey();  
    }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Clients
{
    public static void Main(string[] args)
    {
        SumofInt.sumofelements(40, 101, 201);
        Swapping.Swap(40, 41);
        AreaAndCircum.find(8);
        Console.ReadKey();
    }
}

