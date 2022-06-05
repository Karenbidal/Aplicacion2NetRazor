using Aplicacion2NetRazor.Datos;
using Aplicacion2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion2NetRazor.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        private readonly Aplicacion2DbContext _contexto;

        public IndexModel(Aplicacion2DbContext contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<Curso> Cursos { get; set; }

        public async Task OnGet()
        {
            Cursos = await _contexto.Curso.ToListAsync();
        }
    }
}
