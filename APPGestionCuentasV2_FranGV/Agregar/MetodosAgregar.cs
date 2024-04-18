using APPGestionCuentasV2_FranGV.Principal;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGestionCuentasV2_FranGV.Agregar
{
    public static class MetodosAgregar
    {

        public static Cuenta CaptarDatosCuenta(List<Cuenta> ListaCu)
        {
            // Recursos 
            bool esValido;
            string merror = "";

            do
            {
                esValido = true;

                try
                {


                    UIACuentas.MenuATitular();
                    Cuenta.Titular = Metodos.CaptarCadena();
                    Metodos.Pausa();


                    UIACuentas.MenuIngresarCantidad();
                    Cuenta.Ingresar(Metodos.CaptarDouble());
                    Metodos.Pausa();


                    UIACuentas.MenuRetirarCantidad();
                    Cuenta.Retirar(Metodos.CaptarDouble());
                    Metodos.Pausa();


                    UIACuentas.MenuFechaNac();
                    Cuenta.FechaNacimiento = Metodos.CaptarFecha();
                    Metodos.Pausa();

                    UIACuentas.MenuNumCuenta();
                    Cuenta.NumCuenta = Metodos.CaptarCadena();
                    Metodos.Pausa();

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
            }
            while (!esValido);
            
            return Cuenta;

        }

        public static void AgregarCuentaJoven(List<Cuenta> ListaCu)
        {            
            if (ListaCu is CuentaJoven)
            {
               ListaCu.Add(new CuentaJoven(Cuenta.Titular, Cuenta.Cantidad, Cuenta.FechaNacimiento, Cuenta.NumCuenta));
            }
        }

        public static void AgregarCuentaOro(Cuenta Cuenta)
        {    
            if (Cuenta is CuentaOro)
            {
                ListaCu CuentaNueva = new CuentaOro(Cuenta.Titular, Cuenta.Cantidad, Cuenta.FechaNacimiento, Cuenta.NumCuenta);
            }
        }

        public static void AgregarCuentaPlatino(Cuenta Cuenta)
        {
     
            if (Cuenta is CuentaPlatino)
            {
                ListaCu CuentaNueva = new CuentaPlatino(Cuenta.Titular, Cuenta.Cantidad, Cuenta.FechaNacimiento, Cuenta.NumCuenta);
            }
        }


    }
}
