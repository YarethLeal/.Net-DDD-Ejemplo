using Dominio.Interfaces;
using Dominio.Entities;
using Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura
{
    public class EstudianteRepositorio: IEstudianteRepository
    {
        DatabaseContext db;

        public EstudianteRepositorio(DatabaseContext db_)
        {
            db = db_;
        }

        public async Task CreateEstudiante(Estudiante estudiante)
        {
            await db.AddAsync(estudiante);
            await db.SaveChangesAsync();
        }

        public async Task<Estudiante> GetEstudianteById(EstudianteId Id)
        {
            return await db.Estudiante.FindAsync((Guid)Id);
        }

        public async Task<List<Estudiante>> ReadEstudiante()
        {
            return await db.Estudiante.ToListAsync();
        }
        public async Task UpdateEstudiante(Estudiante estudiante)
        {
            db.Entry(estudiante).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
        public async Task DeleteEstudiante(Estudiante estudiante)
        {
            db.Estudiante.Remove(estudiante);
            await db.SaveChangesAsync();
        }
        public async Task<List<Estudiante>> ListEstudianteHonor()
        {

            //var respuesta = (from estudiante in db.Estudiante.Where(estudiante => estudiante.Ponderado.Value > 9)
            //                 orderby estudiante.Ponderado.Value
            //                 //select new estudiante
            //                 //{
            //                 //    id = (guid)estudiante.id,
            //                 //    carnet = estudiante.carnet,
            //                 //    nombre = estudiante.nombre,
            //                 //    apellido = estudiante.apellido,
            //                 //    edad=estudiante.edad,
            //                 //    ponderado=estudiante.ponderado,

            //                 //});
            //                 );

            //return await respuesta.ToListAsync();
            return null;
        }

    }
}
