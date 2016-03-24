using System;

class ConvertIntToBinary
{
    static void Main()
    {
        //Konvertira chisla ot Int kam Binary - 
        //deli se na 2 zashtoto e binary - the power of "2"
        
        int x = 1234;

        while (x > 0)
        {
            Console.WriteLine(x % 2);
            x = x / 2;
        }
    }
}
