using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Linq;

//http://localhost/adventofcode/2021/day1.1.php

namespace adventofcode2021
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var numbers = System.IO.File.ReadAllLines(@"C:\development\c#\HalloWereld\2021txt\day12021.txt").Select(number => int.Parse(number)).ToArray();

            // int count = 0;
            //
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     int j = i + 1;
            //     if (numbers[i] < numbers[j])
            //     {
            //         count++;
            //     }
            // }
            
            //Console.WriteLine(count);
            
            int count = 0;
            
            int beginnummer = numbers[0];
            int i = 1;
            int j = 0;
            foreach (int number in numbers)
            {
                if (i < numbers.Length)
                {
                    if (numbers[i] > numbers[j])
                    {
                        count++;
                    }
                    i++;
                    j++;
                }
            }
            Console.WriteLine(count);

            int countmeas = 0;
            int k = 0;
            foreach (var number in numbers)
            {
                if (k + 3 < numbers.Length)
                {
                    int measurement1 = numbers[k] + numbers[k + 1] + numbers[k + 2];
                    int measurement2 = numbers[k + 1] + numbers[k + 2] + numbers[k + 3];

                    if (measurement2 > measurement1)
                    {
                        countmeas++;
                    }
                }

                k++;
            }
            Console.WriteLine(countmeas);




        }
        }
    }