using System;
using System.Collections.Generic;

class InputList//CLASS
{
    static void Main()//METHOD
    {
        List<string> firstList = new List<string>();//FIRST LIST OF NAMES
        string[] firstArray = Console.ReadLine().Split();

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstList.Add(firstArray[i]);
        }

        List<string> secondList = new List<string>();//SECOND LIST OF NAMES
        string[] secondArray = Console.ReadLine().Split();

        for (int i = 0; i < secondArray.Length; i++)
        {
            secondList.Add(secondArray[i]);
        }

        List<string> allLists = new List<string>();//COMBINED LIST OF 1ST AND 2ND LISTS
        foreach (var VARIABLE in firstList)
        {
            if (secondList.Contains(VARIABLE))
            {
                continue;
            }
            else
            {
                allLists.Add(VARIABLE);
            }
        }

        foreach (var VARIABLE in allLists)
        {
            Console.Write("{0} ", VARIABLE);
        }
        Console.WriteLine();

        //ANOTHER EXAMPLE:
        string[] fArray = Console.ReadLine().Split();//USER INPUT 1ST ARRAY
        List<string> fList = new List<string>();//ADD 1ST LIST

        for (int i = 0; i < fArray.Length; i++)//POPULATE THE 1ST LIST WITH THE ELEMENTS OF THE 1ST ARRAY
        {
            fList.Add(fArray[i]);
        }

        string[] sArray = Console.ReadLine().Split();//USER INPUT 2ND ARRAY
        List<string> sList = new List<string>();//ADD 2ND LIST

        for (int i = 0; i < sArray.Length; i++)//POPULATE THE 2ND LIST WITH THE ELEMENTS OF THE 2ND ARRAY
        {
            sList.Add(sArray[i]);
        }

        for (int i = 0; i < fList.Count; i++)
        {
            if (!sList.Contains(fList[i]))
            {
                sList.Add(fList[i]);
            }
            else
            {
                continue;
            }
        }

        sList.Sort();

        foreach (var VARIABLE in sList)
        {
            Console.Write("{0} ", VARIABLE);
        }
        Console.WriteLine();
    }
}