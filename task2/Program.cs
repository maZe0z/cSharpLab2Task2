using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ZRand zRand = new ZRand();
            
            Console.WriteLine("Print a string to shuffle:");

            zRand.Letters = Console.ReadLine();
            
            zRand.Shuffle();
            
            Console.WriteLine("Shuffled string: " + zRand.ShuffledLetters);
        }
    }
}