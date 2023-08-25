using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex1
{
    internal class Quadrado
    {

        private double l;
        private double a;
    

        public void setl(double q)
        {
            l = q;

        }
        public void seta(double q)
        {
            l = q;

        }

        public double getl()
        {
            return l;
        }

        public double geta()
        {
            return a;
        }

        public void calcular()
        {
            a = l * l;
        }


    }

}