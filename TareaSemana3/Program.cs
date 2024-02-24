int precio;
double descuento, preciocondescuento;

try
{
    Console.WriteLine("Por favor ingresa el precio de tu producto");
    precio = int.Parse(Console.ReadLine());

    if (precio >= 100)
    {
        descuento = precio * 0.10;
        preciocondescuento = precio - descuento;
        Console.WriteLine("Felicidades, tu producto tiene el 10% de descuento");
        Console.WriteLine("El precio de tu producto es: " + preciocondescuento);
    }
    else
    {
        Console.WriteLine("Tu producto no tiene descuento, su precio es: " + precio);
    }
}
catch (Exception ex)
{
    Console.WriteLine("No ingresaste lo que se te solicito :(" + ex.Message);
}