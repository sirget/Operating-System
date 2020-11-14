using System;
using System.Threading;

namespace lab02
{
    class Program
    {
        private static string x = "";
        private static int exflag = 0;
        private static int check = 0;

        static void ThReadX()
        {
            while (exflag == 0)
            {
                if (check == 1)
                {
                    Console.WriteLine("X = {0}", x);
                    check = 0;
                }


            }
        }

        static void ThWriteX()
        {
            string xx;
            while (exflag == 0)
            {
                if (check == 0)
                {
                    Console.Write("Input : ");
                    xx = Console.ReadLine();
                    if (xx == "exit")
                        exflag = 1;
                    else
                    {
                        x = xx;
                        check = 1;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Thread A = new Thread(ThReadX);
            Thread B = new Thread(ThWriteX);
            A.Start();
            B.Start();
        }
    }
}
