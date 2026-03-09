int j;
int opcion;
    for (int i = 1; i <= 5; i++)
    {
        Console.Clear();
        Console.WriteLine("----- MENÚ -----");
        Console.WriteLine("1. Saludar");
        Console.WriteLine("2. Ingresar contraseña");
        Console.WriteLine("3. Salir");
        Console.Write("Elija una opción: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Hola, bienvenido al sistema.");
                Console.ReadLine();
                break;

            case 2:
                Console.Clear();
                string contraseña = "1234";
                string ingreso;
                int intentos = 3;

                for (j = 1; j <= intentos; j++)
                {
                    Console.Write("Ingrese la contraseña: ");
                    ingreso = Console.ReadLine();

                    if (ingreso == contraseña)
                    {
                        Console.WriteLine("Contraseña correcta. Acceso permitido.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Contraseña incorrecta.");
                        Console.WriteLine("Intentos restantes: " + (intentos - j));
                    }
                }

                Console.WriteLine("Presione Enter para volver al menú");
                Console.ReadLine();
                break;

            case 3:
                Console.WriteLine("Saliendo...");
                Console.ReadLine();
                return;

            default:
                Console.WriteLine("Opción no válida.");
                Console.ReadLine();
                break;
        }
    }

