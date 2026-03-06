

Dictionary <string, string> constrasena = new Dictionary<string, string>();

string usuario;
string contra;



for (int i = 1; i <= 3; i++)
{
Console.Write("Ingrese un usuario: ");
usuario = Console.ReadLine();
Console.Write("Ingrese una constraseña: ");
contra = Console.ReadLine();

  constrasena.Add(usuario, contra);
}

Console.Clear();

Console.Write("Ingrese su usuario: ");
usuario = Console.ReadLine();


if (constrasena.ContainsKey(usuario))
{
    Console.Write("Usuario correcto");
    Console.Write("Ingrese su constrasela: ");
    contra = Console.ReadLine();

    if (constrasena.ContainsKey(contra))
    {
        Console.Write("Contraseña correcta");
    }
    else
    {
        Console.Write("Contraseña incorrecta");
    }

}
else
{
    Console.Write("No existe ese usuario");
}


