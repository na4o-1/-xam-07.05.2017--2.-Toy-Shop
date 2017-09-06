using System;


namespace _2ToyShop
{
    class Program
    {
        static void Main()
        {
            double priceHoliday = double.Parse(Console.ReadLine());
            double puzzleCnt = double.Parse(Console.ReadLine());
            double dollsCnt = double.Parse(Console.ReadLine());
            double bearsCnt = double.Parse(Console.ReadLine());
            double minionsCnt = double.Parse(Console.ReadLine());
            double trucksCnt = double.Parse(Console.ReadLine());

            double toysCnt = puzzleCnt + dollsCnt + bearsCnt
                + minionsCnt + trucksCnt;

            double pricePuzeles = puzzleCnt * 2.6;
            double priceDolls = dollsCnt * 3.0;
            double priceBeers = bearsCnt * 4.1;
            double priceMinions = minionsCnt * 8.2;
            double pricetrucks = trucksCnt * 2;

            double Moeny = pricePuzeles + priceDolls
                + priceBeers + priceMinions + pricetrucks;

            if (toysCnt >= 50)
            {
                Moeny = Moeny - (25 * Moeny / 100);
            }
            double rent = 10 * Moeny / 100;
            double totalMoeny = Moeny - rent;

            double needmoney = Math.Abs(totalMoeny - priceHoliday);

            if (totalMoeny >= priceHoliday)
            {
                Console.WriteLine($"Yes! {needmoney:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {needmoney:f2} lv needed.");
            }
        }
    }
}
