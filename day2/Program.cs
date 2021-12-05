using System;
using System.Linq;

namespace day2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = System.IO.File.ReadAllLines(@"C:\development\c#\HalloWereld\2021txt\day22021.txt").Select(o => o.Split(' '));

            // string direction;
            // int i;
            // int x = 0;
            // int y = 0;
            // foreach (var instruction in numbers)
            // {
            //     direction = instruction[0];
            //     i = int.Parse(instruction[1]);
            //     switch (direction)
            //     {
            //         case "down":
            //             y -= i;
            //             break;
            //         case "up":
            //             y += i;
            //             break;
            //         case "forward":
            //             x += i;
            //             break;
            //     }
            //     
            // }
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            //
            // Console.WriteLine(x*y);
            
            string direction;
            int aim = 0;
            int i;
            int x = 0;
            int y = 0;
            foreach (var instruction in numbers)
            {
                direction = instruction[0];
                i = int.Parse(instruction[1]);
                switch (direction)
                {
                    case "down":
                        aim += i;
                        break;
                    case "up":
                        aim -= i;
                        break;
                    case "forward":
                        x += i;
                        y -= i * aim;
                        break;
                }
                
            }
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine(x*y);
        }
    }
}