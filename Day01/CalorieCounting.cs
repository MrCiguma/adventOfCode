using System;
using System.IO;

namespace Day01
{
    class CalorieCounting
    {
        static void Main(string[] args) {
            part1();
            part2();
        }

        private static void part1()
        {            
            string[] lines = File.ReadAllLines("input1.txt");

            long max = -1;
            long currentElf = 0;
            foreach (string line in lines)
            {
                if (line.Length == 0) 
                {
                    currentElf = 0;
                }
                else
                {
                    currentElf += long.Parse(line);
                    if (currentElf > max) {
                        max = currentElf;
                    }
                }
            }

            Console.WriteLine(max);
        }

        private static void part2()
        {
            string[] lines = File.ReadAllLines("input1.txt");

            long max = -1;
            long currentElf = 0;
            List<long> elfCals = new List<long>();
            foreach (string line in lines)
            {
                if (line.Length == 0) 
                {
                    elfCals.Add(currentElf);
                    currentElf = 0;
                }
                else
                {
                    currentElf += long.Parse(line);
                    if (currentElf > max) {
                        max = currentElf;
                    }
                }
            }
            elfCals.Add(currentElf);

            elfCals.Sort((a, b) => b.CompareTo(a));
            long total = 0;
            for (int i = 0; i < 3 && i < elfCals.Count; i++) 
            {
                total += elfCals[i];
            }

            elfCals.ForEach(Console.WriteLine);

            Console.WriteLine(total);
        }
    }
}
