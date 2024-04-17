using APPGestionCuentasV2_FranGV.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGestionCuentasV2_FranGV.Agregar
{

    public enum OpcionesAgregar : byte { Salir, CuentaJoven, CuentaOro, CuentaPlatino }

    public static class ControladorAgregar
    {
        
        public static void ControladorA()
        {
            // Recursos
            string merror = "";
            bool esValido;
            OpcionesAgregar opcion = OpcionesAgregar.Salir;


            do {
                esValido = true;

                try { 

                switch (opcion)
                {
                    case OpcionesAgregar.Salir:
                        break;
                    case OpcionesAgregar.CuentaJoven:
                        break;
                    case OpcionesAgregar.CuentaOro:
                        break;
                    case OpcionesAgregar.CuentaPlatino:
                        break;
                }

                    }

                catch (Exception error)
                {
                    esValido = false;
                    merror = error.Message;
                }
                finally
                {
                    if (!esValido) Metodos.MostrarError(merror);
                }

            } while (!esValido || opcion == OpcionesAgregar.Salir);
        }

        
    }
}
