using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Swapping
    {
    public static void Swap(int c, int d)
    {
        c = c + d;
        d = c - d;
        c = c - d;

        Console.WriteLine(" After Swapping two integers: \na={0}\tb={1}",c,d);
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
