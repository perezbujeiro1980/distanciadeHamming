using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistanciaDeHamming
{
    class Program
    {
        static void Main(string[] args)
        {
            //La distancia Hamming entre 1011101 y 1001001 es 2.
            //La distancia Hamming entre 2143896 y 2233796 es 3.
            //La distancia Hamming entre "tener" y "reses" es 3.

           // 1011101
           // 1001001
           //   x  x

             //2143896
             //2233796
             //   xx x  


            string cadena = "tener";
            string cadena2 = "resxs";            
            int distancia = 0;

            /*
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] != cadena2[i])                
                  distancia++;
            }
            */

            int index = 0;
            foreach (var item in cadena)
            {
                if (item != cadena2[index]) {
                    distancia++;
                }

                index++;                
            }

            Console.Write(distancia);
            Console.ReadKey();
        }
    }
}
