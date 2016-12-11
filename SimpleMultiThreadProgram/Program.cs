using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMultiThreadProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread (thread id:{0}) starting", Thread.CurrentThread.ManagedThreadId);

            Action ac = () => {
                Console.WriteLine("Another thread (thread id: {0}) starting", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(5000);
                Console.WriteLine("Another thread (thread id: {0}) ended", Thread.CurrentThread.ManagedThreadId);
            };

            for (int i = 0; i < 15; i++)
            {
                Task.Run(ac);
            }

            Console.WriteLine("Main thread (thread id:{0}) ended", Thread.CurrentThread.ManagedThreadId);
            Console.Read();
        }
    }
}
