using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ingresa el idioma en que deseas el mensaje");
        string idioma = Console.ReadLine();
        string mensaje; 


        switch (idioma)
        {
            case "ingles":
                mensaje = "Welcome to my program";
                break;
            case "espanol":
                mensaje = "Bienvenido a mi programa";
                break;
            case "frances":
                mensaje = "Bienvenue dans mon programme";
                break;
            default:
                Console.WriteLine("El idioma solicitado no es valido :(");
                return;
        }
        Console.WriteLine($"Tu mensaje es: " + mensaje);
    }
}