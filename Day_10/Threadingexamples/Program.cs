using System;

namespace Threadingexamples
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Start();

            
            Thread t2 = new Thread(Func2);
            t2.Start();
            
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Main: "+i);
            }
        }

        static void Main2()
        {
            Thread t1=new Thread(new ThreadStart(Func1));
            t1.IsBackground = true;
            t1.Start();

            Thread t2=new Thread(Func2);
            t2.IsBackground = true;
            t2.Start();


            for(int i = 0;i<1;i++)
            {
                Console.WriteLine("Main: "+i);
            }
        }

        static void Main3()
        {
            Thread t1=new Thread(new ThreadStart(Func1));
            //t1.IsBackground=true;
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Start();

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Main: "+i);
            }
            t1.Join();  // join is waiting call. it will run after fun-1 is over
            Console.WriteLine("This code will run After Function-1 is Over.");
        }

        static void Main4()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Priority = ThreadPriority.Highest;

            t1.Start();


            Thread t2=new Thread(Func2);
            t2.Priority = ThreadPriority.Lowest;
            t2.Start();


            for(int i=0;i<100;i++)
            {
                Console.WriteLine("Main: "+i);
            }
        }

        static void Main5()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));


            t1.Start();

            //t1.Abort();
            //t1.Suspend();
            //t1.Resume();

            Thread t2 = new Thread(Func2);

            t2.Start();

            for(int i=0;i<100;i++)
            {
                Console.WriteLine("Main: "+i);
            }
        }

        static void Main6()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));


            t1.Start();
            Thread.Sleep(1000);

            Thread t2 = new Thread(Func2);

            t2.Start();
            Thread.Sleep(1000);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main: " + i);
                Thread.Sleep(3000);
            }
        }

        static void Main()
        {
            AutoResetEvent wh=new AutoResetEvent(false);
            Thread t1 = new Thread(delegate ()
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine("F1: "+i);
                    if (i%50==0)
                    {

                        Console.WriteLine("Waiting..");
                        wh.WaitOne();
                    }
                }
            });

            t1.Start();

            Thread.Sleep(3000);
            Console.WriteLine("Resuming--1");
            wh.Set();

            Thread.Sleep(3000);
            Console.WriteLine("Resuming--2");
            wh.Set();

            Thread.Sleep(3000);
            Console.WriteLine("Resuming--3");
            wh.Set();

            Thread.Sleep(3000);
            Console.WriteLine("Resuming--4");
            wh.Set();
        }



        static void Func1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("First: "+i);
            }
        }

        static void Func2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second: " + i);
            }
        }
    }
}


namespace Threadingexamples1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Thread t1 = new Thread(new ThreadStart(Func1));
            //t1.Start();


            //Thread t2 = new Thread(Func2);
            //t2.Start();

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Main: " + i);
            }
        }

        static void Func1(object obj)
        {

            int x=(int) obj;

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("");
            }
        }

    }
}