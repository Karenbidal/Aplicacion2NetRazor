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
        [TempData]
        public string Mensaje { get; set; }
        public async Task OnGet()
        {
            Cursos = await _contexto.Curso.ToListAsync();
        }

        
        public async Task<IActionResult> OnPostBorrar(int Id)
        {
            if (ModelState.IsValid)
            {
                var CursoBorrar = await _contexto.Curso.FindAsync(Id);

                if (CursoBorrar == null)
                {
                    return NotFound();
                }

                _contexto.Curso.Remove(CursoBorrar);
                await _contexto.SaveChangesAsync();
                Mensaje = "Curso eliminado exitosamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage("");


        }
    }
}
