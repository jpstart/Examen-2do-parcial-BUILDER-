using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_parcial
{
    public class HeladoTropicalBuilder : HeladoBuilder
    {
        public HeladoTropicalBuilder()
        {
            _descripcion = "Helado con un fresco tropical";
        }
        public override Fruto BuildFruto()
        {
            return new Mango();
        }

        public override Crema BuildCrema()
        {
            return new Natural();
        }

        public override Salsa BuildSalsa()
        {
            return new Manjar();
        }
    }
}