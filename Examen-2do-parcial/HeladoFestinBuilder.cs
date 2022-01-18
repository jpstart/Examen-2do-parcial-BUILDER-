using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_parcial
{
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
