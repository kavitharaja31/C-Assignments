using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SumofInt
{
    public static void sumofelements(params int[] arr)
    {
        int sum = 0;

        foreach(int i in arr)
        {
            sum = sum + i;
        }
        Console.WriteLine("Sum of elements ={0}",sum);
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
