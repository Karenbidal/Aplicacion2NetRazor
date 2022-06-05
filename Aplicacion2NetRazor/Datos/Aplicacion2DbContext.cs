using Aplicacion2NetRazor.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion2NetRazor.Datos
{
    public class Aplicacion2DbContext: DbContext
    //esta clase es necesaria para poder hacer las migrations
    {
        public Aplicacion2DbContext(DbContextOptions<Aplicacion2DbContext> options): base(options)
        {
            
        }
        //Models
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Profesor> Profesor { get; set; }

    }
}
