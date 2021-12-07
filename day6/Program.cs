using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace day6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> fishlist = new List<int>();
            var numdays = 1;
            int maxdays = 20;
            foreach (string fishL in File.ReadLines(@"C:\development\c#\HalloWereld\2021txt\day6.txt") )
            {
                foreach (string fish in fishL.Split(','))
                {
                    fishlist.Add(Convert.ToInt32(fish));
                }
            }
            
            while (numdays <= maxdays)
            {
                for (int i = fishlist.Count - 1; i >= 0; i--)
                {
                    if (fishlist[i] == 0)
                    {
                        fishlist[i] = 6;
                        fishlist.Add(8);
                    }
                    else
                    {
                        
                        fishlist[i]--;
                    }
                }
            
                
                numdays++;
            }
            
            Console.WriteLine(fishlist.Count);

            

            
            var numdays2 = 1;
            int maxdays2 = 256;
            long[] fisharray = new long[] {0,0,0,0,0,0,0,0,0};
            
            // long[] fisharray = new long[9];
            // foreach (string fishL in File.ReadLines(@"C:\development\c#\HalloWereld\2021txt\day6.txt"))
            // {
            //     foreach (string fish in fishL.Split(','))
            //     {
            //         long day = long.Parse(fish);
            //         fisharray[day]++;
            //     }
            // }
            
            var fishL2 = File.ReadAllLines(@"C:\development\c#\HalloWereld\2021txt\day6.txt");
            var values = fishL2[0].Split(',').Select(x => Convert.ToInt32(x)).ToList();
            foreach (var v in values) 
            {
                //Console.WriteLine(v);
                fisharray[v]++;
            }

            // long[] newday = new long[8];
            // while (numdays2 < maxdays2)
            // {
            //     numdays2++;
            //     newday[0] = fisharray[1];
            //     newday[1] = fisharray[2];
            //     newday[2] = fisharray[3];
            //     newday[3] = fisharray[4];
            //     newday[4] = fisharray[5];
            //     newday[5] = fisharray[6]+ fisharray[0];
            //     newday[6] = fisharray[7];
            //     newday[7] = fisharray[0];   
            //     fisharray = newday;
            //
            // }
            
            for (var day = 0; day < maxdays2; day++)
            {
                var tmp = fisharray[0];
                for (var i = 1; i < 9; i++)
                {
                    fisharray[i - 1] = fisharray[i];
                }
            
                fisharray[6] += tmp;
                fisharray[8] = tmp;
            }

            // long count = fisharray[1] + fisharray[2] + fisharray[3] + fisharray[4] + fisharray[5] + fisharray[6] +
            //             fisharray[7] + fisharray[0];
            Console.WriteLine($"Part 2: {fisharray.Sum()}");
            // Console.WriteLine(count);
        }
    }
}