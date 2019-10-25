using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorDeParametrosParams
{
    class Calculator
    {
        //função
        //Params = avisa a função que quermos uma quantidade variada de valores de entrada
        public static int Sun(params int[] numbers)
        {
            int soma = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                soma += numbers[i];
            }
            return soma;

        }
    }
}
