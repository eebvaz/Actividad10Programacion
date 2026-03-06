


Dictionary <int ,string> estudiantes = new Dictionary<int ,string>();


estudiantes.Add(1, "Mario");
estudiantes.Add(2, "Anni");
estudiantes.Add(3, "Pablo");

int codigo;

Console.WriteLine("Ingrese el codigo del alumno a eliminar: ");
codigo = int.Parse(Console.ReadLine());

estudiantes.Remove(codigo);

foreach  (var itema in estudiantes)
{
    Console.WriteLine(itema);
}