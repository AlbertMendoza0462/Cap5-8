using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("comer", "Tomar los alimentos que componen alguna de las dos comidas principales del día.");
        hashtable.Add("llegar", "Pasar a estar [una persona o una cosa] en el fin o el término de un desplazamiento, una marcha o una trayectoria.");
        hashtable.Add("salir", "Ir o pasar de un lugar cerrado o limitado al exterior, a través de una abertura o paso.");

        System.Console.WriteLine("Cual palabra desea investigar? (comer, llegar o salir)");
        string res = Console.ReadLine();

        if (res.Equals("comer") || res.Equals("llegar") || res.Equals("salir"))
        {
            System.Console.WriteLine(res + ": " + hashtable[res]);
        }
    }
}