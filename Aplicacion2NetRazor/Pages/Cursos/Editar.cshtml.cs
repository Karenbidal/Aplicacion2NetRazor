using Aplicacion2NetRazor.Datos;
using Aplicacion2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplicacion2NetRazor.Pages.Cursos
{
    public class EditarModel : PageModel
    {
        private readonly Aplicacion2DbContext _contexto;

        public EditarModel(Aplicacion2DbContext contexto)
        {
            _contexto = contexto;
        }
        [BindProperty]
        public Curso Curso { get; set; }

        public async Task OnGet(int Id)
        {
            Curso = await _contexto.Curso.FindAsync(Id);

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CursoDesdeBD = await _contexto.Curso.FindAsync(Curso.Id);

                CursoDesdeBD.NombreCurso = Curso.NombreCurso;
                CursoDesdeBD.CantidadClases = Curso.CantidadClases;
                CursoDesdeBD.Precio = Curso.Precio;
                await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage("");


        }
    }
}
