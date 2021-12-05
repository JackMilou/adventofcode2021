using System;
using System.Collections.Generic;
using System.Linq;

namespace day3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // var numbers = System.IO.File.ReadAllLines(@"C:\development\c#\HalloWereld\2021txt\day3.txt");
            //
            //
            // int[,] counts = new int[12, 2];
            // for (int i = 0; i < 12; i++)
            // {
            //     for (int j = 0; j < 2; j++)
            //     {
            //         counts[i, j] = 0;
            //     }
            // }
            //
            // foreach (var number in numbers)
            // {
            //     char[] characters = number.ToCharArray();
            //
            //     for (int i = 0; i < characters.Length; i++)
            //     {
            //         if (characters[i] == '0')
            //         {
            //             counts[i, 0]++;
            //         }
            //         else
            //         {
            //             counts[i, 1]++;
            //         }
            //         
            //         
            //     }
            // }
            //
            // char[] gamma = new char[12];
            // char[] epsilon = new char[12];
            // for (int i = 0; i < 12; i++)
            // {
            //     if (counts[i,0] > counts[i,1])
            //     {
            //         gamma[i] = '0';
            //         epsilon[i] = '1';
            //     }
            //     else
            //     {
            //         gamma[i] = '1';
            //         epsilon[i] = '0';
            //     }
            // }
            //
            // string gammastring = new string(gamma);
            // string epsilonstring = new string(epsilon);
            //
            // Console.WriteLine(gammastring);
            // Console.WriteLine(epsilonstring);
            //
            // int gammaint = Convert.ToInt32(gammastring, 2);
            // int epsilonint = Convert.ToInt32(epsilonstring, 2);
            //
            // Console.WriteLine(gammaint);
            // Console.WriteLine(epsilonint);
            // Console.WriteLine(gammaint*epsilonint);
            
            var numbers = System.IO.File.ReadAllLines(@"C:\development\c#\HalloWereld\2021txt\day3.txt");

            char[,] chararray = new char[numbers.Length, 12];
            for (int i = 0; i < numbers.Length; i++)
            {
                char[] characters = numbers[i].ToCharArray();

                for (int j = 0; j < characters.Length; j++)
                {
                    chararray[i,j] = characters[j];
                }
            }
            
            for (int i = 0; i < 12; i++)
            {
                var o2 = mostpresent(i,chararray);
                Console.WriteLine(o2);
                chararray = filter(i,o2,chararray);
                Console.WriteLine("chararray.GetLength(0)");
                Console.WriteLine(chararray.GetLength(0));
                Console.WriteLine("chararray.GetLength(0)end");
                if (chararray.GetLength(0) <= 1)
                {
                    break;
                }


            }
            char[] output= new char[12];
            for (int j = 0; j < 12; j++)
            {
                output[j] = chararray[0, j];
            }
            string oxystring = new string(output);
            Console.WriteLine(oxystring);
            
            chararray = new char[numbers.Length, 12];
            for (int i = 0; i < numbers.Length; i++)
            {
                char[] characters = numbers[i].ToCharArray();

                for (int j = 0; j < characters.Length; j++)
                {
                    chararray[i,j] = characters[j];
                }
            }
            
            for (int i = 0; i < 12; i++)
            {
                var o2 = leastpresent(i,chararray);
                Console.WriteLine(o2);
                chararray = filter(i,o2,chararray);
                Console.WriteLine("chararray.GetLength(0)");
                Console.WriteLine(chararray.GetLength(0));
                Console.WriteLine("chararray.GetLength(0)end");
                if (chararray.GetLength(0) <= 1)
                {
                    break;
                }


            }
            output= new char[12];
            for (int j = 0; j < 12; j++)
            {
                output[j] = chararray[0, j];
            }
            string co2string = new string(output);
            Console.WriteLine(co2string);
            int oxyint = Convert.ToInt32(oxystring, 2);
            int co2int = Convert.ToInt32(co2string, 2);
            //
            Console.WriteLine(oxyint);
            Console.WriteLine(co2int);
            Console.WriteLine(oxyint*co2int);


        }

        static char mostpresent(int pos, char[,] numberlist)
        {
            int count0 = 0;
            int count1 = 0;

            for (int i = 0; i < numberlist.GetLength(0); i++)
            {
                Console.WriteLine("before most check");
                Console.WriteLine(numberlist[i,pos]);
                if (numberlist[i,pos] == '0')
                    {
                        count0++;
                    }
                    else
                    {
                        count1++;
                    }
            }
            Console.WriteLine("count0 before");
            Console.WriteLine(count0);
            Console.WriteLine("count1 before");
            Console.WriteLine(count1);

            if (count0 > count1)
            {
                Console.WriteLine("return 0");
                return '0';
            }
            else
            {
                
                return '1';
            }
        }
        static char leastpresent(int pos, char[,] numberlist)
        {
            int count0 = 0;
            int count1 = 0;

            for (int i = 0; i < numberlist.GetLength(0); i++)
            {
                Console.WriteLine("before most check");
                Console.WriteLine(numberlist[i,pos]);
                if (numberlist[i,pos] == '0')
                {
                    count0++;
                }
                else
                {
                    count1++;
                }
            }
            Console.WriteLine("count0 before");
            Console.WriteLine(count0);
            Console.WriteLine("count1 before");
            Console.WriteLine(count1);

            if (count0 > count1)
            {
                Console.WriteLine("return 0");
                return '1';
            }
            else
            {
                
                return '0';
            }
        }

        static char[,] filter(int pos, char tofilter, char[,] numberlist)
        {
            char[,] filtered = new char[0,12] ;
            for (int i = 0; i < numberlist.GetLength(0); i++)
            {
                Console.WriteLine("pos");
                Console.WriteLine(pos);
                Console.WriteLine("i");
                Console.WriteLine(i);

                if (numberlist[i,pos]== tofilter)
                {
                    char[] output= new char[12];
                    for (int j = 0; j < 12; j++)
                    {
                        output[j] = numberlist[i, j];
                    }
                    filtered = AddRow(filtered, output);
                }
            }

            return filtered;
        }
        static char[,] AddRow(char[,] original, char[] added)
        {
            int lastRow = original.GetUpperBound(0);
            int lastColumn = original.GetUpperBound(1);
            // Create new array.
            char[,] result = new char[lastRow + 2, lastColumn + 1];
            // Copy existing array into the new array.
            for (int i = 0; i <= lastRow; i++)
            {
                for (int x = 0; x <= lastColumn; x++)
                {
                    result[i, x] = original[i, x];
                }
            }
            // Add the new row.
            for (int i = 0; i < added.Length; i++)
            {
                result[lastRow + 1, i] = added[i];
            }
            return result;
        }
    }
}