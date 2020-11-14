using System;
using System.Threading;

namespace Lab_OS_02
{
    class Program
    {
        static int resource = 50000;
        static void Test1()
        {
            Console.WriteLine("Thread 1 i={0}", resource);
        }
        static void Test2()
        {
            Console.WriteLine("Thread 2 i={0}", resource);
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