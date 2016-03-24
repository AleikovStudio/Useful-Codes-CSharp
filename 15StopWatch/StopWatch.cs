using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;

public static class StopWatch
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        string something = string.Empty;

        for (int i = 0; i < 100000; i++)
        {
            something += i;
        }

        Console.WriteLine(sw.Elapsed);
    }
}