using System;
using System.Collections.Generic;
using System.Threading;

namespace EPI2018.Solutions
{
    public static class ReadersWritersSolution{

        public static void Start()
        {
            var r1 = new Reader();
            r1.Start();
            var r2 = new Reader();
            r2.Start();
            var r3 = new Reader();
            r3.Start();
            var w = new Writer();
            w.Start();
        }        

        public class Reader {
            private Thread thread;

            public Reader(){
                thread = new Thread(new ThreadStart(Run));
            }

            public void Start() => thread.Start();

            public void Run(){
                while (true)
                {
                    lock(ReaderWriter.LR){
                        ReaderWriter.ReadCount++;
                        Console.WriteLine($"Read count: {ReaderWriter.ReadCount}");
                    }

                    Console.WriteLine($"Read: {ReaderWriter.Data}");
                    Console.WriteLine($"Reader working...");
                    Thread.Sleep(10000);

                    lock(ReaderWriter.LR){
                        ReaderWriter.ReadCount--;
                        Console.WriteLine($"Read count: {ReaderWriter.ReadCount}");
                        ReaderWriter.NotifyLR();
                    }

                    var rand = new Random();
                    var secs = rand.Next(1, 5);
                    Console.WriteLine($"Reader sleeping {secs} seconds...");
                    Thread.Sleep(secs * 1000);
                }
            }
        }

        public class Writer {
            private Thread thread;

            public Writer(){
                thread = new Thread(new ThreadStart(Run));
            }

            public void Start() => thread.Start();

            public void Run(){
                while(true){
                    lock(ReaderWriter.LW){
                        var done = false;

                        while(!done){
                            lock(ReaderWriter.LR){
                                if (ReaderWriter.ReadCount == 0)
                                {
                                    ReaderWriter.Data = DateTime.Now.ToString();
                                    Console.WriteLine($"Writer wrote {ReaderWriter.Data}");
                                    done = true;
                                }                                 
                            }

                            try{
                                while(ReaderWriter.ReadCount != 0){
                                    Console.WriteLine("Writer waiting...");
                                    ReaderWriter.WaitLR();
                                }
                            } catch (ThreadInterruptedException e) {
                                Console.WriteLine("ThreadInterruptedException in Writer wait");
                            }                            
                        }

                        var rand = new Random();
                        var secs = rand.Next(1, 5);
                        Console.WriteLine($"Writer sleeping {secs} seconds...");
                        Thread.Sleep(secs * 1000);                    
                    }
                }
            }
        }

        public static class ReaderWriter
        {
            public static string Data;
            public static object LR = new object();
            public static object LW = new object();
            public static int ReadCount;        

            private static AutoResetEvent notifier = new AutoResetEvent(false);

            public static bool NotifyLR(){
                return notifier.Set();
            }

            public static bool WaitLR(){
                return notifier.WaitOne();
            }
        }
    }
}