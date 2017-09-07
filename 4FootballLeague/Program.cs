using System;


namespace _4FootballLeague
{
    class Program
    {
        static void Main()
        {
            int capacitet = int.Parse(Console.ReadLine());
            int fens = int.Parse(Console.ReadLine());

            int sectorAcnt = 0;
            int sectorBcnt = 0;
            int sectorVcnt = 0;
            int sectorGcnt = 0;

            for (int i = 1; i <= fens; i++)
            {
                string sector = Console.ReadLine().ToLower();
                if (sector == "a")
                {
                    sectorAcnt++;
                }
                else if (sector == "b")
                {
                    sectorBcnt++;
                }
                else if (sector == "v")
                {
                    sectorVcnt++;
                }
                else if (sector == "g")
                {
                    sectorGcnt++;
                }
            }
            double secApercent =(double) sectorAcnt / fens * 100;
            double secBpercent = (double)sectorBcnt / fens * 100;
            double secVpercent = (double)sectorVcnt / fens * 100;
            double secGpercent = (double)sectorGcnt / fens * 100;

            double percentfens =((double )fens / capacitet) * 100;

            Console.WriteLine("{0:f2}%", secApercent);
            Console.WriteLine("{0:f2}%", secBpercent);
            Console.WriteLine("{0:f2}%", secVpercent);
            Console.WriteLine("{0:f2}%", secGpercent);
            Console.WriteLine("{0:f2}%", percentfens);
        }
    }
}

