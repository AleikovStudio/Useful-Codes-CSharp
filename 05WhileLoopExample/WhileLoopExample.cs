using System;

class WhileLoopExample
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        int sum = 1;

        Console.Write("The sum 1");
        while (num < n)
        {
            num++;
            sum = sum + num;
            Console.Write(" + " + num);
        }
        Console.WriteLine(" = " + sum);
    }
}