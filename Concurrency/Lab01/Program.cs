using System;
using System.Threading;

namespace Lab_OS_01
{
    class Program
    {
        static void Test1()
        {
            int i;
            for (i = 0; i < 100; i++)
                Console.WriteLine("Thread 1 i={0}", i);
        }
        static void Test2()
        {
            int i;
            for (i = 0; i < 100; i++)
                Console.WriteLine("Thread 2 i={0}", i);
        }

        static void Main(string[] args)
        {
            Thread th1 = new Thread(Test1);
            Thread th2 = new Thread(Test2);
            th1.Start();
            th2.Start();
        }
    }
}