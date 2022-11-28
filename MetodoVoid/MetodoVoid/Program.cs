using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoVoid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EscribeAlgo();
            EscribeAlgoEspecifico("Soy un argumento y me llamaron y me llamaron desde el metodo Main");
        }


        //nivel de acceso - Static - tipoRetorno - Nombre del metodo - parametros
        public static void EscribeAlgo()
        {
            Console.WriteLine("Hello world");
        }

        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
        }
    }
}
