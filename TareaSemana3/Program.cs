int numero;

try
{
    Console.WriteLine("Por ingresa un numero");
    numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("El numero ingresado es par");
    }
    else
    {
        Console.WriteLine("El numero ingresado es impar");
    }
}
catch (Exception ex)
{
    Console.WriteLine("No ingresaste lo que se te solicito :(" + ex.Message);
}