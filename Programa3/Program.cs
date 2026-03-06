


using System.Collections;
using System.Runtime.CompilerServices;

Dictionary <string , double> estudiantes = new Dictionary<string , double>();

string alumnos;
double nota;
int cantidad = 0;

Console.WriteLine("");

Console.Write("Ingrese la cantidad de alumnos que desea añadir: ");
cantidad = int.Parse(Console.ReadLine());

for (int i = 1; i <= cantidad; i++) 
{
    Console.Write("Ingrese el nombre del alumno: ");
    alumnos = Console.ReadLine();
    Console.Write("Ingrese la nota del ");
    nota = double.Parse(Console.ReadLine());

    estudiantes.Add(alumnos, nota);   
}

Console.Clear();

Console.WriteLine("Ingrese el nombre del alumno que desea ver su nota");
Console.Write("Nombre: ");
alumnos = Console.ReadLine();

if (estudiantes.ContainsKey(alumnos))
{
    Console.WriteLine("La nota de" + alumnos + " es de " + estudiantes[alumnos]);
}
else
{
    Console.WriteLine("No existe el estudiante");
}