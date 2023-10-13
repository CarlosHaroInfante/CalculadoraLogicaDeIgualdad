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

    public void Main(string[] args)
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

            string opcion1, opcion2, resultado;


            switch (opcionElegida)
            {

                case 0:
                    Console.WriteLine("[INFO] - Se cerrará el programa");
                    cerrarMenu = true;
                    break;

                case 1:
                    Console.WriteLine("[INFO] - Se igualará");
                    Console.WriteLine("Escoge una palabra");
                    Console.WriteLine("Has elegido: " + opcion1);
                    Console.WriteLine("Escoge otra palabra");
                    opcion2 = Parse(Console.ReadLine());
                    Console.WriteLine("Has elegido: " + opcion2);
                    Console.WriteLine(opcion1 == opcion2);
                    break;

                case 2:
                    Console.WriteLine("[INFO] - Se desigualará");
                    Console.WriteLine("Escoge un número");
                    opcion1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Has elegido: " + opcion1);
                    Console.WriteLine("Escoge otro número");
                    opcion2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Has elegido: " + opcion2);
                    resultado = opcion1 - opcion2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;

                default:
                    Console.WriteLine("[INFO] - No coincide con ninguna opción");
                    break;
            }
        }
    }

}
