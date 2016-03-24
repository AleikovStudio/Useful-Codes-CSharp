using System;

class ForLoop
{
    static void Main()
    {
        for (int i = 1, sum2 = 1; i < 128; i = i * 2, sum2 = sum2 + i)
        {
            Console.WriteLine("i = {0}, sum = {1}", i, sum2);
        }
        //Drug primer za for loop
        for (int small = 1, large = 10; small < large; small++, large--)
        {
            Console.WriteLine(small + " " + large);
        }

        //Otpechatvane na triagalnik
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
        //Happy numbers
        for (int a = 1; a <= 9; a++)
        {
            for (int b = 0; b < 9; b++)
            {
                for (int c = 0; c < 9; c++)
                {
                    for (int d = 0; d < 9; d++)
                    {
                        if ((a + b) == (c + d))
                        {
                            Console.WriteLine(" " + a + " " + b + " " + c + " " + d);
                        }
                    }
                }
            }
        }
        //KAK SE POLUCHAVA SUMA VAV FOR CIKAL
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        string letter = Console.ReadLine();

        int sum = 0;
        for (int i = startNumber; i < endNumber; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }

            else if (i % 5 != 0)
            {
                sum += (i % 5);
            }
        }
        Console.WriteLine(sum);   
    }
}