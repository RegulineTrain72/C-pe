using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int max = 0;
            try
            {
                while (true)
                {
                    NewCalss cl = new NewCalss();
                    int t = NewCalss.c;
                    Console.WriteLine(t);
                    if (t > max)
                    {
                        max = t;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception)
            {

            }
            Console.WriteLine("Max:" + max);
        }
    }
}
