using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("Albert", "8097861493");
        hashtable.Add("Manuel", "8296548523");
        hashtable.Add("Sammy", "8097536985");

        foreach (DictionaryEntry item in hashtable)  
        {
            System.Console.WriteLine($"{item.Key}: {item.Value}");  
        }  
    }
}