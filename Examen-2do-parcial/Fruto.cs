using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen_2do_parcial
{
    public abstract class Fruto
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }
    public class Melon : Fruto
    {
      public Melon ()
        {
            _descripcion = "Melon fresco";
        }
    }
    public class Sandia : Fruto
    {
        public Sandia()
        {
            _descripcion = "Sandia dulce";
        }
    }
    public class Mango : Fruto
    {
        public Mango()
        {
            _descripcion = "Mango Maduro";
        }
    }
}

