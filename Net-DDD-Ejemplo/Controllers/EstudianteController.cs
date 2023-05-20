using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net_DDD_Ejemplo.Commands;
using Net_DDD_Ejemplo.Services;

namespace Net_DDD_Ejemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly EstudianteService estudianteService;
        public EstudianteController(EstudianteService estudianteService)
        {
            this.estudianteService = estudianteService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEstudiante(CreateEstudiantesCommands createEstudiantesCommands)
        {
            await estudianteService.HandleCreateCommand(createEstudiantesCommands);
            return Ok(createEstudiantesCommands);
        }
        [HttpGet]
        public async Task<IActionResult> ReadEstudiante()
        {
            var response = await estudianteService.HandleReadCommand();
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateEstudiante(CreateEstudiantesCommands createEstudiantesCommands)
        {
            await estudianteService.HandleUpdateCommand(createEstudiantesCommands);
            return Ok(createEstudiantesCommands);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteEstudiante(CreateEstudiantesCommands createEstudiantesCommands)
        {
            await estudianteService.HandleDeleteCommand(createEstudiantesCommands);
            return Ok(createEstudiantesCommands);
        }
        [HttpGet]
        public async Task<IActionResult> HonorEstudiante()
        {
            var response = await estudianteService.HandleHonorCommand();
            return Ok(response);
        }

    }
}
