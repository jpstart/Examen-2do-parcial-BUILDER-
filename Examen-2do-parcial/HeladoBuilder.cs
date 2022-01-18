using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_parcial
{
    public abstract class HeladoBuilder
    {
        protected string _descripcion;
        public abstract Crema BuildCrema();
        public abstract Salsa BuildSalsa();
        public abstract Fruto BuildFruto();

        public override string ToString()
        {
            return _descripcion;
        }
        public Helado BuildHelado()
        {
            Crema crema = BuildCrema();
            Salsa salsa = BuildSalsa();
            Fruto fruto = BuildFruto();

            return new Helado(crema, salsa, fruto, _descripcion);
        }
    }
}