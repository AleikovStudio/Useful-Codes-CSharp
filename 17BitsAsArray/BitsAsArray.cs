using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;

class BitsAsArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string n2 = Convert.ToString(n, 2).PadLeft(32, '0');

        List<string> list = new List<string>();

        for (int i = 0; i < n2.Length; i++)
        {
            list.Add(n2[i].ToString());
        }

        list.Reverse();

        list.Insert(16, "1");
        list.RemoveAt(3);

        list.Reverse();

        string back = string.Join("", list.ConvertAll(x => x.ToString()).ToArray());//PRAVENE NA STRING OT ELEMENTITE NA LIST-A
        Console.WriteLine(back);
        var n3 = Convert.ToInt32(back, 2).ToString();//CONVERTIRANE NA STRINGA V PROSTO INT

        Console.WriteLine(n3);

        //int n = 291;
        //int p = 5;
        //string n2 = Convert.ToString(291, 2).PadLeft(8, '0');
        //Console.WriteLine(n2);


        ////int nRightp = n >> p;
        ////int bit = nRightp & 1;
        ////Console.WriteLine(bit);
    }
}