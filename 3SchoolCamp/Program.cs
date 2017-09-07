using System;


namespace _3SchoolCamp
{
    class Program
    {
        static void Main()
        {
            string season = Console.ReadLine().ToLower();
            string grups = Console.ReadLine().ToLower();
            int studentsCnt = int.Parse(Console.ReadLine());
            int nightsCnt = int.Parse(Console.ReadLine());
            
            double pricestudents = 0.0;            
            string sports = "";

            if (season == "winter")
            {
                if (grups == "boys")
                {
                    pricestudents = studentsCnt * 9.6 * nightsCnt;
                    sports = "Judo";
                }
                else if (grups == "girls")
                {
                    pricestudents = studentsCnt * 9.6 * nightsCnt;
                    sports = "Gymnastics";
                }
                else if (grups == "mixed")
                {
                    pricestudents = studentsCnt * 10 * nightsCnt;
                    sports = "Ski";
                }
            }
            else if (season == "spring")
            {
                if (grups == "boys")
                {
                    pricestudents = studentsCnt * 7.2 * nightsCnt;
                    sports = "Tennis";
                }
                else if (grups == "girls")
                {
                    pricestudents = studentsCnt * 7.2 * nightsCnt;
                    sports = "Athletics";
                }
                else if (grups == "mixed")
                {
                    pricestudents = studentsCnt * 9.5 * nightsCnt;
                    sports = "Cycling";
                }
            }
            else if (season == "summer")
            {
                if (grups == "boys")
                {
                    pricestudents = studentsCnt * 15 * nightsCnt;
                    sports = "Football";
                }
                else if (grups == "girls")
                {
                    pricestudents = studentsCnt * 15 * nightsCnt;
                    sports = "Volleyball";
                }
                else if (grups == "mixed")
                {
                    pricestudents = studentsCnt * 20 * nightsCnt;
                    sports = "Swimming";
                }
            
            }
            if (studentsCnt>=50)
            {
                pricestudents = pricestudents - (pricestudents * 50 / 100);
            }
            else if (studentsCnt >= 20&&studentsCnt <50)
            {
                pricestudents= pricestudents- (pricestudents * 15 / 100);
            }
            else if (studentsCnt >= 10 && studentsCnt < 20)
            {
                pricestudents = pricestudents - (pricestudents * 5 / 100);
            }
            Console.WriteLine("{0} {1:f2} lv.", sports, pricestudents);
        }
    }
}
