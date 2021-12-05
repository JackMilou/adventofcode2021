using System;
using System.Collections;

namespace day4
{
    public class Bingokaart
    {
        public Bingohok[] bingorij1;
        public Bingohok[] bingorij2;
        public Bingohok[] bingorij3;
        public Bingohok[] bingorij4;
        public Bingohok[] bingorij5;
        public bool isbingo;


        public Bingokaart(int[] nummersrij1,int[] nummersrij2,int[] nummersrij3,int[] nummersrij4,int[] nummersrij5 )
        {
            this.isbingo = false;
            this.bingorij1 = new Bingohok[5];
            for (int i = 0; i < 5; i++)
            {
                Bingohok bingohok = new Bingohok(nummersrij1[i]);
                this.bingorij1[i] = bingohok;
            }
            this.bingorij2 = new Bingohok[5];
            for (int i = 0; i < 5; i++)
            {
                Bingohok bingohok = new Bingohok(nummersrij2[i]);
                this.bingorij2[i] = bingohok;
            }
            this.bingorij3 = new Bingohok[5];
            for (int i = 0; i < 5; i++)
            {
                Bingohok bingohok = new Bingohok(nummersrij3[i]);
                this.bingorij3[i] = bingohok;
            }
            this.bingorij4 = new Bingohok[5];
            for (int i = 0; i < 5; i++)
            {
                Bingohok bingohok = new Bingohok(nummersrij4[i]);
                this.bingorij4[i] = bingohok;
            }
            this.bingorij5 = new Bingohok[5];
            for (int i = 0; i < 5; i++)
            {
                Bingohok bingohok = new Bingohok(nummersrij5[i]);
                this.bingorij5[i] = bingohok;
            }
        }

        public void trek(int treknummer)
        {
            for (int i = 0; i < 5; i++)
            {
                bingorij1[i].trek(treknummer);
                bingorij2[i].trek(treknummer);
                bingorij3[i].trek(treknummer);
                bingorij4[i].trek(treknummer);
                bingorij5[i].trek(treknummer);
            }
        }

        public int getscore()
        {
            int uitvoer = 0;
            for (int i = 0; i < 5; i++)
            {
                uitvoer += bingorij1[i].getscore();
                uitvoer += bingorij2[i].getscore();
                uitvoer += bingorij3[i].getscore();
                uitvoer += bingorij4[i].getscore();
                uitvoer += bingorij5[i].getscore();
            }

            return uitvoer;
        }

        public bool checkbingo()
        {
            bool check = false;
            bool allgetrokken = true;
            for (int i = 0; i < 5; i++)
            {
                if (bingorij1[i].getrokken == false)
                {
                    allgetrokken = false;
                }
            }

            if (allgetrokken)
            {
                isbingo = true;
                return true;
            }
            allgetrokken = true;
            for (int i = 0; i < 5; i++)
            {
                if (bingorij2[i].getrokken == false)
                {
                    allgetrokken = false;
                }
            }

            if (allgetrokken)
            {
                isbingo = true;
                return true;
            }
            allgetrokken = true;
            for (int i = 0; i < 5; i++)
            {
                if (bingorij3[i].getrokken == false)
                {
                    allgetrokken = false;
                }
            }

            if (allgetrokken)
            {
                isbingo = true;
                return true;
            }
            allgetrokken = true;
            for (int i = 0; i < 5; i++)
            {
                if (bingorij4[i].getrokken == false)
                {
                    allgetrokken = false;
                }
            }

            if (allgetrokken)
            {
                isbingo = true;
                return true;
            }
            allgetrokken = true;
            for (int i = 0; i < 5; i++)
            {
                if (bingorij5[i].getrokken == false)
                {
                    allgetrokken = false;
                }
            }

            if (allgetrokken)
            {
                isbingo = true;
                return true;
            }
            
            allgetrokken = false;
            for (int i = 0; i < 5; i++)
            {
                if (bingorij1[i].getrokken == true && bingorij2[i].getrokken && bingorij3[i].getrokken && bingorij4[i].getrokken && bingorij5[i].getrokken)
                {
                    allgetrokken = true;
                }
            }

            if (allgetrokken)
            {
                isbingo = true;
                return true;
            }
            else
            {
                return false;
            }
            
            
        }

        public void printBingokaart()
        {
            for (int i = 0; i < 5; i++)
            {
                bingorij1[i].printhok();
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                bingorij2[i].printhok();
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                bingorij3[i].printhok();
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                bingorij4[i].printhok();
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                bingorij5[i].printhok();
            }
            Console.WriteLine();

        }
    }
}