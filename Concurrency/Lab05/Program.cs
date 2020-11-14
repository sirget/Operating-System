using System;
using System.Threading;

namespace Lab_OS_05
{
    class Program
    {
        static int resource = 10000;
        static void Test1()
        {
            Thread th2 = new Thread(Test2);
            th2.Start();
            int i;
            for (i = 0; i < 500; i++)
            {
                resource++;
                Console.Write(".");

            }
        }
        static void Test2()
        {
            int i;
            for (i = 0; i < 500; i++)
            {
                resource++;
                Console.Write("1");

            }
        }
        static void Main(string[] args)
        {
            Thread th1 = new Thread(Test1);
            //Thread th2 = new Thread(Test2);
            th1.Start();

            th1.Join();
            Console.WriteLine("resource = {0}", resource);
        }
    }
}