using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Inherit
    {

        class Employee
        {
            protected int EmpNo { get; set; }
            protected string EmpName { get; set; }
            protected double Salary { get; set; }
            protected double HRA { get; set; }
            protected double TA { get; set; }
            protected double DA { get; set; }
            public double PF { get; set; }
            protected double TDS { get; set; }
            protected double NetSalary { get; set; }
            protected double GrossSalary { get; set; }
            public Employee(int EmpNum, string Emp_Name, double Sal)
            {
                EmpNo = EmpNum;
                EmpName = Emp_Name;
                Salary = Sal;
                if (Salary < 6000)
                {
                    HRA = Salary * 10 / 100;
                    TA = Salary * 5 / 100;
                    DA = Salary * 15 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else if (Salary < 10000)
                {
                    HRA = Salary * 15 / 100;
                    TA = Salary * 10 / 100;
                    DA = Salary * 20 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else if (Salary < 16000)
                {
                    HRA = Salary * 20 / 100;
                    TA = Salary * 15 / 100;
                    DA = Salary * 25 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else if (Salary < 30000)
                {
                    HRA = Salary * 25 / 100;
                    TA = Salary * 20 / 100;
                    DA = Salary * 30 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else
                {
                    HRA = Salary + 30 / 100;
                    TA = Salary + 25 / 100;
                    DA = Salary + 35 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
            }
            public virtual void CalculateSalary()
            {
                PF = GrossSalary * (0.1);
                TDS = GrossSalary * (0.18);
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("NetSalary of Employee:{0}", NetSalary);
                Console.WriteLine("PF of Employee:{0}", PF);
            }

            public virtual void Grosssal()
            {
                Console.WriteLine("GrossSalary of Employee:{0}", GrossSalary);
            }

        }
        class Manager : Employee
        {
            private double PetrolAllowance { get; set; }
            private double FoodAllowance { get; set; }
            private double OtherAllowance { get; set; }
            public Manager(int EmpNum, string Emp_Name, double Sal) : base(EmpNum, Emp_Name, Sal)
            {
                PetrolAllowance = Salary * 8 / 100;
                FoodAllowance = Salary * 13 / 100;
                OtherAllowance = Salary * 3 / 100;
            }
            public override void Grosssal()
            {
                GrossSalary = (GrossSalary + PetrolAllowance + FoodAllowance + OtherAllowance);
                Console.WriteLine("GrossSalary of Manager :{0}", GrossSalary);
            }

            public override void CalculateSalary()
            {
                PF = GrossSalary * (0.1);
                TDS = GrossSalary * (0.18);
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("NetSalary of Manager :{0}", NetSalary);
                Console.WriteLine("PF of Manager:{0}", PF);
            }
        }
        class MarketingExecutive : Employee
        {
            private double kilometertravel { get; set; }
            private double TourAllowance { get; set; }
            private double TelephoneAllowance { get; set; }

            public MarketingExecutive(int EmpNum, string Emp_Name, double Sal, double klt) : base(EmpNum, Emp_Name, Sal)
            {
                kilometertravel = klt;
                TourAllowance = kilometertravel * 5;
                TelephoneAllowance = 1000;
            }
            public override void Grosssal()
            {
                GrossSalary = (GrossSalary + TourAllowance + TelephoneAllowance);
                Console.WriteLine("GrossSalary of MarketingExecutive:{0}", GrossSalary);
            }
            public override void CalculateSalary()
            {
                PF = GrossSalary * (0.1);
                TDS = GrossSalary * (0.18);
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("NetSalary of MarketingExecutive:{0}", NetSalary);
                Console.WriteLine("PF of MarketingExecutive:{0}", PF);
            }

        }
        public interface IPrintableinterface
        {
            void IPrintableMethod();

        }
        class Program : IPrintableinterface
        {
            public void IPrintableMethod()
            {
                Employee Emp1 = new Employee(1, "Abhi", 14000);
                Manager M1 = new Manager(2, "Amit", 25000);
                MarketingExecutive MarkE1 = new MarketingExecutive(3, "Ronit ", 40000, 10);
                Console.WriteLine("empNum:1", Emp1);
                Console.WriteLine("EmpName:Nikki", Emp1);
                Console.WriteLine("salary:32000", Emp1);
                Console.WriteLine("empNum:2", M1);
                Console.WriteLine("EmpName:Swathi", M1);
                Console.WriteLine("salary:14000", M1);
                Console.WriteLine("empNum:3", MarkE1);
                Console.WriteLine("EmpName:Vishnu", MarkE1);
                Console.WriteLine("salary:18000", MarkE1);
            }
            public static void Main(string[] args)
            {
                Program P = new Program();
                P.IPrintableMethod();
                Employee Emp1 = new Employee(1, "Nikki", 32000);
                Manager M1 = new Manager(2, "Swathi", 14000);
                MarketingExecutive MarkE1 = new MarketingExecutive(3, " Vishnu ", 18000, 10);
                Emp1.Grosssal();
                M1.Grosssal();
                MarkE1.Grosssal();
                M1.CalculateSalary();
                Emp1.CalculateSalary();
                MarkE1.CalculateSalary();

            Console.ReadKey();
            }
        }
    }
