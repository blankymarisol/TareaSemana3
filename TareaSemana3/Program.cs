using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ingrese un numero 1-5 en letra");
        string letra = Console.ReadLine().ToLower();
        int numero;

        switch (letra)
        {
            case "uno":
                numero = 1;
                break;
            case "dos":
                numero = 2;
                break;
            case "tres":
                numero = 3;
                break;
            case "cuatro":
                numero = 4;
                break;
            case "cinco":
                numero = 5;
                break;
            default:
                Console.WriteLine("No ingresas el numero correcto :(");
                return;
        }
        Console.WriteLine($"El numero en digito es: " + numero);
    }
}