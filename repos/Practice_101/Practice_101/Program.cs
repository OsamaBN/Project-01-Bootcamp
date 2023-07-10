using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_101
{
    class Program
    {

        static void Main(string[] args)
        {
            int N = 5;
            
            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int count = 0;
            Random r = new Random();
            for ( int i = 0; i<N; i++)
            {
                int f = r.Next(0, chars.Length);
                int odd = 2 * i - 1;

                if (count<N)
                {

                    Console.Write(chars[f]);
                    count++;
                    
                }
                 
                 
            }

            Console.ReadKey();
        }
    }
}
