using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart startThread1 = new ThreadStart(Thread1);
            ThreadStart startThread2 = new ThreadStart(Thread2);
            ThreadStart startThread3 = new ThreadStart(Thread3);

            Thread thread1 = new Thread(startThread1);
            Thread thread2 = new Thread(startThread2);
            Thread thread3 = new Thread(startThread3);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            Console.ReadLine();
        }

        public static void Thread1()
        {
            int interval = 2000;
            Thread.Sleep(interval);
            Console.WriteLine("Thread 1 finished.");
        }

        public static void Thread2()
        {
            int interval = 6000;
            Thread.Sleep(interval);
            Console.WriteLine("Thread 2 finished.");
        }

        public static void Thread3()
        {
            int interval = 4000;
            Thread.Sleep(interval);
            Console.WriteLine("Thread 3 finished.");
        }
    }
}
