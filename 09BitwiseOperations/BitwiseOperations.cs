using System;

class BitwiseOperations
{
    static void Main()
    {
////////VZIMANE NA STOINOSTTA NA KRAINO DESNIYA BIT:
        int a = 7;
        Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));

        int result = a & 1;
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));

////////VZIMANE NA STOINOSTTA NA CHISLO NA RANDOM POZICIYA --> STAVA SAS SHIFT:
        int a2 = 444;
        Console.WriteLine("The NUMBER: " + Convert.ToString(a2, 2).PadLeft(32, '0'));

        int p = 2;
        int a2Rightp = a2 >> p;//izmestvame a s poziciya koyato ni interesuva
        Console.WriteLine("  The MASK: " + Convert.ToString(a2Rightp, 2).PadLeft(32, '0'));

        int result2 = a2Rightp & 1;
        Console.WriteLine("The RESULT: " + Convert.ToString(result2, 2).PadLeft(32, '0'));

////////SMYANA V OPREDELENA POZICIYA S "1"-CA:
        int a3 = 7;
        Console.WriteLine("The NUMBER: " + Convert.ToString(a3, 2).PadLeft(32, '0'));

        int p3 = 2;
        int mask3 = 1 << p3;//izmestvame a3 s poziciya koyato ni interesuva
        Console.WriteLine("  The MASK: " + Convert.ToString(mask3, 2).PadLeft(32, '0'));

        int result3 = mask3 | a3;
        Console.WriteLine("The RESULT: " + Convert.ToString(result3, 2).PadLeft(32, '0'));

////////SMYANA V OPREDELENA POZICIYA S "0"-LA:
        int a4 = 6;
        Console.WriteLine("The NUMBER: " + Convert.ToString(a4, 2).PadLeft(32, '0'));

        int p4 = 2;
        int mask4 = ~(1 << p4);//izmestvame a s poziciya koyato ni interesuva
        Console.WriteLine("  The MASK: " + Convert.ToString(mask4, 2).PadLeft(32, '0'));

        int result4 = mask4 & a4;
        Console.WriteLine("The RESULT: " + Convert.ToString(result4, 2).PadLeft(32, '0'));

////////ZAMYANA NA BIT V OPREDELENA POZICIYA S OBRATNIYA:
        int a5 = 2;
        Console.WriteLine("The NUMBER: " + Convert.ToString(a5, 2).PadLeft(32, '0'));

        int p5 = 2;
        int mask5 = 1 << p5;//izmestvame a s poziciya koyato ni interesuva
        Console.WriteLine("  The MASK: " + Convert.ToString(mask5, 2).PadLeft(32, '0'));

        int result5 = mask5 ^ a5;
        Console.WriteLine("The RESULT: " + Convert.ToString(result5, 2).PadLeft(32, '0'));
    }
}