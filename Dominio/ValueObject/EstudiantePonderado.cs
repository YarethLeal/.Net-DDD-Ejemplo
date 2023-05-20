using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ValueObject
{
    public record EstudiantePonderado
    {
        public double Value { get; init; }
        internal EstudiantePonderado(double value)
        {
            this.Value = value;
        }
        public static EstudiantePonderado Create(double value)
        {
            return new EstudiantePonderado(value);
        }
    }
}
