using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ValueObject
{
    public record EstudianteApellido
    {
        public string Value { get; init; }
        internal EstudianteApellido(string value)
        {
            this.Value = value;
        }
        public static EstudianteApellido Create(string value)
        {
            return new EstudianteApellido(value);
        }
    }
}
