


Dictionary <int, string> empleados = new Dictionary<int, string>();


empleados.Add(1, "Carlso");
empleados.Add(2, "Anna");
empleados.Add(3, "Mateo");
empleados.Add(4, "Martin");


int codigo;
string nombre;

foreach (var item in empleados)
{
    Console.WriteLine(item);
}

Console.WriteLine("");


Console.WriteLine("Ingrese un codigo:  ");
codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el nuevo nombre: ");
nombre = Console.ReadLine();


empleados[codigo] = nombre;

foreach (var item in empleados)
{
    Console.WriteLine(item.Key + " " + item.Value);
}