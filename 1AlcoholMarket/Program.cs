using System;

namespace _1AlcoholMarket
{
    class Program
    {
        static void Main()
        {
            double priceWiski = double.Parse(Console.ReadLine());
            double beerLi = Double.Parse(Console.ReadLine());
            double wineLi = Double.Parse(Console.ReadLine());
            double rakiaLi = Double.Parse(Console.ReadLine());
            double wiskiLi = Double.Parse(Console.ReadLine());
            


            double priceRakia = (priceWiski / 2);
            double PriceWine = (priceRakia 
                - (40 * priceRakia / 100));
            Double PriceBeer = (priceRakia 
                - (80 * priceRakia / 100));

            double totalWiski = priceWiski * wiskiLi;
            double totalRakia = priceRakia * rakiaLi;
            double totalWine = PriceWine * wineLi;
            double totalBeer = PriceBeer * beerLi;

            double needMoeny = totalWiski + totalRakia
                + totalWine + totalBeer;            

            Console.WriteLine("{0:f2}", needMoeny);
        }
    }
}
