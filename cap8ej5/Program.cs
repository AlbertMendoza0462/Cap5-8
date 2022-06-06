using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(78);
        arrayList.Add(75);
        arrayList.Add(80);
        arrayList.Add(12);
        arrayList.Add(56);
        arrayList.Add(23);
        
        int suma = (int) arrayList[0];
        float promedio = 0;
        int mayor = (int) arrayList[0];
        int menor = (int) arrayList[0];

        for(int i = 0; i < arrayList.Count; i++)
        {
            int num = (int) arrayList[i];
            if (num > mayor)
                mayor = num;

            if (num < menor)
                menor = num;

            suma += num;
        }

        promedio = suma / arrayList.Count;
        System.Console.WriteLine("La edad mayor es: " + mayor);
        System.Console.WriteLine("La edad menor es: " + menor);
        System.Console.WriteLine("El promedio es: " + promedio);
    }
}