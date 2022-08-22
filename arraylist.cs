using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Framework
{
    public class Employee<A>
    {
        A[] Obj = new A[10];
        int count = 0;
        public void add(A item)
        {
            if (count + 1 < 11)
            {
                Obj[count] = item;
            }
            count++;
            Console.WriteLine("no.of employees" + count);
        }
        public A this[int index]
        {
            get { return Obj[index]; }
            set { Obj[index] = value; }
        }
    }
    class Prgm
    {
        static void Main(string[] args)
        {
            Program a = new Program();            
            Employee<string> emp = new Employee<string>();
            emp.add("Nikki");
            emp.add("Swathi");
            emp.add("Monika");
            emp.add("Reena");
            emp.add("Lohita");
            emp.add("Adhi");
            emp.add("Nandhini");
            emp.add("Sree");
            emp.add("Dinesh");
            emp.add("Sudarsan");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Employee details:");
                Console.WriteLine(emp[i]);
            }

        }
    }
}
