using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine("Enter the sentence : ");
            string sentence = Console.ReadLine();
            char[] delimiter = { ' ', ',', '.', ':', '\t' }; // /t is used to cater the extra space between te words
            string[] words = sentence.Split(delimiter);

            Console.Write("\n You have entered the following Sentence \n" + "\"" + sentence + "\"");

            foreach (string value in words ) // To Print the values 
            {
                Console.Write("\n" + value);
            }

            for (int i = 0; i<(words.Length-1);i++)
            {
                if (words[i]==words[i+1])
                {
                    Console.Write("\n " + words[i]);
                    count++;
                }
                Console.Write("\n" + count);

            }

            Console.Write("\nPlease enter the number of sentences  : ");
            int num_of_words = Convert.ToInt16(Console.ReadLine());
            Random r = new Random();
            string word = words[r.Next(0, words.Length-1)];
            for (int i = 1; i<=(num_of_words);i++)
            {
                Console.Write("\nSentence " + i + " ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(word);
                }
            }

            Console.Write("\n\nNow finding the longest and shortest word in the sentence : \n");

            string temp_large = string.Empty, temp_small = string.Empty;
            
            int ctr_large = 0, ctr_small = 0;
            for(int i = 0 , j = 0; i<= (words.Length - 1)&& j <= (words.Length - 1); i++,j++)
            {
                if (words[i].Length > ctr_large)
                {
                    temp_large = words[i];
                    ctr_large = words[i].Length;
                }
                if (words[j].Length < ctr_small)
                {
                    temp_small = words[j];
                    ctr_small = words[j].Length;
                }
            }
            Console.WriteLine("\nThe Largest word is : " + temp_large);
            Console.Write("The Smallest word is : " + temp_small);

            Console.WriteLine("\n\nEnter the word you want to search : \n");
            string word_search =  Console.ReadLine();
            int count_1 = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == word_search)
                {
                    Console.WriteLine("The word \"{0}\" is found in the sentence ", word_search);
                    count_1++;
                }
            }


            Console.WriteLine("\nChecking if there are any palindromes : \n");
            int left = 0;
            
            for (int i = 0; i<words.Length-1;i++)
            {
                int right = (words[i].Length - 1);

                while (right > left)
                {
                    if (words[left++] != words[right--])
                    {
                        
                    }
                    else
                    {
                        Console.Write(words[i]);
                    }
                }
                
            }

                Console.ReadKey();
        }
    }
}
