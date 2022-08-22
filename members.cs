using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Prgrm
    {
        static void MethodInvestigation(Type T)
        {
            Console.WriteLine("Methods");
            MethodInfo[] methodInfos = T.GetMethods();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.Name);
            }
            
        static void FieldInvestigation(Type T)
        {
            Console.WriteLine("Fields");
            FieldInfo[] fieldInfos = T.GetFields();
            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                Console.WriteLine(fieldInfo.Name);
            }
        }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the explore name");
            string typName = Console.ReadLine();
            Type T = Type.GetType(typName);
            FieldInvestigation(T);
            MethodInvestigation(T);
            Console.ReadKey();
        }
    }
}
