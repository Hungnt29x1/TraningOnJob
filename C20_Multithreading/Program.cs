using System;
using System.Threading;

namespace C20_Multithreading
{
    /*
     - Multithreading là khái niệm thực hiện đồng thời nhiều tác vụ trong cùng một chương trình. Trong C#, Multithreading được thực hiện bằng cách sử dụng các lớp có sẵn như Thread, ThreadPool, BackgroundWorker và Task.

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Tạo 1 Thread mới và chạy nó
            Thread thread = new Thread(new ThreadStart(DoWork));
            thread.Start();

            //Thực hiện 1 số tác vụ trên main thread
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main thread doing some work");
                Thread.Sleep(100);
            }


            //-----------------------------------------
            // Tạo 10 tác vụ và thêm vào queue của ThreadPool
            for (int i = 1; i <= 10; i++)
            {
                int taskNumber = i;
                ThreadPool.QueueUserWorkItem(state => Task(taskNumber));
            }

            Console.WriteLine("All tasks have been queued to the thread pool");

            // Chờ cho tất cả các tác vụ hoàn thành
            while (ThreadPool.PendingWorkItemCount > 0)
            {
                Console.WriteLine("{0} tasks are still pending in the thread pool", ThreadPool.PendingWorkItemCount);
                Thread.Sleep(500);
            }

            Console.WriteLine("All tasks have been completed");

        }
        static void DoWork()
        {
            //Thực hiện 1 số tác vụ trên thread mới
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Đây là Thread tại DoWork");
                Thread.Sleep(500);
            }
        }

        static void Task(int taskNumber)
        {
            Console.WriteLine("Task {0} is starting", taskNumber);
            Thread.Sleep(1000);
            Console.WriteLine("Task {0} is finished", taskNumber);
        }
    }
}
