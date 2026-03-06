

Dictionary <int, string> productos  = new Dictionary <int, string> ();

productos.Add(10, "Maiz");
productos.Add(11, "Calabaza");
productos.Add(12, "Caña");
productos.Add(13, "Paja");
productos.Add(14, "Trigo");
productos.Add(15, "Arroz");


foreach (var item in productos)
{
    Console.WriteLine("codigo: "+item.Key +  " producto: "+item.Value);
}






