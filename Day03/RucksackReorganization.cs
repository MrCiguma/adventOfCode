using System;
using System.IO;

namespace Day02
{
    class RucksackReorganization
    {
        static void Main(string[] args) {
            part1();
            part2();
        }

        private static void part1()
        {            
            string[] lines = File.ReadAllLines("input1.txt");

            long score = 0;

            foreach (string line in lines) 
            {
                HashSet<int> first = new HashSet<int>();
                HashSet<int> second = new HashSet<int>();

                for (int i = 0; i < line.Length; i++) 
                {
                    if (i < line.Length/2) 
                    {
                        first.Add(line[i]);
                    } 
                    else 
                    {
                        second.Add(line[i]);
                    }
                }
                first.IntersectWith(second);
                
                long priority = first.First() - 'a' + 1;
                if (priority < 0) 
                {
                    priority = first.First() - 'A' + 27;
                }

                score += priority;
            }
            
            Console.WriteLine(score);
        }

        private static void part2()
        {
            string[] lines = File.ReadAllLines("input1.txt");

            long score = 0;

            for (int i = 0; i < lines.Length; i += 3)
            {
                List<HashSet<int>> rucksacks = new List<HashSet<int>>();

                for (int j = 0; j < 3; j++) 
                {
                    string line = lines[i+j];
                    rucksacks.Add(new HashSet<int>());
                    for (int k = 0; k < line.Length; k++) {
                        rucksacks[j].Add(line[k]);
                    }
                }
                rucksacks[1].IntersectWith(rucksacks[2]);
                rucksacks[0].IntersectWith(rucksacks[1]);

                
                long priority = rucksacks[0].First() - 'a' + 1;
                if (priority < 0) 
                {
                    priority = rucksacks[0].First() - 'A' + 27;
                }
                // Console.WriteLine(priority);

                score += priority;
            }

            Console.WriteLine(score);
        }
    }
}
