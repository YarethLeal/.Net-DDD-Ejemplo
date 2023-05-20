using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ValueObject
{
    public record EstudianteNombre
    {
        public string Value { get; init; }
        internal EstudianteNombre(string value)
        {
            this.Value = value;
        }
        public static EstudianteNombre Create(string value)
        {
            return new EstudianteNombre(value);
        }
    }
}
