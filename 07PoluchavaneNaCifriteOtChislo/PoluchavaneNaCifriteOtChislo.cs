using System;
using System.Collections.Generic;

class PoluchavaneNaCifriteOtChislo
{
    static void Main()
    {
        int a = 45436;
        int b = (45436 / 10000) % 10;
        int c = (45436 / 1000) % 10;
        int d = (45436 / 100) % 10;
        int e = (45436 / 10) % 10;
        int f = (45436 % 10);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        
        //OBYASNENIE:

        int n = int.Parse(Console.ReadLine());//the user inputs 4 digits number

        int firstNumber = (n / 1000) % 10;//divide by 1000 >> then module dividing by 10 to get the 1st number of the 4th digit number
        int secondNumber = (n / 100) % 10;//divide by 100 >> then module dividing by 10 to get the 2nd number of the 4th digit number
        int thirdNumber = (n / 10) % 10;//divide by 10 >> then module dividing by 10 to get the 3rd number of the 4th digit number
        int fourthNumber = (n % 10);//Module dividing by 10 to get the 4th number of the 4th digit number

        //Console.WriteLine("{0},{1},{2},{3}",firstNumber, secondNumber, thirdNumber, fourthNumber);//Check whether it works!
       
    }
}