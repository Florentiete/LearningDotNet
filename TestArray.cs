using System;

class Geeks
{

    public static void Main()
    {
        string[] stringarr;

        stringarr = new string[5] { "Dot 1", "Dot 2", "Dot 3", "Dot 4", "Dot 5" };
        foreach (string item in stringarr)
        {
            Console.WriteLine(item);
        } 
       }
}
