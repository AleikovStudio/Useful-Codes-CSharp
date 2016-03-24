using System;
using System.Collections.Generic;

class AddWhile
{
    static void Main()
    {
        string line = Console.ReadLine();//INPUT STRING
        List<string> lineList = new List<string>();

        while (line != "rain")
        {
            line = Console.ReadLine();//THE NEXT INPUT STRING MUST BE AT THE END!
            lineList.Add(line);
        }
        foreach (var VARIABLE in lineList)
        {
            Console.WriteLine(VARIABLE);
        }
    }
}