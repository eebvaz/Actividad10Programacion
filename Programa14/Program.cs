


Dictionary <int, string> ciudades  = new Dictionary<int, string>();

ciudades.Add(3, "Cayala");
ciudades.Add(2, "Capital");
ciudades.Add(5, "Puerto san jose");
ciudades.Add(6, "Villa nueva");
ciudades.Add(1, "Mixco");
ciudades.Add(4, "Tototnicapan");


foreach  (var item in ciudades)
{
    Console.Write("  Codigos: "+item.Key);
}
Console.WriteLine("");
foreach (var item in ciudades)
{
    Console.Write("  Ciudades: " + item.Value);
}