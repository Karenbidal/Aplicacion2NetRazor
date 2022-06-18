using Aplicacion2NetRazor.Datos;
using Aplicacion2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplicacion2NetRazor.Pages.Profesores
{
    public class BorrarModel : PageModel
    {
        private readonly Aplicacion2DbContext _contexto;

        public BorrarModel(Aplicacion2DbContext contexto)
        {
            _contexto = contexto;
        }
        [BindProperty]
        public Profesor Profesor { get; set; }
        [TempData]
        public string Mensaje { get; set; }
        public async Task OnGet(int Id)
        {
            Profesor = await _contexto.Profesor.FindAsync(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var ProfesorBorrar = await _contexto.Profesor.FindAsync(Profesor.idProf);

                    if (ProfesorBorrar == null)
                    {
                        return NotFound();
                    }

                    _contexto.Profesor.Remove(ProfesorBorrar);
                    _contexto.SaveChangesAsync();
                Mensaje = "Profesor eliminado exitosamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage("");
        }
    }
}
