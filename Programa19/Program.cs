


Dictionary <string, double> estudiante = new Dictionary<string, double>();


int opcion =0;


do
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Añadir");
    Console.WriteLine("2. Modificar");
    Console.WriteLine("3. Mostrar");
    Console.WriteLine("4. Salir");
    opcion = int.Parse(Console.ReadLine());
 
    switch(opcion)

    {

        case 1:
            Console.WriteLine("Añadir");



            Console.ReadKey();
            break;

            case 2:
            Console.WriteLine("Modificar");



            Console.ReadKey();
            break;

            case 3:
            Console.WriteLine("Mostrar");



            Console.ReadKey();
            break;

        default:

            break;
    }



} while (opcion !=4);
