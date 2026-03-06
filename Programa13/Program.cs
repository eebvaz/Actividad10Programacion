


Dictionary <string , double> estudiantes  = new Dictionary<string , double>();

estudiantes.Add("Ana",12);
estudiantes.Add("Anita",54);
estudiantes.Add("Lupe",76);
estudiantes.Add("Laura",79);
estudiantes.Add("Carlos",40);
estudiantes.Add("Manuel",100);
estudiantes.Add("Pedro",34);


double total;
double suma =0;

foreach (var item in estudiantes)
{
   suma += item.Value;
}

total = suma/estudiantes.Count;

Console.WriteLine("El promedio es: "+ total);
