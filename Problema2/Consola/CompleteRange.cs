using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
   public static class CompleteRange
    {



       public static string build(string parametroEntrada){
           string salida = "";
           int maximo = 0;
           parametroEntrada=parametroEntrada.Replace("[","");
           parametroEntrada=parametroEntrada.Replace("]","");

           string[] numeros=parametroEntrada.Split(',');

           try
           {

               foreach(string numero in numeros){

                   int n = Convert.ToInt32(numero);
                   if (maximo < n)
                       maximo = n;



               }

               int[] numerosArray = new int[maximo];
               for (int i = 0; i < maximo;i++ )
               {
                   numerosArray[i] =  i + 1;
               }


               salida="["+string.Join(",", numerosArray)+"]";

               return salida;
           }
           catch (Exception e)
           {
               return "error encontrado";
           }

         
       }
    }
}
