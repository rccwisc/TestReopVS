using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReopVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(value: "Enter palindrome:  ");
            var input = Console.ReadLine();
            Console.WriteLine("{0} is typeof {1}", input, input.GetType());
            string reverse = Reverse(input);
            if ( input.Equals(reverse) )
            {
                Console.WriteLine("yep palindrome");
            } else
            {
                Console.WriteLine("nope not a palindrome {0}.NotEquals({1})",input,reverse);
            }

            // another way
            var rev = input.Reverse<char>();

            Console.WriteLine("REVERSED");
            bool ans = true;
            int i = 0;
            foreach(char c in rev)
            {
               if(input[i] != c)
                {ans = false;}
                i++;
            }
            Console.WriteLine("New way ans is {0}",ans);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
