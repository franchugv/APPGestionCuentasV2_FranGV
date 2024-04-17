using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGestionCuentasV2_FranGV.Principal
{
    public static class Metodos
    {
        public static byte CaptarOpcionEnum(int NumOpciones)
        {
            // Recursos
            byte opcion = 0;
            string aux = "";

            aux = Console.ReadLine();

            if (string.IsNullOrEmpty(aux)) throw new CadenaVaciaException();

            opcion = Convert.ToByte(aux);

            if (opcion >= NumOpciones) throw new OverflowException();

            return opcion;
        }

        public static void MostrarError(string error)
        {
            Console.WriteLine($"Error: {error}");
            Console.Write("\nPulse Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public static string CaptarCadena()
        {
            // Recursos
            string cadena = "";
            bool esValido;
            string merror = "";

            do
            {
                esValido = true;

                try
                {
                    cadena = Console.ReadLine();
                    if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaException();                    
                }
                catch (Exception Error)
                {
                    esValido = false;
                    merror = Error.Message;
                }
                finally
                {
                    if (!esValido) MostrarError(merror);
                }
            }while (!esValido);

            return cadena;
        }


        public static int CaptarInt()
        {
            // Recursos
            string aux = "";
            int dato = 0;
            bool esValido;
            string merror = "";

            do
            {
                esValido = true;

                try
                {
                    aux = Console.ReadLine();
                    dato = Convert.ToInt32(aux);

                    if (string.IsNullOrEmpty(aux)) throw new CadenaVaciaException();
                }
                catch (Exception Error)
                {
                    esValido = false;
                    merror = Error.Message;
                }
                finally
                {
                    if (!esValido) MostrarError(merror);
                }
            } while (!esValido);

            return dato;
        }
    }
    public class CadenaVaciaException : Exception
    {
        public CadenaVaciaException() :base("Cadena vacía") { }
        public CadenaVaciaException(string message) : base(message) { }
    }
}
