

using static System.Runtime.InteropServices.JavaScript.JSType;

Dictionary<int, string> estudiantes = new Dictionary<int, string>();


int id;
int num;
for (int i = 1; i <= 3; i++)
{
    Console.Write("Ingrese el ID ");
    id = int.Parse(Console.ReadLine());
    //Console.WriteLine("");
    Console.Write("Ingrese el nombre del estudiante");
    string nombre = Console.ReadLine();

    estudiantes.Add(id, nombre);
}

Console.Clear();
Console.Write("Ingrese el ID del estudiante que desea buscar: ");
num = int.Parse(Console.ReadLine());
if (num != estudiantes.Count)
{
    Console.Write("No se ha encontrado el usuario");
}
else
{
    Console.Write("Se ha encontrado: " + estudiantes);
}


