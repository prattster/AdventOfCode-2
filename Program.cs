using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReadLines().Zip(ReadLines().Skip(1), (first, second) => second > first).Count(hasDepthIncreased => hasDepthIncreased));
            Console.ReadKey();
        }

        static IEnumerable<int> ReadLines()
        {
            return File.ReadLines(@"input.txt").Select(int.Parse);
        }
    }
}
