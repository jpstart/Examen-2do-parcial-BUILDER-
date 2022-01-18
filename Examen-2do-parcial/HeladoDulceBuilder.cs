using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_parcial
{
    public class HeladoDulceBuilder : HeladoBuilder
    {
        public HeladoDulceBuilder()
        {
            _descripcion = "Helado muy dulce";
        }
        public override Fruto BuildFruto()
        {
            return new Sandia();
        }

        public override Crema BuildCrema()
        {
            return new Yogurt();
        }

        public override Salsa BuildSalsa()
        {
            return new Derretido();
        }
    }
}
