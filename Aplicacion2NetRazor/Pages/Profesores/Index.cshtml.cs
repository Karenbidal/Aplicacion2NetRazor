using Aplicacion2NetRazor.Datos;
using Aplicacion2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion2NetRazor.Pages.Profesores
{
    public class IndexModel : PageModel
    {
        private readonly Aplicacion2DbContext _contexto;

        public IndexModel(Aplicacion2DbContext contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<Profesor> Profesores { get; set; }

        public async Task OnGet()
        {
            Profesores = await _contexto.Profesor.ToListAsync();
        }
    }
}
