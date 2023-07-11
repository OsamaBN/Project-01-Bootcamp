using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_two
{

    public class BankAccount
    {

        public int accountnumber { get; set; }
        public string name { get; set; }
        public int balance { get; set; }

        public BankAccount(int AccountNumber, string Name, int Balance)
        {
            accountnumber = AccountNumber;
            name = Name;
            balance = Balance;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number : {accountnumber} \n Account Name : {name} \n Account Balance : {balance}");
        }

        public virtual void Deposit(int value)
        {
            balance += value;
            Console.WriteLine($"The amount {value} has been deposited in your bank account ");
        }
        public virtual void withdrawal(int value)
        {
            balance -= value;
            Console.WriteLine($"The amount {value} has been withdrawed in your bank account ");
        }


    }

    public class SavingsAccount : BankAccount
    {
        public int interestrate { get; set; }
        public SavingsAccount(int AccountNumber, string Name, int Balance, int InterestRate) : base(AccountNumber, Name, Balance)
        {
            interestrate = InterestRate;
        }

        public override void Deposit(int value)
        {
            balance -= value;
            Console.WriteLine($"The amount {value} has been withdrawed in your bank account ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
        }


    }

    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(int AccountNumber, string Name, int Balance) : base(AccountNumber, Name, Balance)
        {
            //Empty
        }
        public override void withdrawal(int value) 
        {
            if (balance - value < 0)
            {
                Console.WriteLine($"You cannot proceed with the withdrawal as your account has {base.balance}");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
            }
            balance -= value;
            Console.WriteLine($"The amount {value} has been withdrawed in your bank account ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
        }
    }

    public class Bank
    {
        public List<BankAccount> Abank { get; set; }
        public Bank()
        {
            Abank = new List<BankAccount>();

        }

        public void AddAccount( BankAccount bankAccount )
        {
            Abank.Add(bankAccount);
            Console.Write($"\nThe bank account has been added\n");
            Console.WriteLine($" Account Number : {bankAccount.accountnumber} \n Account Name : {bankAccount.name} \n Account Balance : {bankAccount.balance}");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
        }
            
        public void DepositToAccount(BankAccount bankAccount,int value)
        {
            bankAccount.Deposit(value);
        } 
        
        public void WithdrawFromAccount(BankAccount bankAccount, int value)
        {
            bankAccount.withdrawal(value);
        }

        public void display()
        {
            foreach (var item in Abank)
            {
                Console.WriteLine($" Account Number : {item.accountnumber} \n Account Name : {item.name} \n Account Balance : {item.balance}");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int op;
            
            BankAccount bankacct1 = new BankAccount(123456789, "Osama", 1000);
         CheckingAccount bankacct2 = new CheckingAccount(123456790, "Bin", 100);
            BankAccount bankacct3 = new BankAccount(123456791, "Nadeem", 10);

            Bank bank = new Bank();
            bank.AddAccount(bankacct1);
            bank.AddAccount(bankacct2);
            bank.AddAccount(bankacct3);

            bankacct1.Deposit(50);
            bankacct2.withdrawal(101);
            bankacct3.Deposit(25);





            bank.display();

            //jump:
            //Console.WriteLine("Please select an option : \n 1. Deposit \n 2. Withdraw \n 3. Display Accounts \n 4. Leave the Bank");
            //op = Convert.ToInt16(Console.ReadLine());

            //switch(op)
            //{
            //    case 1:

            //        break;

            //    default:
            //        Console.Write("Invalid Operation");
            //        break;
            //}
            //goto jump;

            Console.ReadLine();
        }
    }
}
