using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Random random = new Random();

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int value = random.Next(1, 7);
                Console.WriteLine($"Para n = {i} -> {value}");
                sum += value;
            }
            
            Console.WriteLine($"\nA soma será {sum}.");
        }
    }
}
