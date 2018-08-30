using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_6_funcoes
{
    class Program
    {

        // PascalCase
        // camelCase
        // under_line

        public static int CalcularSoma()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        public static void MostrarMsgNaTela()
        {
            Console.WriteLine("Mostrando na tela !");
        }

        public static void Tabuada(int numero)
        {
            Console.WriteLine("Tabuada do número : " + (numero));

            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        static void Main(string[] args)
        {
            int retorno = CalcularSoma();
            Console.WriteLine(retorno);

            MostrarMsgNaTela();

            Tabuada(7);
            Tabuada(98);


            Console.Read();
             
        }
    }
}
