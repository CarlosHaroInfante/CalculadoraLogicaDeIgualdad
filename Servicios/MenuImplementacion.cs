using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogicaDeIgualdad.Servicios
{
    internal class MenuImplementacion : MenuInterfaz //conecto los servicios
    {
        //mensaje de Bienvenida

        public void mensaje()
        {
            string mensaje = "Bienvenido a la calculadora lógica";
            Console.WriteLine(mensaje);
        }

        //Menú de la calculadora

        public void calculadora()
        {
            int opcionElegida;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("0. Cerrar");
            Console.WriteLine("1. Igualdad");
            Console.WriteLine("2. Desigualdad");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Seleccione una opcion: ");


        }
    }
}
