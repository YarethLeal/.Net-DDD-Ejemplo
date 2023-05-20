using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ValueObject
{
    public record EstudianteId
    {
        public Guid value { get; init; }

        internal EstudianteId(Guid value_)
        {
            this.value = value_;
        }
        public static EstudianteId Create(Guid value)
        {
            return new EstudianteId(value);
        }
        public static implicit operator Guid(EstudianteId estudianteId)
        {
            return estudianteId.value;
        }
    }
}
