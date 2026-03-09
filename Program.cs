int j;
int opcion;
for (int i = 1; i <= 5; i++)

{
    Console.Clear();
    Console.WriteLine("----MENU----");
    Console.WriteLine("1: Saludar ");
    Console.WriteLine("2. Mostrar numero de intentos");
    Console.WriteLine("3. Salir");
    Console.WriteLine("Ingrese una opcion: ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola, bienvenido al programa");
            Console.ReadLine();
            break;
        case 2:
            Console.Clear();
            string contraseña = "1234";
            string ingreso;
            int intentos = 3;
            for (j = 1; j <= intentos; j++)
            {
                Console.WriteLine("Ingrese la contraseña: ");
                ingreso = Console.ReadLine();
                if (ingreso == contraseña)
                {
                    Console.WriteLine("Contraseña correcta, bienvenido");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta, intente de nuevo");
                    Console.WriteLine($"Intentos restantes: {intentos - j}");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
            break;


        case 3:
            Console.WriteLine("Saliendo del programa...");
            Console.ReadLine();
            break;

        default:
            Console.WriteLine("Opcion no valida, intente de nuevo");
            Console.ReadLine();
            break;
    }
} Console.WriteLine("Se han agotado los intentos, saliendo del programa...");