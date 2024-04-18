using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGestionCuentasV2_FranGV.Agregar
{
    public static class UIACuentas
    {
        public static void MenuATitular()
        {
            Console.Write("\nEscriba el nombre del Titular: ");
        }

        internal static void MenuFechaNac()
        {
            Console.Write("\nEscriba su Fecha de nacimiento (Y,M,D): ");
        }

        internal static void MenuIngresarCantidad()
        {
            Console.Write("\nEscriba la Cantidad a Ingresar: ");
        }

        internal static void MenuNumCuenta()
        {
            Console.Write("\nEscriba su Número de Cuenta (20 dígitos): ");
        }

        internal static void MenuRetirarCantidad()
        {
            Console.Write("\nEscriba la Cantidad a Retirar: ");
        }
    }
}
