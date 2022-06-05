using Aplicacion2NetRazor.Datos;
using Aplicacion2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion2NetRazor.Pages.Alumnos
{
    public class IndexModel : PageModel
    {
        private readonly Aplicacion2DbContext _contexto;

        public IndexModel(Aplicacion2DbContext contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<Alumno> Alumnos { get; set; }

        public async Task OnGet()
        {
            Alumnos = await _contexto.Alumno.ToListAsync();
        }
    }
}
