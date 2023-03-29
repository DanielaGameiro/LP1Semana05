using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elapsed.TotalSeconds
            // IsRunning
            // Start (), StartNew(), Reset(), Stop()...

            // Declare and initialize variables
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            
            // Start crono1 and crono2
            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(300);

            // Stop crono1 and crono2
            crono1.Stop();
            crono2.Stop();

            // Show the time
            Console.WriteLine($"Crono 1: {crono1.Elapsed.TotalSeconds:f2}s");
            Console.WriteLine($"Crono 2: {crono2.Elapsed.TotalSeconds:f2}s");
        }
    }
}