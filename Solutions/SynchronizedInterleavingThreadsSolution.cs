using System;
using System.Threading;

namespace EPI2018.Solutions
{
    public static class SynchronizedInterleavingThreadsSolution {
        public static void PrintNumbers()
        {
            var monitor = new SynchronizeThreadsMonitor();
            var t1 = new OddThread(monitor);
            var t2 = new EvenThread(monitor);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }

        public class SynchronizeThreadsMonitor
        {
            public const bool OddTurn = true;
            public const bool EvenTurn = false;
            private bool turn = OddTurn;

            private static AutoResetEvent notifier = new AutoResetEvent(false);

            public void WaitTurn(bool oldTurn){
                while(turn != oldTurn){
                    try{
                        notifier.WaitOne();
                    } catch (ThreadInterruptedException e) {
                        Console.WriteLine("InterruptedException in WaitOne(): " + e);
                    }
                }
            }

            public void ToggleTurn(){
                turn ^= true;
                notifier.Set();
            }
        }

        public class OddThread {
            private Thread thread;
            private SynchronizeThreadsMonitor monitor;

            public OddThread(SynchronizeThreadsMonitor monitor){
                this.monitor = monitor;
                thread = new Thread(new ThreadStart(this.Run));
            }

            public void Start() => thread.Start();
            public void Join() => thread.Join();

            public void Run(){
                for (int i = 1; i <= 100; i+= 2)
                {
                    monitor.WaitTurn(SynchronizeThreadsMonitor.OddTurn);
                    Console.WriteLine("i = " + i);
                    monitor.ToggleTurn();
                }
            }
        }

        public class EvenThread {
            private Thread thread;
            private SynchronizeThreadsMonitor monitor;

            public EvenThread(SynchronizeThreadsMonitor monitor){
                this.monitor = monitor;
                thread = new Thread(new ThreadStart(this.Run));
            }

            public void Start() => thread.Start();
            public void Join() => thread.Join();

            public void Run(){
                for (int i = 2; i <= 100; i+= 2)
                {
                    monitor.WaitTurn(SynchronizeThreadsMonitor.EvenTurn);
                    Console.WriteLine("i = " + i);
                    monitor.ToggleTurn();
                }
            }
        }    
    }
}
