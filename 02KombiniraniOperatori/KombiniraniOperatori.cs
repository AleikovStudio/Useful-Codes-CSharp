using System;

class KombiniraniOperatori
{
    static void Main()
    {
        int x = 6; //6-cata otgovarya samo za tozi red - NE i za drugite redove, kogato "x" se promenya
        Console.WriteLine(x |= 1); //7: "|" - e binaren operator "ili" (110(6) | 001(1)) = 111 (=7) 
        Console.WriteLine(x += 3); // (x = x+3) 10: vzima stoinostta na "x" ot gorniya red = 7 (7+3=10)
        Console.WriteLine(x /= 2); // (x = x/2) 5: vzima stoinostta na "x" ot gorniya red = (10/2=5)
    }
}



