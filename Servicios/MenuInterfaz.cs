using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogicaDeIgualdad.Servicios
{
    internal interface MenuInterfaz
    {
        ///<summary>
        /// Método de mensaje de Bienvenida a la calculadora
        /// 131023 - chi
        /// </summary>

        public void mensaje();



        ///<summary>
        /// Método de entrada a la calculadora
        /// 131023 - chi
        /// </summary>

        public int calculadora();

    }
}
