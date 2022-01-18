using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_parcial
{
    public abstract class Crema
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }
    public class Natural : Crema
    {
        public Natural()
        {
            _descripcion = "Crema natural sin colorantes";
        }
    }

    public class Yogurt : Crema
    {
        public Yogurt()
        {
            _descripcion = "Crema de yogurt con sabor a vainilla";
        }
    }

    public class Galleta : Crema
    {
        public Galleta()
        {
            _descripcion = "Crema muy dulce con sabor a galleta óreo";
        }
    }
}
