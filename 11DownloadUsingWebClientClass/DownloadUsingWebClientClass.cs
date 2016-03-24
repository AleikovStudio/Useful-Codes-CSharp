using System;
using System.Diagnostics;
using System.Net;

class DownloadUsingWebClientClass
{
    static void Main()
    {
        string url = "http://www.introprogramming.info/wp-content/uploads/2015/10/";
        string localFileName = "NakovKniga.pdf";//Svaleno e v papkata s programata - bin>>Debug
        Console.WriteLine("Svalyam {0}....", url);

        WebClient webcl = new WebClient();
        webcl.DownloadFile(url, localFileName);

        Process.Start(localFileName);
    }
}