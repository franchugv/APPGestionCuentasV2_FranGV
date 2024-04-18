using R24_JesusCG_V1;

namespace APPGestionCuentasV2_FranGV
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // RECURSOS

            List<Cuenta> ListaCuentas = new List<Cuenta>();

            ControladorPrincipal.ControladorPrincipal.ControladorP(ListaCuentas);

        }
    }
}
