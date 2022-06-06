double factorial(double num){
    return (num > 1) ? num * factorial(num - 1) : 1;
}

Console.Write("Digite el numero: ");
Console.WriteLine("El factorial es: " + factorial(Int32.Parse(Console.ReadLine())));