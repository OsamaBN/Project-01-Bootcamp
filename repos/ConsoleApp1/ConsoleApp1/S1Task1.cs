using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class S1Task1
    {

        static void task1()
        {

            Console.WriteLine("Hello World !!");
            Console.ReadKey();                          // To prevent automatic closing of the CMD
        }

        static void task2()
        {
            Console.WriteLine("Enter Your Name : ");
            string output = Console.ReadLine();
            Console.WriteLine("Hello", output);
        }

        static void task3(int Number1, int Number2)
        {

            int sum = 0;
            sum = Number1 + Number2;
            string sum1 = Convert.ToString(sum);
            Console.WriteLine("The Sum is : " + sum1);
            Console.ReadKey();

        }
        static void task4(int num)
        {
            int number = 0;
            Console.WriteLine("Enter the num:");
            number = Convert.ToInt16(Console.ReadLine()); //Coversion from string to int to perform computations
            int sq = number * number;
            string sq1 = Convert.ToString(sq);            //Conversion to string from int to display 
            Console.WriteLine("The square of the number is : " + sq1);
            Console.ReadLine();
        }

        static void task5()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        static void task6()
        {
            int sum = 0;
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {

                sum = sum + i;
                Console.WriteLine("\n" + i);
            }
            string sum1 = Convert.ToString(sum);           
            Console.WriteLine("The sum is " + sum1);
            Console.ReadKey();
        }

        static void task7()
        {
            int table = 0;
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine();
                table = i * number;
                //string table1 = Convert.ToString(table);
                //string num1 = Convert.ToString(number);
                //string i1 = Convert.ToString(i);
                //  Console.WriteLine(num1 + "\t*\t" + i1 + "\t=\t" + table1);
                Console.WriteLine("{0} * {1} = {2}", number, i, table);
            }

            Console.ReadKey();
        }

        static void task8()
        {

            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt16(Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                  int isPrime = 0;              // A varaible for keeping a check
                for (int y = 1; y < i; y++)
                {
                    if (i % y == 0)
                        isPrime++;                    // IF its a prime the variable will increment 1 ie isPrime will have value = 1

                    if (isPrime == 2) break;          // Incase a number is divided twice , the variable isPrime will have value = 2
                }
                if (isPrime != 2)                    // If isPrime value = 1 , its  a prime number and it will be printed 
                    Console.WriteLine(i);

                isPrime = 0;
            }
            Console.ReadKey();

        }

        static void task9()
        {
            int f = 1;
            Console.WriteLine("Input the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                f = f * i;                                           //Multiplying the variable with uptil the number input by the user and saving it in an vaiable
            }
            Console.WriteLine("The Factorial of {0} is: {1}\n", num, f);
            Console.ReadKey();
        }

        static void task10()
        {
            Console.WriteLine("Input the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 0;


            if (num == 0)
            {
                Console.WriteLine("0");
            }
            else
            {

                for (int i = 2; i <= num; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                string b1 = Convert.ToString(b);
                Console.WriteLine(b1);
            }
            Console.ReadKey();
        }

        static void task11()
        {
            int []array = { 5, 3, 2, 1, 4 }; // yahan size kese fix kerna hai ? No idea 
            Console.WriteLine("Enter the number you want to search :");
            int num = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (num == array[i])           
                {
                    Console.WriteLine("The Number {0} has been found ", num);
                }


            }
            Console.ReadKey();
        }
        static void task12()
        {
                                                                              //Any string of length 1 is always a palindrome.
            Console.WriteLine("Enter the string :");
            string spell = Console.ReadLine();
            int left = 0;
            int right = (spell.Length) - 1;
            while (right > left)
            {
                if (spell[left++] != spell[right--])
                {
                    Console.WriteLine("The given string " + spell + "is NOT a palindrome"); //When the input string is Boys This line runs two times Cant solve the problem

                }

            }

            Console.WriteLine("The given string " + spell + " is a palindrome");

        }

        static void task13()
        {
            int[] array = { 6, 5, 9, 3, 1, 2, 4 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < ((array.Length) - 1); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            
            Console.WriteLine("The smallest Value is " + array[1]);
            
            Console.WriteLine("The Largest Value is " + array[(array.Length) - 1]);
            
            Console.ReadKey();

        }
        static void task14()
        {
            Console.WriteLine("\n\tIts right Angle Time\n\t");
            Console.WriteLine("Enter the height of the pyramid\n\t");
            int h = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= h; i++)
            {
                Console.WriteLine();

                for (int j = 1; j <= i; j++)
                {

                    Console.Write("*"); //if you will write Console.WriteLine it will automatically add new line hence only write line 

                }

            }

        }
        static void task15() //BIG PROBLEM
        {
            Console.WriteLine("\n\tIts Pyramid Time\n\t");
            Console.WriteLine("Enter the height of the pyramid\n\t"); 
            int h = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= h; i++)
            {

                for (int j = 1; j <= h - i; j++)
                { 

                    Console.Write(" ");

                }
                for (int k = 1; k <= ((2*i)-1);k++)   // The Matrix Technique ( columns = 2* rows - 1)
                {
                    Console.Write("*");
                }
                

                Console.WriteLine();

            }

        }

        static void task16()
        {
            
            Console.WriteLine("Enter the string you want to reverse :");
           string a = Console.ReadLine();
            for (int i = (a.Length-1); i>=0; i--)          // Ran a reverse loop 
            {
                
                Console.Write(a[i]);
            }
            
            Console.ReadKey();
        }

        static void task17()
        {
            Console.Write("\nGENERATING RANDOM ARRAY\n"); // Generated a randomn array instead of asking the user : just another way 
            Console.Write("\n\n");
            int [] array = new int [10];
            Random ran = new Random();
            for (int ctr = 0; ctr <= 9; ctr++)
            {
               
                int a = ran.Next(10);
                array[ctr] = a;
                Console.Write("\t{0}",array[ctr]);
               
            }
            for (int i = 0; i<(array.Length-1);i++)
            {
                for (int j = i+1 ; j < (array.Length); j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                        
                    }
                }
                
            }
            Console.Write("\n\n");
            foreach (int value in array)                   //Noice  way to print array 
            {
                
                Console.Write("\t" + value + " ");
            }

            Console.WriteLine("\n\nSmallest number is {0} ", array[0]);
            Console.WriteLine("\nlargest number is {0} ", array[(array.Length-1)]);

        }

      static  void task18()
        {
            
            Console.WriteLine("Enter the number :");
            int a = Convert.ToInt16(Console.ReadLine());
            int sum = 0;
            int[] array = new int[a];
            for (int i =1 ; i<a;i++)    //Donot start the loop with i =0 as it will result in an exception as anything divied by zero will give infinity ; basic maths
            {
                if (a % i == 0)
                {
                  
                    array[i] = i;
                    sum += i;
                    Console.Write(i); Console.WriteLine();
                }
               
            }
            
         
            if (sum == a)
            {
                Console.Write("The Number {0} is a perfect number ", a);
            }
            else
            {
                Console.Write("The Number {0} is NOT a perfect number ", a);
            }

        }

        static void task19()
        {
            Console.WriteLine("\n\tIts 123 time\n\t");
            Console.WriteLine("Enter the height of the pyramid\n\t");
            int h = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= h; i++)
            {
                Console.WriteLine();

                for (int j = 1; j <= i; j++)
                {
                    
                        Console.Write(j); //if you will write Console.WriteLine it will automatically add new line hence only write Console.Write
                    
                }

            }
        }

         static void task20()
         {
            string first_string = string.Empty;
            string second_string = string.Empty;
            Console.WriteLine("Enter the First String");
            first_string = Console.ReadLine();
            Console.WriteLine("Enter the Second String");
            second_string = Console.ReadLine();

            int h = (first_string.Length-1);
            int k = (second_string.Length-1);
            string result =string.Empty;
            for (int i = 0; i<=h; i++)
            {
                for (int j = 0 ; j<=k; j++)
                {
                    if (first_string[i]==second_string[j])
                    {
                        result += first_string[i];
                    }
                }
            }
            Console.WriteLine("\nThe longest common subsequence is " + result);
         }
        


       
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task2();
            //task3(5,6);
            //task4(9);
            //task5();
            //task6();
            //task7();
            //task8();
            //task9();
            //task10();
            //task11();
            //task12();
            //task13();
            //task14();
            // task15();  
            //task16();
            //task17();  
            // task18();
            //task19();
            //task20();
            
            Console.ReadKey();
        }
    }
}
