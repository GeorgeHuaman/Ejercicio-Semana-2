using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2
{
    abstract class Shape
    {
        protected string type;
        protected string name;
        
        protected Shape(string type, string name)
        {
            this.type = type;
            this.name = name;
        }

        public string GetDetails()
        {
            return $"La figura es de tipo {type} tiene el nombre de {name}";
        }
    }
}
