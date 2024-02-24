string usuario = "blanky";
string contrasena = "F@rmac1a";

try
{
    Console.WriteLine("ingresa el usuario");
    usuario = Console.ReadLine();
    Console.WriteLine("ingresa tu contrasena");
    contrasena = Console.ReadLine();

    if (usuario == "blanky" && contrasena == "F@rmac1a")
    {
        Console.WriteLine("Inicio de sesion exitoso");
    }
    else
    {
        Console.WriteLine("Usuario o contrasena incorrecto");
    }
}
catch (Exception ex)
{
    Console.WriteLine("No ingresaste lo que se te solicito :(" + ex.Message);
}