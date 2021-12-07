using System;
using System.Collections.Generic;
using System.IO;

namespace day7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // List<int> crabyList= new List<int>();
            // int m = 0;
            // int s = 0;
            //
            // foreach (string line in File.ReadLines(@"C:\development\c#\HalloWereld\2021txt\day7.txt"))
            // {
            //     foreach (string crab in line.Split(','))
            //     {
            //         crabyList.Add(Convert.ToInt32(crab));
            //     }
            // }
            // crabyList.Sort();
            // if ((crabyList.Count - 1) % 2 == 0)
            // {
            //     int a = crabyList[(crabyList.Count - 1) / 2 - 1];
            //     int b = crabyList[(crabyList.Count - 1) / 2];
            //     m = (a + b) / 2;
            // }
            // else
            // {
            //     m = crabyList[crabyList.Count / 2];
            // }
            // foreach (int crab in crabyList)
            // {
            //     s += Math.Abs(crab - m);
            // }
            //
            // Console.WriteLine(s);

            
            List<int> crabyList= new List<int>();
            int m = 0;
            int t = 0;
            int s = 0;
            
            foreach (string line in File.ReadLines(@"C:\development\c#\HalloWereld\2021txt\day7.txt"))
            {
                foreach (string crab in line.Split(','))
                {
                    crabyList.Add(Convert.ToInt32(crab));
                    t += Convert.ToInt32(crab);
                }
            }

            m = (int) Math.Ceiling((double) (t / (crabyList.Count)));
            
            foreach (int crab in crabyList)
            {
                int pos = Math.Abs(crab - m);
                s += (pos * (pos + 1)) / 2;
            }
            
            Console.WriteLine(s);
        }
        
        
        
    }
}