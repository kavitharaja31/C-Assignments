using System;

namespace HDFCBank
{
    class HDFCBank
    {
        public static void Main()
        {
            int amount = 1908, deposit, withdraw;
            int choice, pin = 0;
            Console.WriteLine("Enter 4 Digit Pin ");
            pin = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("WELCOME TO HDFC ATM SERVICE\n");
                Console.WriteLine("1. Current Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Cancel ");
                Console.WriteLine("ENTER YOUR OPTION: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("YOUR CURRENT BALANCE IS Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("PLEASE ENTER THE AMOUNT ABOVE RS.100");
                        }
                        else if (withdraw > 1000)
                        {
                            Console.WriteLine("Insufficient Money or Transaction cannot be continued below specified limit of Rs.- 1000");

                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = Convert.ToInt32(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY");
                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("Thank You Customer");
                        break;
                }
            }
        }
    }
}
