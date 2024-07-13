using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            int amount = 2034, deposit, withdraw;
            int choice, pin = 0;
            Console.WriteLine("Enter your 4 digits pin");
            pin = int.Parse(Console.ReadLine());
            while(pin!=0)
            {
                Console.WriteLine("welcome to sbi bank ATM service\n");
                Console.WriteLine("1.current balance\n");
                Console.WriteLine("2.withdraw\n");
                Console.WriteLine("3.deposite\n");
                Console.WriteLine("4.cancel\n");
                Console.WriteLine("*********************\n\n");
                Console.WriteLine("enter your choice:");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine(" \n your current blance is rs:{0}", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n enter  the withdraw amount:");
                        withdraw = int.Parse(Console.ReadLine());
                        if(withdraw % 100!=0)
                        {
                            Console.WriteLine("\n please enter the amount in above 100");
                        }
                        else if(withdraw>(amount-1000))
                        {
                            Console.WriteLine("\n please collect your cash");
                            Console.WriteLine("\n current balance is rs:{0}", amount);
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n please collect your cash");
                            Console.WriteLine("\n current balance is rs:{0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n enter the deposite amount");
                        deposit= int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("your amount has been deposite succesfully..");
                        Console.WriteLine("your total balance is rs:{0}",amount);
                        break;
                    case 4:
                        Console.WriteLine("\n Thank you");
                        break;
                }
            }
            Console.WriteLine("Thank you using sbi atm service");
        }
    }
}
