using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex39ClasseMetodosAtributosExemploPlatico
{
    class Triangulo
    {
        //Entrada da Class
        public double A;
        public double B;
        public double C;

        //método que calcula as medidas
        public double Area()
        {
            //divide os 3 lados por 2
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }


    }
}
