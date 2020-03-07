using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LockOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(ThreadUnsafe.Go);
            Task.Factory.StartNew(ThreadUnsafe.Go);
            Task.Factory.StartNew(ThreadUnsafe.Go);
            Task.Factory.StartNew(ThreadUnsafe.Go);
            Task.Factory.StartNew(ThreadUnsafe.Go);

            Console.ReadLine();
        }
    }

    class ThreadUnsafe
    {
        public static object myObj = new object();
        static int _val1 = 1, _val2 = 1;

        public static void Go()
        {
            //lock (myObj)
            Monitor.Enter(myObj);
            try
            {
                if (_val2 != 0)
                {
                    Console.WriteLine(_val1 / _val2);
                    _val2 = 0;
                }
            }
            catch
            {
                Console.WriteLine("Operazione non eseguibile");
            }
            finally
            {
                Monitor.Exit(myObj);
            }
        }
    }
}
