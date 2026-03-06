

Dictionary <int, string> estudiantes  = new Dictionary<int, string>();




int opcion=0;
string nombre;
int clave;

do
{
    Console.Clear();
    Console.WriteLine("Menu");
    Console.WriteLine("Opcion 1: Agregar");
    Console.WriteLine("Opcion 2: Mostrar");
    Console.WriteLine("Opcion 3: Salir");
    opcion = int.Parse(Console.ReadLine());


    switch(opcion)
    {
        case 1:

            Console.Clear();
            Console.WriteLine("Agregar estudiante");
            Console.Write("Ingrese Carnet: ");
            clave = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Nombre: ");
            nombre = Console.ReadLine();

            estudiantes.Add(clave, nombre);

            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Mostrar");

            foreach (var item in estudiantes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            break;

            default:
            Console.ReadKey();
            break;
    }

} while (opcion !=3);


