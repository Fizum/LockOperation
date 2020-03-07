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
            object obj = new object();
            int n = 0;

            for (int i = 0; i < 5; i++)
            {
                Task th=new Task(() =>
                {
                    //lock (obj)
                    {
                        n++;
                        Thread.Sleep(1);
                        Console.WriteLine($"n: {n}"); 
                    }
                });
                th.Start();
            }
            Console.ReadLine();
        }
    }
}
