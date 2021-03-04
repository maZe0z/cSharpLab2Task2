using System;
using System.Linq;

namespace task2
{
    public class ZRand
    {
        public string Letters { get; set; }

        public string ShuffledLetters { get; set; }
        
        public void Shuffle()
        {
            Random rand = new Random();

            ShuffledLetters = string.Join("", Letters.OrderBy(x => rand.Next()));
        }
    }
}