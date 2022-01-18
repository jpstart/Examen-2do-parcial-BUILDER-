
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_parcial
{
    public class Helado
    {
        Crema _crema;
        Salsa _salsa;
        Fruto _fruto;
        string _tipo;
        public override string ToString()
        {
            return $"{_tipo}, Crema:{_crema.Descripcion}, Salsa: {_salsa.Descripcion}, Fruto: {_fruto.Descripcion}";
        }
        
        public Helado(Crema crema, Salsa salsa, Fruto fruto, String tipo)
        {
            _crema = crema;
            _salsa = salsa;
            _fruto = fruto;
            _tipo = tipo;
        }
    }
}
