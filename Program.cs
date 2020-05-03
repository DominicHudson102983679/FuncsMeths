using System;
using System.Linq;

namespace FuncsMeths
{
    class Program
    {
        // ---------------------------------------------------------- Task 1
        /*
        public static void Main()
        {
            Welcome();

        }

            public static void Welcome()
            {
                Console.WriteLine("Welcome Friends");
                Console.WriteLine("Have a nice day!");
            }

        */



        // ---------------------------------------------------------- Task 2
        /*

        public static void Main()
        {
            Console.Write("Please input a name: ");
            string name = Console.ReadLine();
            welcome(name);
            nice();
        }

        public static void welcome(string name)
        {
            Console.WriteLine("Welcome friend " + name + "!");
        }

        public static void nice()
        {
            Console.WriteLine("Have a nice day!");
        }

        */

        // ---------------------------------------------------------- Task 3

        /*
        public static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of these two numbers is: " + solution(num1, num2));
        }

        public static int solution(int num1, int num2)
        {
            int solution;
            solution = num1 + num2;
            return solution;
        }

        */


        // ---------------------------------------------------------- Task 4
        /*
        public static void Main()
        {
            Console.WriteLine("Input a string to find out how many spaces it has ");
            string testString = (Console.ReadLine());

            Console.WriteLine("\"" + testString + "\"" + " contains " + spaces(testString) + " spaces");
        }

        public static int spaces(string testString)
        {
            int spaces = 0;
            for (int i = 0; i < testString.Length; i++)
            {
                if (testString[i] == ' ')
                {
                    spaces++;
                }
            }
            return spaces;
        }
        */

        // ---------------------------------------------------------- Task 5
        /*
        public static void Main()
        {
            Console.WriteLine("Assign a number to each of the 5 elements in the array");
            Console.WriteLine("Element - 0:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Element - 1:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Element - 2:");
            int a3 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Element - 3:");
            int a4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Element - 4:");
            int a5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of the elements of the array is: " + (Sum(a1, a2, a3, a4, a5)));
        }

        public static int Sum(int a1, int a2, int a3, int a4, int a5)
        {
            int[] array = { a1, a2, a3, a4, a5 };
            int sum = array.Sum();
            return sum;
        }
        */

        // ---------------------------------------------------------- Task 6
        /*
        public static void Main()
        {
            Console.WriteLine("Enter a number for A: ");
            int aNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number for B: ");
            int bNum = Convert.ToInt32(Console.ReadLine());

            Swap(aNum, bNum);
        }

        public static void Swap(int aNum, int bNum)
        {
            int spareNum;

            spareNum = aNum;
            aNum = bNum;
            bNum = spareNum;

            Console.WriteLine("Now the number for A is " + aNum + " and the number for B is " + bNum);
        }
        */

        //------------------------------------------------------------- Task 7


        /*
        public static void Main()
        {
            Console.WriteLine("Input Base number: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Exoponent: ");
            int expNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("So, the number " + baseNum + "^ (to the power of) " + expNum + " = " + Power(baseNum, expNum));
        }

        public static int Power(int baseNum, int expNum)
        {
            int result = 1;
            int i = 1;

            for (i = 1; i <= expNum; i++)
                result = result * baseNum;
            return result;
        }

        */

        //------------------------------------------------------------- Task 8

        //------------------------------------------------------------- Task 9

        /*
        public static void Main()
        {
            Console.WriteLine("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Prime(num);
        }

        public static void Prime(int num)
        {
            int i;
            for (i = 2; i <= num; ++i) ;

        }
        */
    }
}
