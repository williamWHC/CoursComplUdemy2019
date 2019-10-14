using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex39ClasseMetodosAtributosExemplo01
{
    class Triangulo
    {
        // É a definição do tipo
        public double A;
        public double B;
        public double C;

        //método da Class
        public double Area()
        {
            //calculando as medidas do triangulo, media dos valores
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;


        }
    }
}
