using System;

class CompareNumbers
{
    static void Main()
    {
        int a = 5;
        int b = 6;
        int c = 7;
        int d = 8;
        int e = 9;

        //Math method-a s funkciyata Min - v skobite se sravnyavat SAMO 2 chisla - i taka po-natatak
        int compare1 = Math.Min(a,b);
        int compare2 = Math.Min(c, d);
        int compare3 = Math.Min(compare1, compare2);
        int compare4 = Math.Min(compare3, e);
        Console.WriteLine(compare4);
    }
}