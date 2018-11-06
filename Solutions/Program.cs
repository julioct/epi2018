using System;

namespace EPI2018.Solutions
{
    class Program
    {
        static void Main(string[] args)
        {   
            //SynchronizedInterleavingThreadsTest();
            //ReadersWritersSolutionTest();
                     
            Console.WriteLine("DONE!");
        }

        private static void SynchronizedInterleavingThreadsTest(){
            SynchronizedInterleavingThreadsSolution.PrintNumbers();
        }

        private static void ReadersWritersSolutionTest(){
            ReadersWritersSolution.Start();
        }
    }
}
