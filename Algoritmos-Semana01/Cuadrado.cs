using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Semana01
{
    public class Cuadrado
    {
        public double lado;
        public double perimetro;
        public double area;

        public Cuadrado(double lado)
        {
            this.lado = lado;
            perimetro = lado*4;
            area = lado*lado;
        }

        override
        public string ToString()
        {
            string msj = "";
            msj += "El valor del perimetro del cuadrado es:" + perimetro + Environment.NewLine;
            msj += "El valor del area del cuadrado es:" + area + Environment.NewLine;

            return msj;

        }
    }
}
