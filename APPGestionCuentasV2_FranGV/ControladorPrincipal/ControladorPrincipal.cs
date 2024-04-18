using APPGestionCuentasV2_FranGV.Agregar;
using APPGestionCuentasV2_FranGV.Principal;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGestionCuentasV2_FranGV.ControladorPrincipal
{
    public enum OpcionesPrincipal : byte { Salir, Agregar, Eliminar, Modificar, Consultar }
    
    public class ControladorPrincipal
    {

        public static void ControladorP(List<Cuenta> ListaC)
        {
            // Recursos
            bool esValido;
            int OpcionCuenta = 0;
            string merror = "";
            OpcionesPrincipal Opcion = OpcionesPrincipal.Salir;

            do
            {
                esValido = true;

                UIPrincipal.MenuPrincipal();
                try
                {
                    Opcion = (OpcionesPrincipal)Metodos.CaptarOpcionEnum((byte)Enum.GetValues<OpcionesPrincipal>().Length);

                    if (Opcion != OpcionesPrincipal.Agregar) 
                    { 
                    UIPrincipal.MenuOpcionCuenta();
                    OpcionCuenta = Metodos.CaptarInt();
                    }

                    switch (Opcion)
                    {
                        case OpcionesPrincipal.Salir:
                            break;
                        case OpcionesPrincipal.Agregar:
                            ControladorAgregar.ControladorA(ListaC);
                            break;
                        case OpcionesPrincipal.Eliminar:
                            break;
                        case OpcionesPrincipal.Modificar:
                            break;
                        case OpcionesPrincipal.Consultar:
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
            } while (!esValido || Opcion != OpcionesPrincipal.Salir);
        }

    }
}
