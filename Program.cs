using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace AdventOfCode_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                ReadLines()
                    .Zip(ReadLines().Skip(1),
                        (first, second) => new {first, second})
                    .Zip(ReadLines().Skip(2),
                        (firstAndSecond, third) => new
                            {firstAndSecond.first, firstAndSecond.second, third})
                    .Zip(ReadLines().Skip(3),
                        (firstSecondAndThird, fourth) => new
                            {firstSecondAndThird.first, firstSecondAndThird.second, firstSecondAndThird.third, fourth})
                    .Count(window => window.second + window.third + window.fourth > window.first + window.second + window.third));

            Console.ReadKey();
        }

        static IEnumerable<int> ReadLines()
        {
            return File.ReadLines(@"input.txt").Select(int.Parse);
        }
    }
}
