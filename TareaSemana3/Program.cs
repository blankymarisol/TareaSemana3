using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ingresa el servicio que desea consultar");
        string servicio = Console.ReadLine();
        string pago; 


        switch (servicio)
        {
            case "lavado de auto":
                pago = "Q.35.00";
                break;
            case "cambio de aceite":
                pago = "Q.55.00";
                break;
            case "revision mecanica":
                pago = "Q.45.00";
                break;
            default:
                Console.WriteLine("El servicio ingresado no es valido :(");
                return;
        }
        Console.WriteLine($"El costo del servicio es: " + pago);
    }
}