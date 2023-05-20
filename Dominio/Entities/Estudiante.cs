using Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Estudiante
    {
        public Guid Id { get; init; }
        public EstudianteCarnet Carnet { get; private set; }
        public EstudianteNombre Nombre { get; private set; }
        public EstudianteApellido Apellido { get; private set; }
        public EstudianteEdad Edad { get; private set; }
        public EstudiantePonderado Ponderado { get; private set; }
        public Estudiante(Guid id)
        {
            this.Id = id;
        }
        public void setInformacion(EstudianteCarnet carnet,EstudianteNombre nombre,EstudianteApellido apellido,EstudianteEdad edad,EstudiantePonderado ponderado)
        {
            this.Carnet = carnet;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Ponderado = ponderado;
        }
    }
}
