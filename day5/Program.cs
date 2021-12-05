using System;

namespace day5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] seafield = new int[1000, 1000];
            var regels = System.IO.File.ReadAllLines(@"C:\development\c#\HalloWereld\2021txt\day5.txt");
            foreach (var regel in regels)
            {
                Coordinates coordinates = GetCoordinates(regel);
                if (coordinates.x1 == coordinates.x2)
                {
                    if (coordinates.y1 > coordinates.y2)
                    {
                        for (int i = coordinates.y2; i <= coordinates.y1; i++)
                        {
                            seafield[coordinates.x1, i]++;
                        }
                    }
                    else
                    {
                        for (int i = coordinates.y1; i <= coordinates.y2; i++)
                        {
                            seafield[coordinates.x1, i]++;
                        }
                    }
                }
                else if (coordinates.y1 == coordinates.y2)
                {
                    if (coordinates.x1 > coordinates.x2)
                    {
                        for (int i = coordinates.x2; i <= coordinates.x1; i++)
                        {
                            seafield[i, coordinates.y1]++;
                        }
                    }
                    else
                    {
                        for (int i = coordinates.x1; i <= coordinates.x2; i++)
                        {
                            seafield[i, coordinates.y1]++;
                        }
                    }
                }
                else
                {
                    int xchanger = 1;
                    int ychanger = 1;
                    int xstart = coordinates.x1;
                    int ystart = coordinates.y1;
                    if (coordinates.x1 <= coordinates.x2)
                    {
                        xchanger = 1;
                    }
                    else
                    {
                        xchanger = -1;
                    }
                    if (coordinates.y1 <= coordinates.y2)
                    {
                        ychanger = 1;
                    }
                    else
                    {
                        ychanger = -1;
                    }

                    do
                    {
                        seafield[xstart, ystart]++;
                        xstart = xstart + xchanger;
                        ystart = ystart + ychanger;
                        if (xchanger == 1)
                        {
                            if (xstart > coordinates.x2)
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (xstart < coordinates.x2)
                            {
                                break;
                            }
                        }
                    } while (true);

                }
            }

            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (seafield[i, j] > 1)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(count);
        }

        public static Coordinates GetCoordinates(string regel)
        {
            var split = regel.Split(' ');
            var splitfirst = split[0].Split(',');
            int x1 = int.Parse(splitfirst[0]);
            int y1 = int.Parse(splitfirst[1]);

            var splitsecond = split[2].Split(',');
            int x2 = int.Parse(splitsecond[0]);
            int y2 = int.Parse(splitsecond[1]);

            Coordinates coordinates = new Coordinates(x1, y1, x2, y2);
            return coordinates;
        }
    }
}