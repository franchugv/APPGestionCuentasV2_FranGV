using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGestionCuentasV2_FranGV.Principal
{
    public static class UIPrincipal
    {
        public static void MenuOpcionCuenta()
        {

            Console.Write("\nElija una Cuenta: ");
        }

        internal static void MenuPrincipal()
        {
            Console.WriteLine("\t- Menú Principal -");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Eliminar");
            Console.WriteLine("4. Consultar");
            Console.Write("\nElija una opción: ");

        }
    }
}
