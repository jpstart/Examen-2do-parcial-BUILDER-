using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_parcial
{
  class MenuH
    {
        static void Main(string[] args)
        {


            //MENU DE OPCIONES DE LA HELADERIA//
            double a, b, c, d;
            int opcion;
            Console.WriteLine("Menu de la heladeria");
            Console.WriteLine("Escoga la opción");
            Console.WriteLine("1. HELADO AMERICANO");
            Console.WriteLine("2. HELADO DULCE");
            Console.WriteLine("3. HELADO FESTIN");
            Console.WriteLine("4. HELADO TROPICAL");
            Console.WriteLine("0. SALIR");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch(opcion)
            {
                case 1: Console.WriteLine("Ha escogido el Helado Americano, Este helado está compuesto por los siguientes ingredientes:Fruto: Melon, Crema: Galleta Salsa: Mora ");
                    a = Convert.ToDouble(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Ha escogido el Helado Dulce, Este helado está compuesto por los siguientes ingredientes:Fruto: Sandia, Crema: Ypgurt Salsa: Derretido ");
                    b = Convert.ToDouble(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Ha escogido el Helado Festin, Este helado está compuesto por los siguientes ingredientes:Fruto: Melon, Crema: Yogurt Salsa: Manjar ");
                    c = Convert.ToDouble(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Ha escogido el Helado Tropical, Este helado está compuesto por los siguientes ingredientes:Fruto: Mango, Crema: Natural Salsa: Manjar ");
                    d = Convert.ToDouble(Console.ReadLine());
                    break;
                case 0:
                    Console.WriteLine("ADIOS, GRACIAS");
                    break;
                    default: Console.WriteLine("Ha Ingresado un valor incorrecto");
                    break;
            }
            Console.ReadKey();
        }


    }
}
