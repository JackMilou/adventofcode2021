using System;

namespace day4
{
    public class Bingohok
    {
        public bool getrokken;
        public int number;


        public Bingohok(int number)
        {
            this.getrokken = false;
            this.number = number;
        }

        public void printhok()
        {
            Console.Write(this.number);
            Console.Write(", ");
            Console.Write(this.getrokken);
            Console.Write("  ");
            
        }

        public void trek(int treknummer)
        {
            if (this.number == treknummer)
            {
                this.getrokken = true;
            }
        }

        public int getscore()
        {
            if (getrokken == true)
            {
                return 0;
            }
            else
            {
                return number;
            }
        }
    }
}