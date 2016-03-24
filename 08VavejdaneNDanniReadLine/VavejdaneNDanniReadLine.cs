using System;
using System.Linq;

class VavejdaneNDanniReadLine
{
    static void Main()
    {
        //NACHIN za izvejdane na masiva - NO ako znaesh kolko elementa ima!
        string[] input = Console.ReadLine().Split(' ');//Vavejdane na danni v masiv na edin red razdeleni s metoda .Split i znakat * ili interval !!! Tryabva da go ima! obratnoto na Split e Join - za otpechatvane >> Console.WriteLine(string.Join("\n",gradove));
        string month = input[0];//Vavejdaj parviya element na masiva
        string day = input[1];//Vavejdaj vtoriya element na masiva
        string minutes = input[2];//Vavejdaj tretiya element na masiva
        string proba = month + day + minutes;//Mojesh da si igraesh s gornite elementi na masiva
        Console.WriteLine("{0}{1}{2} -> {3}", month, day, minutes, proba);

        //Parvi nachin za printirane na masiva (elementite mu) s metoda .Length na masiva
        for (int i = 0; i < input.Length; i++)//NE tryabva da se znae kolko elementa na masiva ima - za da se otpechata!!!
        {
            Console.WriteLine(input[i]);
        }

        //VTORI NACHIN za printirane na masiva (elementite mu):
        foreach (var item in input)//NE tryabva da se znae kolko elementa na masiva ima - za da se otpechata!!!
        {
            Console.WriteLine(item);
        }
        decimal moneyPerHour = decimal.Parse(input[1]);
        decimal hoursPerDay = decimal.Parse(input[2]);
        decimal itemPrice = decimal.Parse(input[3]); 

        //TRETI NACHIN - sam si gi vavejda potrebitelyat:
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter arr [{0}]", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(arr.Sum());

        //REVERSE otpechatvane na masivi
        string[] gradove = new string[] 
        {
            "Shumen",
            "Sofia",
            "Sopot"
        };
        for (int i = gradove.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(gradove[i]);
        }

        //REVERSE s method-a Array.reverse i foreach loop
        string[] gradove2 = new string[] 
        {
            "Shumen",
            "Sofia",
            "Sopot"
        };

        Array.Reverse(gradove2);
        foreach (var item in gradove2)
        {
            Console.WriteLine(item);
        }
    }
}