using Dominio.Entities;
using Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IEstudianteRepository
    {
        Task<Estudiante> GetEstudianteById(EstudianteId Id);
        Task CreateEstudiante(Estudiante estudiante);
        Task<List<Estudiante>> ReadEstudiante();
        Task UpdateEstudiante(Estudiante estudiante);
        Task DeleteEstudiante(Estudiante estudiante);
        Task<List<Estudiante>> ListEstudianteHonor();
    }
}
