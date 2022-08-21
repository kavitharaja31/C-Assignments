using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Averagemarks
{
    static void Main(string[] args)
    {
        double s1, s2, s3, s4, s5, highestmarks;

        Console.WriteLine("Enter the marks of student1:");
        s1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the marks of student2:");
        s2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the marks of student3:");
        s3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the marks of student4:");
        s4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the marks of student5:");
        s5 = Convert.ToDouble(Console.ReadLine());
        double average = (s1 + s2 + s3 + s4 + s5) / 5;
        Console.WriteLine("Accept average marks of five students {0},{1},{2},{3},{4} is:{5}", s1, s2, s3, s4, s5, average);
        if (s1 > s2 && s1 > s3)
            highestmarks = s1;
        else if (s2 > s1 && s2 > s3)
            highestmarks = s2;
        else if (s3 > s2 && s3 > s4)
            highestmarks = s3;
        else if (s4 > s3 && s4 > s5)
            highestmarks = s4;
        else
            highestmarks = s5;
        Console.WriteLine("Highest marks among {0},{1},{2},{3},{4} is:{5}", s1, s2, s3, s4, s5, highestmarks);
        Console.ReadKey();
    }
}
