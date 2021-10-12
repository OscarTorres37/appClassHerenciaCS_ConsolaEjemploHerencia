using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaCS_Consola
{
    class Punto3D : Punto2D
    {
        private double z;

        public double M
        {
            get { return z; }
            set { z = value; }
        }
        public Punto3D() : base()
        {

            z = 0;

        }

        public Punto3D(double y, double z) : base()
        {

            this.z = z;

        }

        public double Distancia(Punto3D p)
        {
            double d = 0;
            d = z - p.z; // Valor Absoluto
            return d;
        }
        public override string ToString()
        {
            return base.ToString() + " Z=" + z;
        }
    }
}
