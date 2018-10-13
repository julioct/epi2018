using System;

namespace EPI2018.Solutions
{
    class Program
    {
        static void Main(string[] args)
        {   
            SynchronizedInterleavingThreadsTest();
                     
            Console.WriteLine("DONE!");
        }

        private static void SynchronizedInterleavingThreadsTest(){
            SynchronizedInterleavingThreadsSolution.PrintNumbers();
        }
    }
}
