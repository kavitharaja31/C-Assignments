using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class bankbalance
    {
        public static double Atm_Pin { get; private set; }
        public delegate void Bank(int x);
        public class Bankaccount
        {
            public double AccountNo { get; set; }
            public string CustomerName { get; set; }
            public decimal bank_balance = 13434;
            public event Bank UnderBalance;
            public event Bank ZeroBalance;

            public void Insufficient(int i)
            {
                UnderBalance(i);
            }

            public void DepositAmount(int d)
            {
                ZeroBalance(d);
            }
            public void withdraw(int i)
            {
                if (i < bank_balance && bank_balance != 0)
                {
                    Console.WriteLine("please collect your money");
                    Console.WriteLine("Transaction Successfully made");
                    Console.WriteLine("Available Balance in your account:" + (bank_balance - i));
                }
                else if (i > bank_balance && bank_balance != 0)
                {
                    Console.WriteLine("Insufficient Amount");
                    Console.WriteLine("Your Current Balance is the account:" + bank_balance + "only");
                }
                else
                {
                    Console.WriteLine("Zero Balance in your account:" + bank_balance);
                }
            }
            public void deposit(int i)
            {
                Console.WriteLine("Balance after depositing amount:" + (bank_balance + i));
            }
        }
        static void Main(string[] args)
        {
            Account A = new Account();
            Console.WriteLine("Welcome Bank Customer!");
            Console.WriteLine("Enter Your Pin No");
            Atm_Pin = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("*Welcome to Bank ATM Service");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("select your choice: 1 or 2 ");
            string withdraw = Console.ReadLine();
            if (withdraw == "1")
            {
                Console.WriteLine("Enter your Withdraw amount");
                int withdrawbalance = int.Parse(Console.ReadLine());
                A.UnderBalance += new Bank(A.withdraw);
                A.Insufficient(withdrawbalance);
            }
            else
            {
                Console.WriteLine("Enter your Deposit amount:");
                int depositbalance = int.Parse(Console.ReadLine());
                A.ZeroBalance += new Bank(A.deposit);
                A.deposit(depositbalance);
            }
        }
    }
