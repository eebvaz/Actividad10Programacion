


Dictionary <int, string> empleados = new Dictionary<int, string>();

empleados.Add(01, "Pedro");
empleados.Add(02, "Anny");
empleados.Add(03, "Camila");
empleados.Add(04, "Pual");
empleados.Add(05, "Saul");


foreach  (var item in empleados)
{

    Console.WriteLine("ID;____"+item.Key+ "___"+"Nombre:___"+item.Value+"____");
}