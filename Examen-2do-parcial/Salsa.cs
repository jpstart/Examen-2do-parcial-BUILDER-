using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_parcial
{//tipos de salsas//
    public abstract class Salsa
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }
    public class Chocolate : Salsa
    {
        public Chocolate()
        {
            _descripcion = "Salsa de Chocolate clásico";
        }
    }

    public class Derretido : Salsa
    {
        public Derretido()
        {
            _descripcion = "Salsa de chocolate derretido";
        }
    }

    public class Mora : Salsa
    {
        public Mora()
        {
            _descripcion = "Salsa de estracto de mora";
        }
    }


    public class Manjar : Salsa
    {
        public Manjar()
        {
            _descripcion = "Salsa dulce de manjar";
        }
    }
}
