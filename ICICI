using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public delegate void Notify();
    class ICICI
    {
        protected double AccountNo;
        protected string CustomerName;
        protected double Balance;
        protected double Amount;
        public event Notify ZeroBalance;
        public event Notify UnderBalance;
        public void Diposit()
        {
            Console.WriteLine("Welcome to ICICI Bank");
            Console.WriteLine("enter account no");
            AccountNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the customer name");
            CustomerName = Console.ReadLine();
            Console.WriteLine("enter disposit amount");
            Balance = double.Parse(Console.ReadLine());
            Console.WriteLine("balance amount is" + ":" + Balance);
        }
        public virtual void WithDraw1()
        {
            Console.WriteLine("enter amount to withdrawl");
            Amount = int.Parse(Console.ReadLine());

            if (Balance == 0)
            {
                OnZeroBalance();
            }
            else if (Amount > Balance)
            {
                Onunderbalance();
            }
            else
            {
                Console.WriteLine("your balance is" + ":" + (Balance - Amount) + ";" + "ICICITRANSACTION SUCCESSFULL");
            }
        }
        protected virtual void OnZeroBalance()
        {
            ZeroBalance?.Invoke();
        }
        protected virtual void Onunderbalance()
        {
            UnderBalance?.Invoke();
        }
    }
    class ICICIBank
    {
        public static void Main()
        {
            ICICIBank account = new ICICIBank();
            account.Diposit();
            account.WithDraw1();
            account.ZeroBalance += z1_underorZeroBalance();
        }
        public static void z1_underorZeroBalance()
        {
            Console.WriteLine("Transaction cannot be continued as balance is zero in Account/insufficient");
        }
      
    }
