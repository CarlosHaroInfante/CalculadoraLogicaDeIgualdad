using CalculadoraLogicaDeIgualdad.Servicios;


/// <summary>
/// Clase principal del programa
/// 131023 - chi
/// </summary>

class Program
{
    ///<summary>
    /// Método de entrada a la app
    /// 131023 - chi
    /// </summary>

    static void Main(string[] args)
    {
        MenuInterfaz hola = new MenuImplementacion();
        hola.mensaje();



        //Entrada al bucle

        bool cerrarMenu = false;

        //Opción elegida por el user

        int opcionElegida;

        //Bucle de la calculdadora

        while(!cerrarMenu)
        {
            opcionElegida = hola.calculadora();
            Console.WriteLine(opcionElegida);

            string opcion1, opcion2;


            switch (opcionElegida)
            {

                case 0:
                    Console.WriteLine("[INFO] - Se cerrará el programa");
                    cerrarMenu = true;
                    break;

                case 1:
                    Console.WriteLine("[INFO] - Se igualará");
                    Console.WriteLine("Escoge una palabra");
                    opcion1 = Console.ReadLine();
                    Console.WriteLine("Has elegido: " + opcion1);
                    Console.WriteLine("Escoge otra palabra");
                    opcion2 = Console.ReadLine();
                    Console.WriteLine("Has elegido: " + opcion2);
                    Console.WriteLine(opcion1 == opcion2);
                    break;

                case 2:
                    Console.WriteLine("[INFO] - Se desigualará");
                    Console.WriteLine("Escoge una palabra");
                    opcion1 = Console.ReadLine();
                    Console.WriteLine("Has elegido: " + opcion1);
                    Console.WriteLine("Escoge otra palabra");
                    opcion2 = Console.ReadLine();
                    Console.WriteLine("Has elegido: " + opcion2);
                    Console.WriteLine(opcion1 != opcion2);
                    break;

                default:
                    Console.WriteLine("[INFO] - No coincide con ninguna opción");
                    break;
            }
        }
    }

}
