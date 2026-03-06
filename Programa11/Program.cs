


Dictionary <int, string> estudiantes  = new Dictionary<int, string>();

estudiantes.Add(1, "Maria");
estudiantes.Add(2, "Luis");
estudiantes.Add(3, "Carlos");
estudiantes.Add(4, "Marcos");
estudiantes.Add(5, "Adrina");

foreach (var item in estudiantes)
{
    Console.WriteLine("Estudiante: "+item.Value+ " Clave; "+ item.Key);
}
