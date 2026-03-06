

Dictionary <int, string> productos = new Dictionary<int, string>();


int opcion=0;
int codigo;
string nombre;

do
{
    Console.Clear();
    Console.WriteLine("Menu");
    Console.WriteLine("Opcion 1: Agregar");
    Console.WriteLine("Opcion 2: Eliminar");
    Console.WriteLine("Opcion 3; Mostrar");
    Console.WriteLine("Opcion 4: Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:

            Console.Clear();
            Console.WriteLine("Agregar producto");
            Console.Write("Ingrese el codigo: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del producto: ");
            nombre = Console.ReadLine();

            productos.Add(codigo, nombre);
            Console.ReadKey();  
            break;



       case 2:
            Console.Clear();
            Console.WriteLine("Eliminar producto");
            Console.Write("Ingrese el codigo: ");
            codigo = int.Parse(Console.ReadLine());

            if(productos.ContainsKey(codigo))
            {
                Console.WriteLine("Desea borrarlo");
                string dato = Console.ReadLine();

                if (dato =="si" || dato == "SI")
                {
                    Console.WriteLine("Se ha eliminado");
                    productos.Remove(codigo);
                }
                else
                {
                    Console.WriteLine("Por favor regrese al menu");
                }

            }
            else 
            {
                Console.WriteLine("No existe");
            }

            Console.ReadKey();
            break;
       case 3:
            Console.Clear();
            Console.WriteLine("Mostrar");

            foreach (var item in productos)
            {

                Console.WriteLine(item); 
            }    

            Console.ReadKey();
            break;

        default:
            break;
    }


} while (opcion !=4);