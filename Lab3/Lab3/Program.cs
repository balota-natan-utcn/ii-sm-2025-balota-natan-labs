using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class ThreadsLab
{
    static void testEx1()
    {
        Thread t1 = new Thread(() => displayNumbers("Worker Thread", 300));
        t1.Start();

        displayNumbers("Main Thread", 300);
    }
    static void testEx2()
    {
        Thread t1 = new Thread(() => displayNumbers("Worker Thread", 300));
        t1.Start();

        t1.Join();

        displayNumbers("Main Thread", 300);
    }

    static void testEx3()
    {
        Thread t1 = new Thread(() => displayNumbers("Worker Thread", 1000));
        t1.Start();

        displayNumbers("Main Thread", 3000);
    }

    static void testEx4()
    {
        Thread t1 = new Thread(() => specialDisplay("Worker Thread", 1000));
        t1.Start();

        specialDisplay("Main Thread", 3000);
    }

    static volatile bool isWorkerThreadRunning = true;

    static void Main()
    {
        //testEx1();
        //testEx2();
        //testEx3();
        testEx4();
    }

    static void displayNumbers(object threadName, int waitTime)
    {
        string name = (string)threadName;
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(i+1 + " " + name);
            Thread.Sleep(waitTime);
        }
    }

    static void specialDisplay(object threadName, int waitTime)
    {
        string name = (string)threadName;
        for (int i = 0; i < 10; i++)
        {
            if (!isWorkerThreadRunning)
                return;
            Console.WriteLine(i + 1 + " " + name);
            Thread.Sleep(waitTime);
        }

        if (threadName == "Worker Thread")
            isWorkerThreadRunning = false;
    }
}