using System;

namespace _5Crown
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine('@'+new string(' ',(2*n-1-3)/2)+"@"+ new string(' ', (2 * n - 1 - 3) / 2)+"@");

            Console.WriteLine("**"+new string (' ',n-3)+'*'+ new string(' ', n - 3)+"**");

            for (int i = 0; i < n/2-2; i++)
            {
                Console.WriteLine('*'+new string ('.',1+i)+'*'+new string (' ',n-5-(2*i))+'*'+ new string('.', 1 + 2*i)+'*'+ new string(' ', n - 5-(2*i))+'*'+ new string('.', 1 + i)+'*');
            }
            Console.WriteLine('*'+new string('.',n/2-1)+'*'+new string ('.',n-3)+'*'+ new string('.', n / 2-1)+'*');
            Console.WriteLine('*'+new string ('.',n/2)+new string ('*',n/2-2)+'.'+ new string('*', n / 2 - 2)+ new string('.', n / 2)+'*');
            Console.WriteLine(new string ('*',n*2-1));
            Console.WriteLine(new string('*', n * 2 - 1));
        }
    }
}
