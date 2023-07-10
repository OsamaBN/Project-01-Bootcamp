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
            Console.WriteLine("Enter the sentence : ");
            string sentence = Console.ReadLine();
            char[] delimiter = { ' ', ',', '.', ':', '\t' }; // /t is used to cater the extra space between te words
            string[] words = sentence.Split(delimiter);

            Console.Write("\n You have entered the following Sentence \n" + "\"" + sentence + "\"");

            foreach (string value in words) // To Print the values 
            {
                Console.Write("\n" + value + "\n");
            }
           
            for (int i = 0; i <= (words.Length - 1); i++)
            {
                int count = 1;
                for (int j = i + 1; j < (words.Length - 1); j++)
                {
                    if (words[j] == words[j + 1])
                    {
                        count++;
                      
                        Console.Write("\n" + "\t" + words[j] + " \t = \t" + count);
                        break;
                    }
                   

                }
            }
            /***************************************************************************************************************************************/
            Console.Write("\n\nPlease enter the number of sentences  : ");
            int num_of_words = Convert.ToInt16(Console.ReadLine());
            Random r = new Random();

            for (int i = 1; i <= (num_of_words); i++)
            {
                Console.Write("\nSentence " + i + " ");
                for (int j = 0; j <= 5; j++)
                {
                    string word = words[r.Next(0, words.Length - 1)];
                    Console.Write(word);
                }
            }
            /***************************************************************************************************************************************/
            Console.Write("\n\nNow finding the longest and shortest word in the sentence : \n");

            string temp_large = string.Empty, temp_small = string.Empty;

            int ctr_large = 0, ctr_small = words[0].Length;
            for (int i = 0, j = 0; i <= (words.Length - 1) && j <= (words.Length - 1); i++, j++)
            {
                if (words[i].Length > ctr_large)
                {
                    temp_large = words[i];
                    ctr_large = words[i].Length;
                }
                if (words[j].Length <= ctr_small)
                {
                    temp_small = words[j];
                    ctr_small = words[j].Length;
                }
            }
            Console.WriteLine("\nThe Largest word is : " + temp_large);
            Console.Write("The Smallest word is : " + temp_small);
            /***************************************************************************************************************************************/
            Console.WriteLine("\n\nEnter the word you want to search : \n");
            string word_search = Console.ReadLine();
            int count_1 = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == word_search)
                {
                    Console.WriteLine("The word \"{0}\" is found in the sentence ", word_search);
                    count_1++;
                }
            }

            /***************************************************************************************************************************************/
            Console.WriteLine("\nChecking if there are any palindromes : \n");
            //int left = 0;

            //for (int i = 0; i <= words.Length - 1; i++)
            //{
            //    for (int j = i + 1; j <= words.Length - 1; j++)
            //    {
            //        int right = (words[j].Length - 1);
            //        char[] input = words[j].ToCharArray();

            //        while (right > left)
            //        {
            //            if (input[left++] != input[right--])
            //            {

            //            }
            //            else
            //            {
            //                Console.Write(words[j]);
            //            }
            //        }

            //    }
            foreach (string item in words)
            {
                for (int i = 0; i < (item.Length) / 2; i++)
                {
                    if (item[i] != item[(item.Length) - i - 1])
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine(item);

                    }
                }
               
            }



            /***************************************************************************************************************************************/

            Console.WriteLine("Now finding the number of vowels and consonants : ");
            int vowels = 0, consonants = 0;

            for (int i = 0; i <= words.Length - 1; i++)
            {
                char[] inputstring = words[i].ToCharArray();

                for (int j = 0 ; j <= words.Length - 1; j++)
                {

                  
                    // Check if the character is a vowel
                    if (inputstring[j] == 'a' || inputstring[j] == 'e' || inputstring[j] == 'i' || inputstring[j] == 'o' ||  inputstring[j] == 'u' || inputstring[j] == 'A' ||inputstring[j] == 'E' || inputstring[j] == 'I' ||inputstring[j] == 'O' || inputstring[j] == 'U')
                    {

                        // Increment the vowels
                        vowels++;
                    }

                    // Check if the character is a alphabet other than vowels like !@#$%
                    
                    else if ((inputstring[j] >= 'a' && inputstring[j] <= 'z') || (inputstring[j] >= 'A' && inputstring[j] <= 'Z'))
                    {

                       
                        consonants++;
                    }
                }
            }

            // Display the count of vowels and consonant
            Console.WriteLine("\ncount of vowel = " + vowels);
            Console.WriteLine("\ncount of consonant = " + consonants);

            Console.ReadKey();
        }

        
    }
    
}
