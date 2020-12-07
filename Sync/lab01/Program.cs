using System;
using System.Threading;

namespace lab01
{
    class Program
    {
        private static int x = 0;
        static object _lock = new object();
        static void funcA()
        {
            Console.WriteLine("FuncA");
            int xx = 0;
            lock (_lock)
            {
                while (xx < 500)
                {
                    Console.WriteLine("FuncA : Round : {0} x = {1}", xx, x);
                    x++;
                    xx++;
                }

            }
            Console.WriteLine("FuncAL");


        }


        static void funcB()
        {
            Console.WriteLine("FuncB");
            int xx = 0;
            lock (_lock)
            {
                while (xx < 500)
                {

                    Console.WriteLine("FuncB : Round : {0} x = {1}", xx, x);
                    x++;
                    xx++;
                }
            }
            Console.WriteLine("FuncBL");


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
