using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ValueObject
{
    public record EstudianteEdad
    {
        public int Value { get; init; }
        internal EstudianteEdad(int value)
        {
            this.Value = value;
        }
        public static EstudianteEdad Create(int value)
        {
            return new EstudianteEdad(value);
        }
    }
}
