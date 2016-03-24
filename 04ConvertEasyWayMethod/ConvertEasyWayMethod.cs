using System;

class ConvertEasyWayMethod
{
    static void Main()
    {
        // Kak po lesniya nachin s metoda "Convert.ToString" moje da se konvertirat chisla
        // The number to convert is 55
        Console.WriteLine("Number 55 in binary is: " + Convert.ToString(55, 2).PadLeft(32, '0'));//podravnyavane s '0' - 32 broya
        Console.WriteLine("Number 55 in hexadecimal is: " + Convert.ToString(55, 16).PadLeft(100, 'X'));//podravnyavane s 'X' - 100 broya
        Console.WriteLine("Number 55 in decimal is: " + Convert.ToString(55, 10));

        //Console.WriteLine("Number 1234 in binary is: " + Convert.ToString(1234, 2));
        //Console.WriteLine("Number 1234 in hexadecimal is: " + Convert.ToString(1234, 16));
    }
}
