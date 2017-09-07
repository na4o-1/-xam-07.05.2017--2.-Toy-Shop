using System;


namespace _6NumberGenerator
{
    class Program
    {
        static void Main()
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());

            int specialNum = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            for (int i = M; i >= 1; i--)
            {
                for (int j = N; j >=1; j--)
                {
                    for (int k = L; k >=1 ; k--)
                    {
                        int MNL = (100 * i + 10 * j + k);
                        if (MNL%3==0)
                        {
                            specialNum += 5;
                        }
                        else if (MNL%10==5)
                        {
                            specialNum -= 2;
                        }
                        else if (MNL %2==0)
                        {
                            specialNum *= 2;
                        }
                        if (specialNum >= controlNum)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNum);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("No! {0} is the last reached special number.", specialNum);
        }
    }
}
