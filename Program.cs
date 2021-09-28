using System;

namespace _0to100EvenLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //2
            bool runProgram = true;
            while (runProgram == true)
            {
                Console.WriteLine("Do you want to continue lopping? (y/n)");
                string loopAnswer = Console.ReadLine();
                if (loopAnswer == "n")
                {
                    runProgram = false;
                }
            }
            //3
            int sum = 0;

            for(int i = 0; i <= 5; i++)
            {
                sum = sum + i;
                
                Console.WriteLine(sum);
            }
        }
    }
}
