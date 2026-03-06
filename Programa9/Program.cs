



Dictionary <string, double> estudiantes = new Dictionary<string, double>();

estudiantes.Add("Martin", 54);
estudiantes.Add("Laura", 60);
estudiantes.Add("Mario", 34);
estudiantes.Add("Luis", 66);
estudiantes.Add("Jorgito", 85);


string nombre;

Console.WriteLine("Ingrese el nombre del estudiante: ");
nombre  = Console.ReadLine();

if (estudiantes.ContainsKey(nombre))
{
    Console.WriteLine("Existe");
    Console.WriteLine("Nombre: "+nombre+" Nota: "+ estudiantes[nombre] );
}
else
{

    Console.WriteLine("No existe");

}