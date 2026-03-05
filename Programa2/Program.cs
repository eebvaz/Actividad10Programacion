

using static System.Runtime.InteropServices.JavaScript.JSType;

Dictionary<int, string> productos = new Dictionary<int, string>();


int codigo,cantidad=0;
string nombre;


Console.WriteLine("Cantidad de productos: ");
cantidad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el codigo de producto y su nombre");
for (int i = 1; i <= cantidad; i++)
{
    Console.Write("Codigo: "); codigo = int.Parse(Console.ReadLine());
    Console.Write("Nombre: "); nombre = Console.ReadLine();
    productos.Add(codigo, nombre);
}

foreach (var item in productos)
{
    Console.WriteLine(item);
}

         

