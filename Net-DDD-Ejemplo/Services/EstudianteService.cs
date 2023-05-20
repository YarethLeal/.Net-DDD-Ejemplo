using Dominio.Interfaces;
using Dominio.ValueObject;
using Net_DDD_Ejemplo.Commands;
using Dominio.Entities;
using Net_DDD_Ejemplo.Queries;
namespace Net_DDD_Ejemplo.Services
{
    public class EstudianteService
    {
        private readonly IEstudianteRepository repository;
        private readonly EstudianteQueries estudiianteQueries;
        public EstudianteService(IEstudianteRepository repository,
            EstudianteQueries estudianteQueries
            )
        {
            this.repository = repository;  
            this.estudiianteQueries = estudianteQueries;
        }
        public async Task HandleCreateCommand(CreateEstudiantesCommands createEstudiante)
        {
            var estudiante = new Estudiante(EstudianteId.Create(createEstudiante.estudianteId));
            estudiante.setInformacion(
                EstudianteCarnet.Create(createEstudiante.Carnet),
                EstudianteNombre.Create(createEstudiante.Nombre),
                EstudianteApellido.Create(createEstudiante.Apellido),
                EstudianteEdad.Create(createEstudiante.Edad),
                EstudiantePonderado.Create(createEstudiante.Ponderado)
            );
            await repository.CreateEstudiante(estudiante);
        }
        public async Task<List<Estudiante>> HandleReadCommand()
        {
            return await repository.ReadEstudiante();
        }
        public async Task HandleUpdateCommand(CreateEstudiantesCommands createEstudiante)
        {
            var estudiante = new Estudiante(EstudianteId.Create(createEstudiante.estudianteId));
            estudiante.setInformacion(
                EstudianteCarnet.Create(createEstudiante.Carnet),
                EstudianteNombre.Create(createEstudiante.Nombre),
                EstudianteApellido.Create(createEstudiante.Apellido),
                EstudianteEdad.Create(createEstudiante.Edad),
                EstudiantePonderado.Create(createEstudiante.Ponderado)
            );
            await repository.UpdateEstudiante(estudiante);
        }
        public async Task HandleDeleteCommand(CreateEstudiantesCommands createEstudiante)
        {
            var estudiante = new Estudiante(EstudianteId.Create(createEstudiante.estudianteId));
            estudiante.setInformacion(
                EstudianteCarnet.Create(createEstudiante.Carnet),
                EstudianteNombre.Create(createEstudiante.Nombre),
                EstudianteApellido.Create(createEstudiante.Apellido),
                EstudianteEdad.Create(createEstudiante.Edad),
                EstudiantePonderado.Create(createEstudiante.Ponderado)
            );
            await repository.DeleteEstudiante(estudiante);
        }
        public async Task<List<Estudiante>> HandleHonorCommand()
        {
            return await repository.ListEstudianteHonor();
        }
    }
}
