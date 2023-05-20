using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ValueObject
{
    public record EstudianteCarnet
    {
        public string Value { get; init; }
        internal EstudianteCarnet(string value)
        {
            this.Value = value;
        }
        public static EstudianteCarnet Create(string value)
        {
            return new EstudianteCarnet(value);
        }
    }
}
