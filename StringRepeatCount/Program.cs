using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeatCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeat());
            Console.WriteLine();
            CountvowelCon();
            Console.WriteLine();
            Occureance();
            Console.WriteLine();
            RemoveSpeciaChar();
            Console.WriteLine();
            Console.WriteLine(UniqueCharacter());
        }

        public static char FirstNonRepeat()
        {
            string s = "abcdac";

            Console.WriteLine(s);

            bool flag;

            Console.WriteLine("First non repeat character");

            for (int i = 0; i < s.Length; i++)
            {
                flag = false;

                for(int j = 0; j < s.Length; j++)
                {
                    if ((s[i] == s[j]) && i != j)
                    {
                        flag = true;
                        break;
                    }
                }

                if(!flag)
                {
                    return s[i];
                }
            }

            return default(char);

        }


        public static void CountvowelCon()
        {
            string s = "codenera";

            Console.WriteLine(s);

            int v = 0;
            int c = 0;

            char[] a = s.ToCharArray();

            for(int i=0; i<a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    v++;
                }
                else
                {
                    c++;
                }
            }

            Console.WriteLine("Count of vowels:  {0}", v );
            Console.WriteLine("Count of consonants:  {0}", c);

        }


        public static void Occureance()
        {
            string s = "javajava";

            Console.WriteLine(s);

            int c = 0;
            char ch = 'a';

            for(int i=0; i < s.Length; i++)
            {
                if (s[i] == ch)
                {
                    c++;
                }
            }

            Console.WriteLine("{0} Count is: {1}", ch, c );
        }


        public static void RemoveSpeciaChar()
        {
            string s = "@!$java@#ok";

            Console.WriteLine(s);

            StringBuilder sb = new StringBuilder();

            for(int i=0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                {
                    sb.Append(s[i]);
                }
            }

            Console.WriteLine("After remove special character");
            Console.WriteLine(sb.ToString());
        }


        public static bool UniqueCharacter()
        {
            string s = "abcdef";

            Console.WriteLine(s);

            Console.WriteLine("String contain all unique character");

            string one = " ";
            string two = " ";

            for(int i=0; i < s.Length ; i++)
            {
               one = s.Substring(i, 1);

                for(int j=0;  j < s.Length ; j++)
                {
                    two = s.Substring(j, 1);

                    if(one == two && i!=j)
                    {
                        return false;
                    }
                }
            }

            return true;

        }
    }
}
