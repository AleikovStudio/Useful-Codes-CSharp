using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DictionaryExample
{
    static void Main(string[] args)
    {
        //DICTIONARIES
        Dictionary<string, int> students = new Dictionary<string, int>();

        students.Add("Ivan", 6);
        students.Add("Mariika", 2);
        students["Pesho"] = 12;//DRUG NACHIN ZA IZPISVANE

        //DICTIONARY SE PRINTIRA S FOREACH
        foreach (var student in students)
        {
            Console.WriteLine("Student name {0} with grade {1}:", student.Key, student.Value);
        }

        //DRUG PRIMER ZA DICTIONARY:
        Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();

        events[new DateTime(1998, 9, 4)] = "Google's birthday";
        events[DateTime.MaxValue] = "SoftUni's birthday";
        events[new DateTime(1985, 3, 11)] = "My birthday";

        foreach (var entry in events)
        {
            Console.WriteLine("{0:dd-MMM-yyyy}: {1}", entry.Key, entry.Value);
        }

        foreach (var dates in events.Keys)//PRINTIRA SAMO KEYS
        {
            Console.WriteLine(dates);
        }

        foreach (var oneEvent in events.Values)//PRINTIRA SAMO EVENTS - BEZ DATITE
        {
            Console.WriteLine(oneEvent);
        }
    }
}