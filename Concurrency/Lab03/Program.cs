using System;
using System.Threading;

namespace Lab_OS_03
{
    class Program
    {
        static int resource = 10000;
        static void Test1()
        {

            resource = 55555;

        }
        static void Main(string[] args)
        {
            Thread th1 = new Thread(Test1);
            th1.Start();
            th1.Join();
            Thread.Sleep(10);
            Console.WriteLine("resource = {0}", resource);
            //Thread.Sleep(10);
            Console.WriteLine("resource = {0}", resource);
        }
    }
}