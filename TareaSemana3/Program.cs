int num1, num2, num3;

try
{

    Console.WriteLine("Por favor ingresa un numero");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Por favor ingresa un numero");
    num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Por favor ingresa un numero");
    num3 = int.Parse(Console.ReadLine());

    if (num1 >= num2 && num1 >= num3)
    {
        Console.WriteLine("El numero mayor es: " + num1);
    }
    else if (num2 >= num1 && num2 >= num3)
    {
        Console.WriteLine("El numero mayor es: " + num2);
    }
    else
    {
        Console.WriteLine("El numero mayor es: " + num3);
    }
}
catch (Exception ex)
{
    Console.WriteLine("No ingresaste lo que se te solicito :(" + ex.Message);
}