
Dictionary<string,(string, int , string)> estudiante = new Dictionary<string, (string, int, string)>();


int opcion = 0;
int cantidad, edad;
string nombre, carrera, carnet;
do
{
    Console.Clear();
    Console.WriteLine("Menu");
    Console.WriteLine("1. Añadir");
    Console.WriteLine("2. Mostrar");
    Console.WriteLine("3. Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)

    {

        case 1:
            Console.WriteLine("Añadir");

            
            for (int i = 1; i <=3; i++)

            {
                Console.Clear();
                Console.WriteLine("Ingrese su carnet: ");
                carnet = Console.ReadLine();
             
            Console.WriteLine("Ingrese un nombre: ");
                nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su carrera: ");
                carrera = Console.ReadLine();


                estudiante.Add(carnet, (nombre, edad, carrera));
            }


            Console.ReadKey();
            break;

 

        case 2:
            Console.Clear();  Console.WriteLine("Mostrar");

            foreach (var item in estudiante)
            {
                Console.WriteLine("Carné: " + item.Key);
                Console.WriteLine("Nombre: " + item.Value.Item1);
                Console.WriteLine("Edad: " + item.Value.Item2);
                Console.WriteLine("Carrera: " + item.Value.Item3);
                Console.WriteLine();
            }

            Console.ReadKey();
            break;

        default:

            break;
    }



} while (opcion != 3);