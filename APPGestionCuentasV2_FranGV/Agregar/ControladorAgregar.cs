using APPGestionCuentasV2_FranGV.Principal;
using R24_JesusCG_V1;
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
        
        public static void ControladorA(List<Cuenta> ListaCu)
        {
            // Recursos
            string merror = "";
            bool esValido;
            OpcionesAgregar opcion = OpcionesAgregar.Salir;


            do {
                esValido = true;

                try {

                    MetodosAgregar.CaptarDatosCuenta(ListaCu);

                switch (opcion)
                {
                    case OpcionesAgregar.Salir:
                        break;
                    case OpcionesAgregar.CuentaJoven:
                            MetodosAgregar.AgregarCuentaJoven(ListaCu);
                        break;
                    case OpcionesAgregar.CuentaOro:
                            MetodosAgregar.AgregarCuentaOro(ListaCu);
                        break;
                    case OpcionesAgregar.CuentaPlatino:
                            MetodosAgregar.AgregarCuentaPlatino(ListaCu);
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
