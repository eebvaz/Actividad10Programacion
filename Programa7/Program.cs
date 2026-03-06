


using System.Numerics;

Dictionary <int, string> productos  = new Dictionary<int, string>();

productos.Add(1, "leche");
productos.Add(2, "pan");

int codigo;

Console.WriteLine("Ingrese un codigo para verificar: ");
codigo = int.Parse(Console.ReadLine());

if(!productos.ContainsKey(codigo))
{
    Console.WriteLine("Ingrese un nuevo producto: ");
}
else
{

    Console.WriteLine("El producto ya existe " + productos[codigo]);
}
