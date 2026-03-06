


Dictionary <int , string> ciudades = new Dictionary<int , string> ();

ciudades.Add(1, "Xela");
ciudades.Add(2, "Quiche");
ciudades.Add(3, "Totonicapan");
ciudades.Add(4, "San antonio");
ciudades.Add(5, "Puerto barrios");

int codigo;

Console.Write("Ingrese una ciudad del 1 al 5: ");
codigo = int.Parse(Console.ReadLine());

if (ciudades.ContainsKey(codigo))
{
    Console.WriteLine("La ciudad es " + ciudades[codigo]);
}
else
{
    Console.WriteLine("La ciudad no existe");
}