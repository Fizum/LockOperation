using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aumento
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            for (int i = 0; i < 5; i++)
            {
                Task th=new Task(() =>
                {
                    n++;
                    Thread.Sleep(1);
                    Console.WriteLine($"n: {n}");
                });
                th.Start();
            }
            Console.ReadLine();
        }
    }
}
