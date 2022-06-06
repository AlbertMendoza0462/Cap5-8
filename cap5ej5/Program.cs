string numToStr(int num) {
    string result = "";
    switch (num)
    {
        case 0:
            result = "Cero";
            break;
        case 1:
            result = "Uno";
            break;
        case 2:
            result = "Dos";
            break;
        case 3:
            result = "Tres";
            break;
        case 4:
            result = "Cuatro";
            break;
        case 5:
            result = "Cinco";
            break;
        case 6:
            result = "Seis";
            break;
        case 7:
            result = "Siente";
            break;
        case 8:
            result = "Ocho";
            break;
        case 9:
            result = "Nueve";
            break;
        default:
            result = "Digite un numero entre 0 y 9.";
            break;
    }
    return result;
}

Console.Write("Digite el numero: ");
Console.WriteLine(numToStr(Int32.Parse(Console.ReadLine())));