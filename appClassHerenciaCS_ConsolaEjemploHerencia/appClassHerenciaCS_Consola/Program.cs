using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaCS_Consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Punto2D a;
      a = new Punto2D(98,76);
      Console.WriteLine(a.ToString());

      Punto a2;
      a2 = new Punto(5.99);

      Console.WriteLine(a2.ToString());

            Punto3D b;
            b = new Punto3D(99, 78);
            Console.WriteLine(b.ToString());

            Punto b2;
            b2 = new Punto(7.89);
            Console.WriteLine(b2.ToString());



      Console.ReadKey();



    }
  }
}
