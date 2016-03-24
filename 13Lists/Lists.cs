using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _13Lists
{
    class Lists
    {
        static void Main(string[] args)
        {
            //LISTOVE
            List<int> numbers = new List<int>();//() = Razmer - moje i da ne se slaga
            numbers.Add(10000);
            numbers.Add(13);
            numbers.Add(1);
            numbers.Add(54);
            numbers.Add(3);
            
            numbers.Remove(1);//MAHAME ELEMENTA SAS STOINOST 1
            Console.WriteLine(numbers.Capacity);//KAKAV E KAPACITETA NA LISTA
            Console.WriteLine(numbers.Count);//KOLKO REALNO SA PALNITE ELEMENTI
            Console.WriteLine(numbers[0]);

            numbers[3] = 222;
            Console.WriteLine(numbers[1]);

            for (int i = 0; i < numbers.Count; i++)//VMESTO numbers.Length - SE PISHE numbers.Count
            {
                Console.WriteLine(numbers[i]);
            }

            //PRINTIRANE NA LIST - FOR
            List<int> numbers2 = new List<int>() { 2, 4, 5, 6 };
            numbers2.RemoveAt(1);//PREMAHVA ELEMENT OT DADENA POZICIYA

            for (int i = 0; i < numbers2.Count; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            //PRINTIRANE NA LIST - FOREACH
            List<string> imena = new List<string>(100000) { "Peter", "Mariya", "Katya", "Todor" };

            imena.Add("Nakov");//DOBAVYA V KRAYA NA LISTA
            imena.RemoveAt(0);
            imena.Insert(3, "Sylvia");//DOBAVYA "Sylvia" BEZ DA MAHA DRUG
            imena[1] = "Michael";
            imena.Sort();//SORTIRAME PO BUKVI
            imena.Reverse();//REVERSVAME SORTIRANETO V NIZHODYASHT RED

            foreach (var VARIABLE in imena)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.Write("capacity:");
            Console.WriteLine(imena.Capacity);
            Console.Write("count:");
            Console.WriteLine(imena.Count);
        }
    }
}
