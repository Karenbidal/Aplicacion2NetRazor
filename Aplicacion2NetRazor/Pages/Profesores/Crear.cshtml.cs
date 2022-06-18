using Aplicacion2NetRazor.Datos;
using Aplicacion2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplicacion2NetRazor.Pages.Profesores
{
    public class CrearModel : PageModel
    {
        private readonly Aplicacion2DbContext _contexto;

        public CrearModel(Aplicacion2DbContext contexto)
        {
            _contexto = contexto;
        }
        [BindProperty]
        public Profesor Profesor { get; set; }
        [TempData]
        public string Mensaje { get; set; }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _contexto.Add(Profesor);
            await _contexto.SaveChangesAsync();
            Mensaje = "Profesor creado exitosamente";
            return RedirectToPage("Index");
        }
        public void OnGet()
        {
        }

    }
}
