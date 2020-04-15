using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 89;
            int b = 201;
            int result1, result2, result3, result4;

            Program p = new Program();
            result1 = p.FindMax(104, 296);
            Console.WriteLine("FindMax() vrednost je {0}", result1);
            result2 = FindMaxStatic(b, a);
            Console.WriteLine("FindMaxStatic() vrednost je {0}", result2);
            result3 = Factorial(3);
            result4 = Factorial(5);
            Console.WriteLine("Factorial(3) = {0}", result3);
            Console.WriteLine("Factorial(5) = {0}", result4);

            int x = 1, y = 2;
            Console.WriteLine("Pre zamene, X = {0}", x);
            Console.WriteLine("Pre zamene, Y = {0}", y);
            Swap(ref x, ref y);
            Console.WriteLine("Nakon zamene, X = {0}", x);
            Console.WriteLine("Nakon zamene, Y = {0}", y);

            /*** Vezbanje sa casa ***/
            Console.WriteLine("******************************");
            int r1 = AddNumbers(2, 2);
            Console.WriteLine("Rezultat AddNumbers() je {0}", r1);
            /* 
             * double i float su oba decimalne vrednosti
             * double moze da cuva vece brojeve od float
             */
            double r2 = AddNumbersFloat(2.2, 2.8);
            Console.WriteLine("Rezultat AddNumbers() je {0}", r1);

            double rezultat5 = Vezba3(30, 30);
            Console.WriteLine("Rezultat metoda Vezba3 je {0}", rezultat5);

            string rS = AddStrings("String1", "String2");

            Console.WriteLine("Rezultat spajanja dva stringa je {0}", rS);

            Console.ReadKey();
        }

        static public int AddNumbers(int n1, int n2)
        {
            int result;
            result = n1 + n2;
            return result;
        }

        static public double AddNumbersFloat(double n1, double n2)
        {
            double result;
            result = n1 + n2;
            return result;
        }

        static public double Vezba3(double l1, double l2)
        {
            double rezultat5;
            if (l1 > l2)
            {
                rezultat5 = l1 / l2;
            }
            else
            {
                rezultat5 = l2 / l1;
            }
            return rezultat5;
        }

        static public string AddStrings(string s1, string s2)
        {
            return s1 + "-" + s2;
        }


        /**************************************************************/

        public int FindMax(int n1, int n2)
        {
            int result;
            if (n1 > n2)
            {
                result = n1;
            } else
            {
                result = n2;
            }
            return result;
        }

        static public int FindMaxStatic(int n1, int n2)
        {
            int result;
            if (n1 > n2)
            {
                result = n1;
            }
            else
            {
                result = n2;
            }
            return result;
        }

        static public int Factorial(int n)
        {
            int result;
            if (n == 1)
            {
                return 1;
            } else
            {
                result = Factorial(n - 1) * n;
                return result;
            }
        }

        static public void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

    }
}
