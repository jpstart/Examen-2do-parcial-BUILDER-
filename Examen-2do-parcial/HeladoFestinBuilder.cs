using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_parcial
{
    //Otro tipo de helado construido usando el Builder
    public class HeladoFestinBuilder : HeladoBuilder
    {
        public HeladoFestinBuilder()
        {
            _descripcion = "Helado Festin de muchos colores";
        }
        public override Fruto BuildFruto()
        {
            return new Melon();
        }

        public override Crema BuildCrema()
        {
            return new Yogurt();
        }

        public override Salsa BuildSalsa()
        {
            return new Manjar();
        }
    }
}
