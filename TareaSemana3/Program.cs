using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ingresa tu calificacion por favor");
        int calificacion = Convert.ToInt32(Console.ReadLine().ToLower());
        string resultado;

        switch (calificacion)
        {
            case int b when b >= 90 && b <= 100:
                resultado = "Sobresaliente. FELICIDADES!!!!";
                break;
            case int b when b >= 80 && b <= 89:
                resultado = "Notable. Tu calificacion es promedio";
                break;
            case int b when b >= 70 && b <= 79:
                resultado = "Aprobada. Esfuerzate, se que puedes lograr mas";
                break;
            case int b when b >= 60 && b <= 69:
                resultado = "Reprobado. Que lastima que no lo lograste";
                break;
            default:
                Console.WriteLine("El numero ingresado no es valido como calificacion :(");
                return;
        }
        Console.WriteLine($"Tu resultado es: " + resultado);
    }
}