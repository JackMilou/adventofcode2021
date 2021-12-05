using System;
using System.Collections.Generic;
using System.Linq;

namespace day4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Bingokaart> bingokaarten = new List<Bingokaart>();

            int[] rij1 = new int[5] ;
            int[] rij2 = new int[5] ;
            int[] rij3 = new int[5] ;
            int[] rij4 = new int[5] ;
            int[] rij5 = new int[5] ;
            // bingokaarten.Add(new Bingokaart(rij1, rij2, rij3, rij4, rij5));
            //
            // foreach (var bingokaart in bingokaarten)
            // {
            //     bingokaart.printBingokaart();
            // }

            var regels = System.IO.File.ReadAllLines(@"C:\development\c#\HalloWereld\2021txt\day4bingo.txt");
            var treknummers = System.IO.File.ReadAllLines(@"C:\development\c#\HalloWereld\2021txt\day4nummers.txt");
            

            int rijnummer = 0;
            foreach (var regel in regels)
            {
                rijnummer++;
                switch (rijnummer)
                {
                    case 1:
                    {
                        rij1 = splitRow(regel);
                     break;   
                    }
                    case 2:
                    {
                        rij2 = splitRow(regel);
                        break;   
                    }
                    case 3:
                    {
                        rij3 = splitRow(regel);
                        break;   
                    }
                    case 4:
                    {
                        rij4 = splitRow(regel);
                        break;   
                    }
                    case 5:
                    {
                         rij5 = splitRow(regel);
                        break;   
                    }
                    case 6:
                    {
                        rijnummer = 0;
                        bingokaarten.Add(new Bingokaart(rij1, rij2, rij3, rij4, rij5));
                        break;   
                    }
                }
            }
            // foreach (var bingokaart in bingokaarten)
            // {
            //     bingokaart.printBingokaart();
            //     Console.WriteLine();
            // }

            int[] trekken = parsetreknummers(treknummers[0]);

            for (int i = 0; i < trekken.Length; i++)
            {
                foreach (var bingokaart in bingokaarten)
                {
                    bingokaart.trek(trekken[i]);
                    if (bingokaart.checkbingo())
                    {
                        bool iskaartzonderbingo = false;

                        foreach (var bing in bingokaarten)
                        {
                            if (bing.isbingo == false)
                            {
                                iskaartzonderbingo = true;
                            }
                        }

                        if (iskaartzonderbingo == false)
                        {
                            bingokaart.printBingokaart();
                            int score = bingokaart.getscore();
                            int antwoord = score * trekken[i];
                            Console.WriteLine(antwoord);
                            i = 200;
                            break;
                        }
                    }
                    
                }
            }

        }

        static int[] splitRow(string row)  
        {
            int[] nummers = new int[5];

            var test = row.Split(' ');
            int j = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] != ""){
                    nummers[j] = int.Parse(test[i]);
                    j++;
                }
            }
            return nummers;
        }

        static int[] parsetreknummers(string row)
        {
            int[] nummers = new int[100];

            var test = row.Split(',');
            int j = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] != ""){
                    nummers[j] = int.Parse(test[i]);
                    j++;
                }
            }
            return nummers;
        }
    }
}