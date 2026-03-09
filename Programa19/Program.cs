


Dictionary <string, double> estudiante = new Dictionary<string, double>();


int opcion =0;

string nombre;
double nota;
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

            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la nota: ");
            nota = double.Parse(Console.ReadLine());

            estudiante[nombre]= nota;
            Console.ReadKey();
            break;

            case 2:
            Console.WriteLine("Modificar");
            nombre = Console.ReadLine();
            Console.WriteLine("");


            if(opcion == 1)
            {
                Console.WriteLine("ingrese un nueva nota: ");

                estudiante[nombre] = double.Parse(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Estudiante no existe");
            }
               

            Console.ReadKey();
            break;

            case 3:
            Console.WriteLine("Mostrar");

            foreach (var item in estudiante)
            {
                Console.WriteLine(item.Key+"  : "+ item.Value);
            }

            Console.ReadKey();
            break;

        default:

            break;
    }



} while (opcion !=4);
