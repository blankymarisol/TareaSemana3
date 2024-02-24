int edad, monto;
string nombre, apellido;

try
{
    Console.WriteLine("Ingresa tu nombre");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingresa tu apellido");
    apellido = Console.ReadLine();
    Console.WriteLine("Ingrese el monto que desea");
    monto = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su edad");
    edad = int.Parse(Console.ReadLine());

    if (monto >= 5000 && edad <= 60)
    {
        Console.WriteLine(nombre); Console.WriteLine(apellido); Console.WriteLine("Su prestamo ha sido aprobado");
    }
    else
    {
        Console.WriteLine(nombre); Console.WriteLine(apellido); Console.WriteLine("Su prestamo no ha sido aprobado");
    }
}
catch (Exception ex)
{
    Console.WriteLine("No ingresaste lo que se te solicito :(" + ex.Message);
}