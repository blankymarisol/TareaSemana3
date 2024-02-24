using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ingresa el numero de 1-7");
        int numero = Convert.ToInt32(Console.ReadLine().ToLower());
        string dia; 


        switch (numero)
        {
            case 1:
                dia = "lunes";
                break;
            case 2:
                dia = "martes";
                break;
            case 3:
                dia = "miercoles";
                break;
            case 4:
                dia = "jueves";
                break;
            case 5:
                dia = "viernes";
                break;
            case 6:
                dia = "sabado";
                break;
            case 7:
                dia = "domingo";
                break;
            default:
                Console.WriteLine("No ingresas el numero correcto :(");
                return;
        }
        Console.WriteLine($"El dia que solicitaste es: " + dia);
    }
}