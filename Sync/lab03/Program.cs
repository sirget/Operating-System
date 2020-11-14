using System;
using System.Threading;

namespace lab03
{
    class Program
    {
        private static string x = "";
        private static int exflag = 0;
        private static int check = 0;

        private static object _lock = new object();

        static void ThReadX(object i)
        {
            while (exflag == 0)
            {
                lock (_lock)
                {
                    while (check == 0)
                        Monitor.Wait(_lock);
                    if (x != "exit")
                    {
                        Console.WriteLine("Thread {0} : {1} ", i, x);
                        check = 0;
                    }
                }

            }
            Console.WriteLine("Thread {0} exit", i);
        }

        static void ThWriteX()
        {
            string xx;
            while (exflag == 0)
            {
                lock (_lock)
                {
                    Console.Write("Input : ");
                    xx = Console.ReadLine();
                    if (xx == "exit")
                        exflag = 1;
                    check = 1;
                    Monitor.Pulse(_lock);

                }
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Thread A = new Thread(ThReadX);
            Thread B = new Thread(ThWriteX);
            Thread C = new Thread(ThReadX);
            Thread D = new Thread(ThReadX);

            A.Start(1);
            B.Start();
            C.Start(2);
            D.Start(3);
        }
    }
}
