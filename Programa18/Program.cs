



Dictionary <string, string>  nombres  = new Dictionary<string, string>();

nombres.Add("Ana","123");
nombres.Add("Anny","456");

int num=0;
string usuario, contrasena;


Console.WriteLine("Ingrese un usuario: ");
usuario = Console.ReadLine();

    if (!nombres.ContainsKey(usuario))
    {
        Console.WriteLine("Contraseña: ");
        contrasena = Console.ReadLine();

        nombres.Add(usuario, contrasena);

    }
    else
    {
        Console.WriteLine("Ya existe");
    }

