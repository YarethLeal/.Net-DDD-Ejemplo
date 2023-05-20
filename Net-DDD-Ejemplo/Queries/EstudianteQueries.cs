using Dominio.Entities;
using Dominio.Interfaces;
using Dominio.ValueObject;

namespace Net_DDD_Ejemplo.Queries
{
    public class EstudianteQueries
    {
        private readonly IEstudianteRepository repository;

        public EstudianteQueries(IEstudianteRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Estudiante> GetEstudianteById(Guid Id)
        {
            var response= await repository.GetEstudianteById(
                EstudianteId.Create(Id));
            return response;
        }
    }
}
