namespace LitwareLib
{
    public class Employee
    {
        private int EmpNo { get; set; } 
        private string EmpName { get; set; }
        private double Salary { get; set; }
        private double HRA { get; set; }       
        private double TA { get; set; }
        private double DA { get; set; }
        private double PF { get; set; }
        private double TDS { get; set; }
        private double NetSalary { get; set; }
        private double GrossSalary { get; set; }

        
        public Employee(int emp_num,string emp_name,double sal)
        {
            EmpNo = emp_num;
            EmpName = emp_name;
            Salary = sal;
            if (Salary < 5000)
            {
                HRA = 10 / 100 * Salary;
                TA = 5 / 100 * Salary;
                DA = 15 / 100 * Salary;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary >= 5000 && Salary < 10000)
            {
                HRA = 15 / 100 * Salary;
                TA = 10 / 100 * Salary;
                DA = 20 / 100 * Salary;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary >= 10000 && Salary < 15000)
            {
                HRA = 20 / 100 * Salary;
                TA = 15 / 100 * Salary;
                DA = 25 / 100 * Salary;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary >= 15000 && Salary < 20000)
            {
                HRA = 25 / 100 * Salary;
                TA = 20 / 100 * Salary;
                DA = 30 / 100 * Salary;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary >= 20000)
            {
                HRA = 30 / 100 * Salary;
                TA = 25 / 100 * Salary;
                DA = 35 / 100 * Salary;
                GrossSalary = Salary + HRA + TA + DA;
            }
            
        }
    
         public void CalculateSalary()
        {
        
            PF = 10 / 100 * GrossSalary;
            TDS = 18 / 100 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("NetSalary of Employee:{0}", NetSalary);
            Console.WriteLine("PF of Employee:{0}", PF);
        }
        public int empno
        {
            get { return EmpNo; }
            set { EmpNo = value; }
        }

        public string name
        {
            get { return EmpName; }
            set { EmpName = value; }
        }

        public double salary
        {
            get { return Salary; }
            set { Salary = value; }
        }
        public double gs
        {
            get { return GrossSalary; }
            set { GrossSalary = value; }
            }
  
        }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitwareLib;
class EmpManagement
{
    public static void Main(string[] args)
    {
        int ch, i = 0;
        Employee[] e = new Employee[9];
        List<Employee> employees = new List<Employee>(9);
        do
        {
            Console.WriteLine("press 1 to register new employee\npress 2 to display all employee\npress 3 to exit");
            Console.WriteLine("enter your choice");
            ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {

                Console.WriteLine("Enter Employee No");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                string b = Console.ReadLine();
                Console.WriteLine("Enter Employee's Salary");
                double c = Convert.ToDouble(Console.ReadLine());
                e[i] = new Employee(a, b, c);
                employees.Add(e[i]);
                i++;

            }

            else if (ch == 2)
            {
                for (int j = 0; j <= employees.Count; j++)
                {
                    Employee emp = employees[j];
                    Console.WriteLine("id={0} , name={1}, salary= {2}, gross salary={3}", emp.empno, emp.name, emp.salary, emp.gs);
                }
            }
            else if (ch == 3)
            {
                break;
            }
        } while (ch != 0); Console.ReadKey();
    }

}
