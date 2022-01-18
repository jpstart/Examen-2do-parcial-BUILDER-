using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_parcial
{
    //aqui creamos los tipos de helados con builders diferentes"
   public class HeladoAmericanoBuilder : HeladoBuilder
    {
        public HeladoAmericanoBuilder()
        {
            _descripcion = "Helado Americano";
        }
        public override Fruto BuildFruto()
        {
            return new Melon();
        }

        public override Crema BuildCrema()
        {
            return new Galleta();
        }

        public override Salsa BuildSalsa()
        {
            return new Mora();
        }
    }
}

