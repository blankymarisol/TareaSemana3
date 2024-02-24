int edad;

try
{
    Console.WriteLine("Por favor ingresa tu edad");
    edad = int.Parse(Console.ReadLine());

    if (edad >= 18)
    {
        Console.WriteLine("Eres mayor de edad, pasa adelante");
    }
    else
    {
        Console.WriteLine("Eres menor de edad, por favor retirate");
    }
}
catch (Exception ex)
{
    Console.WriteLine("No ingresaste lo que se te solicito :(" + ex.Message);
}