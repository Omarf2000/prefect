using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            int FirstNum, SecondNum;


            Console.Write("Find perfect numbers betwee " + " FirstNum " + " and " + " SecondNum" + "\n");

            Console.Write("\n\n");

            Console.Write("please enter FirstNum : ");
            FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter SecondNum : ");
            SecondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Perfect numbers IS : ");
            for (n = FirstNum; n <= SecondNum; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.ReadKey();
        }

    }
}

