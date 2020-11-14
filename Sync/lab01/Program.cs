using System;
using System.Threading;

namespace lab01
{
    class Program
    {
        private static int x = 0;

        static void funcA()
        {
            int xx = 0;
            while (xx < 5000)
            {
                Console.WriteLine("FuncA : Round : {0} x = {1}", xx, x);
                x++;
                xx++;
            }
        }

        static void funcB()
        {
            int xx = 0;
            while (xx < 5000)
            {
                Console.WriteLine("FuncB : Round : {0} x = {1}", xx, x);
                x++;
                xx++;
            }
        }
        static void Main(string[] args)
        {
            Thread A = new Thread(new ThreadStart(funcA));
            Thread B = new Thread(new ThreadStart(funcB));
            A.Start();
            B.Start();
        }
    }
}
