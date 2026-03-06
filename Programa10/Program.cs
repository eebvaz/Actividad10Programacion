


Dictionary <int , string> inventario = new Dictionary <int , string> ();

inventario.Add(1, "Pimienta");
inventario.Add(2, "Sal");
inventario.Add(3, "Chile");
inventario.Add(4, "Ajo");
inventario.Add(5, "Agua");

int codigo;


foreach (var item in inventario) 
    {
    Console.WriteLine(item);
}

Console.WriteLine("");

Console.WriteLine("Ingrese el codigo del podructo");
codigo = int.Parse(Console.ReadLine());
if (inventario.ContainsKey(codigo))
{
    Console.WriteLine("Desea eliminarlo");
    string opcion = Console.ReadLine();

    if(opcion =="si" || opcion == "SI")
    {
        inventario.Remove(codigo);
    }
    else
    {
        return;
    }
}
else
{
    Console.WriteLine("No existe");
}


Console.Clear();

foreach (var item in inventario)
{
    Console.WriteLine(item);
}
