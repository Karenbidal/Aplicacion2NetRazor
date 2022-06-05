using Aplicacion2NetRazor.Datos;
using Aplicacion2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplicacion2NetRazor.Pages.Alumnos
{
    public class CrearModel : PageModel
    {
        private readonly Aplicacion2DbContext _contexto;

        public CrearModel(Aplicacion2DbContext contexto)
        {
            _contexto = contexto;
        }
        [BindProperty]
        public Alumno Alumno { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _contexto.Add(Alumno);
            await _contexto.SaveChangesAsync();
            return RedirectToPage("Index");
        }
        public void OnGet()
        {
        }


    }
}
