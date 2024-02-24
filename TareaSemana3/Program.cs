int opcion;
double triangulo, cuadrado, circulo, basse, altura, lado, radio;

try
{
    Console.WriteLine("Elige una opcion: 1. Triangulo, 2. Cuadrado, 3. Circulo");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine("Ingrese la base del triangulo");
        basse = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del triangulo");
        altura = int.Parse(Console.ReadLine());
        triangulo = (basse * altura) / 2;
        Console.WriteLine("El area del triangulo es: " + triangulo);
    }
    else if (opcion == 2)
    {
        Console.WriteLine("Ingrese la medida del lado del cuadrado");
        lado = int.Parse(Console.ReadLine());
        cuadrado = lado * lado;
        Console.WriteLine("El area del cuadrado es: " + cuadrado);
    }
    else
    {
        Console.WriteLine("Ingrese el radio del circulo");
        radio = int.Parse(Console.ReadLine());
        circulo = (radio * radio) * 3.1416;
        Console.WriteLine("El area del circulo es: " + circulo);
    }
}
catch (Exception ex)
{
    Console.WriteLine("No ingresaste lo que se te solicito :(" + ex.Message);
}