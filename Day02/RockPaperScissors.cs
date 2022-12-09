using System;
using System.IO;

namespace Day02
{
    class RockPaperScissors
    {
        static void Main(string[] args) {
            part1();
            part2();
        }

        private static void part1()
        {            
            string[] lines = File.ReadAllLines("input1.txt");

            long score = 0;

            foreach (string line in lines) {
                int opponent = line.Split()[0][0] - 'A';
                int me = line.Split()[1][0] - 'X';
                score += me + 1;
                
                int outcome = (me - opponent + 3) % 3;
                if (outcome == 2) outcome = -1;
                score += outcome * 3 + 3;
            }
            
            Console.WriteLine(score);
        }

        private static void part2()
        {
            string[] lines = File.ReadAllLines("input1.txt");

            long score = 0;

            foreach (string line in lines) {
                int opponent = line.Split()[0][0] - 'A';
                int outcome = line.Split()[1][0] - 'Y';
                int me = (outcome + opponent + 3) % 3;

                score += me + 1;
                score += outcome * 3 + 3;
            }

            Console.WriteLine(score);

        }
    }
}
