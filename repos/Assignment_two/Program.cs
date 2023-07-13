using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_two
{
    public interface ITransaction
    {
        void ExecuteTransaction(double value);

        void PrintTransaction();
    }
    public interface IBankAccount                            // Interface use 'I; with the name : Pro approach
    {
        void Deposit(int value);
        void withdrawal(int value);

    }

    public abstract class BankAccount : IBankAccount                        //Inheritance + Abstract BASE class 
    {

        public int accountnumber { get; set; }               //Stated in the lecture the getters and setters are public whereas the accountnumber attribute is "Private" :)
        public string name { get; set; }
        public int balance { get; set; }

        public BankAccount(int AccountNumber, string Name, int Balance)
        {
            accountnumber = AccountNumber;
            name = Name;
            balance = Balance;
        }

        public abstract void DisplayAccountInfo();                        // Abstract function 

        public void Deposit(int value)
        {
            balance += value;
            Console.WriteLine($" The amount {value} has been deposited in your bank account \n");
        }
        public void withdrawal(int value)
        {
            balance -= value;
            Console.WriteLine($"The amount {value} has been withdrawed in your bank account ");
        }


    }

    public class SavingsAccount : BankAccount , ITransaction
    {
        public int interestrate { get; set; }
        public SavingsAccount(int AccountNumber, string Name, int Balance, int InterestRate) : base(AccountNumber, Name, Balance)
        {
            interestrate = InterestRate;
        }

        public void Deposit(int value)
        {
            int I = ((interestrate / 100) * value);
            balance = balance - (I + value);
            Console.WriteLine($"The amount {value} has been withdrawed in your bank account ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
        }
        public override void DisplayAccountInfo()                              // Abstract function Override
        {
            Console.WriteLine($"\nSavings Account\nAccount Name : {name} \n Account Number : {accountnumber} \n Account Balance ($) : {balance}");
        }

        public void ExecuteTransaction(double value)
        {

        }
       public void PrintTransaction()
        {

        }

    }

    public class CheckingAccount : BankAccount, ITransaction
    {
        public CheckingAccount(int AccountNumber, string Name, int Balance) : base(AccountNumber, Name, Balance)
        {
            //Empty
        }
        public void withdrawal(int value)
        {
            if (balance - value < 0)
            {
                Console.WriteLine($"\nWARNING\nYou cannot proceed with the withdrawal as your account has {base.balance}");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
            }
            else
            {
                balance -= value;
                Console.WriteLine($"The amount {value} has been withdrawed in your bank account ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
            }
        }
        public override void DisplayAccountInfo()                                                      // Abstract function Override 
        {
            Console.WriteLine($"\nAccount Name : {name} \n Account Number : {accountnumber} \n Account Balance ($) : {balance}");
        }
        public void ExecuteTransaction(double value)
        {

        }
        public void PrintTransaction()
        {

        }


    }

    public class LoanAccount: ITransaction
    {
        public LoanAccount ()
        {
            //Empty Constructor
        }
        public void ExecuteTransaction(double value)
        {

        }
        public void PrintTransaction()
        {

        }
    }

    public class Bank
    {
        public List<BankAccount> list_of_banks { get; set; }
        public Bank()
        {
            list_of_banks = new List<BankAccount>();

        }

        public void AddAccount(BankAccount bankAccount)
        {
            list_of_banks.Add(bankAccount);
            Console.Write($"\n\t\t\t\t\t\t\tNew Account Created\t\n");
            Console.WriteLine($" Account Number : {bankAccount.accountnumber} \n Account Name : {bankAccount.name} \n Account Balance ($) : {bankAccount.balance}");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
        }

        public void DepositToAccount(BankAccount bankAccount, int value)
        {
            bankAccount.Deposit(value);
        }

        public void WithdrawFromAccount(BankAccount bankAccount, int value)
        {
            bankAccount.withdrawal(value);
        }

        public void display()
        {
            foreach (BankAccount item in list_of_banks)
            {
                Console.WriteLine($" Account Number : {item.accountnumber} \n Account Name : {item.name} \n Account Balance ($) : {item.balance}");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int op;
            int an;
            int va;



            SavingsAccount bankacct1 = new SavingsAccount(1234567890, "Osama", 1000, 12);  //Dummy Database
            CheckingAccount bankacct2 = new CheckingAccount(1234567980, "Bin", 100);
            SavingsAccount bankacct3 = new SavingsAccount(123456791, "Nadeem", 10, 12);


            //BankAccount bankAccount = new BankAccount();        //Cannot create an instance of Abstract Class :(

            Bank bank = new Bank();
            bank.AddAccount(bankacct1);
            bank.AddAccount(bankacct2);
            bank.AddAccount(bankacct3);

            bankacct1.Deposit(50);
            bankacct2.withdrawal(101);
            bankacct3.Deposit(25);

        jump:
            Console.WriteLine("\t\t\t\t\t\t\tPlease select a option : \n\t\t\t\t\t\t\t1.Deposit \n\t\t\t\t\t\t\t2.Withdraw \n\t\t\t\t\t\t\t3.Exit from the Bank");
            op = Convert.ToInt16(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {

                        Console.WriteLine("Enter the Account Number : ");
                        an = Convert.ToInt32(Console.ReadLine());

                        foreach (BankAccount item in bank.list_of_banks)                           //checking the dummy datbase
                        {

                            if (an == item.accountnumber)                                           // int item.accountnumber
                            {
                                Console.Write("WELCOME\t" + item.name);
                                Console.WriteLine("\nEnter the Amount to be deposited : ");
                                va = Convert.ToInt16(Console.ReadLine());

                                //Boxing 
                                bank.DepositToAccount(item, va);
                                Console.WriteLine($" Account Number : {item.accountnumber} \n Account Name : {item.name} \n Account Balance ($) : {item.balance}");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");

                            }
                            else
                            {
                                //Console.Write($"There is no Such account with Account Number {an} ");
                            }
                        }
                        goto jump;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter the Account Number : ");
                        an = Convert.ToInt32(Console.ReadLine());

                        foreach (BankAccount item in bank.list_of_banks)                            //using item as a  
                        {

                            if (an == item.accountnumber)                                           // int item.accountnumber
                            {
                                Console.Write("WELCOME" + item.name);
                                Console.WriteLine("\nEnter the Amount to be Withdrawed : ");
                                va = Convert.ToInt16(Console.ReadLine());


                                bank.DepositToAccount(item, va);
                                Console.WriteLine($" Account Number : {item.accountnumber} \n Account Name : {item.name} \n Account Balance ($) : {item.balance}");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");

                            }
                            else
                            {
                                //Console.Write($"There is no Such account with Account Number {an} ");
                            }
                        }

                        goto jump;
                        break;
                    }
                case 3:
                    {

                        Console.WriteLine($"\nYou have left the bank :(\nHave a Nice Day !\n\n Enter any key to close the prompt......................");
                        break;
                    }
                default:
                    {
                        goto jump;
                    }
            }


            Console.ReadLine();



        }

    }
}


