using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_parcial
{
    //El siguiente codigo esta hecho para poner en practica el uso del patron de diseño "BUILDER",
    //Builder es un patron de tipo Constructor que tiene como proposito separar la construccion de un objeto complejo 
    //de su representación, de forma que el mismo proceso de construcción puede crear diferentes representaciones//
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
