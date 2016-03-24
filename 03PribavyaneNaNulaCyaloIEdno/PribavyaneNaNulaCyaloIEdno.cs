using System;

class PribavyaneNaNulaCyaloIEdno
{
    static void Main()
    {
        //Sabirane e s "0" - za da e sashtiyat rezultat, 
        //a deleneto e s "1" - za da e sashtiyat rezultat

        float sumfloat = 0f;
        for (int i = 0; i < 1000; i++)
        {
            sumfloat = sumfloat + 0.1f;
        }
        Console.WriteLine("Sum Float = {0}", sumfloat);

        /////////////////////////////////////////////////////////////

        double sumdouble = 0d;
        for (int i = 0; i < 1000; i++)
        {
            sumdouble = sumdouble + 0.1d;
        }
        Console.WriteLine("Sum Double = {0}", sumdouble);

        /////////////////////////////////////////////////////////////

        decimal sumdecimal = 0m;
        for (int i = 0; i < 1000; i++)
        {
            sumdecimal = sumdecimal + 0.1m;
        }
        Console.WriteLine("Sum Decimal = {0}", sumdecimal);


        float a = (0.1f * 1000);
        double b = (0.1d * 1000);
        decimal c = (0.1m * 1000);

        Console.WriteLine("{0},{1},{2}", a, b, c);
    }
}
