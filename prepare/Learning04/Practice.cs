using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Compression;

class Program
{

    public static void Main(string[] args)
    {
        // Console.WriteLine("BOB");

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(10);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(".");
            Thread.Sleep(500);
        }
        
    }
}