using Aplicacion2NetRazor.Datos;
using Aplicacion2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplicacion2NetRazor.Pages.Alumnos
{
    public class BorrarModel : PageModel
    {
            private readonly Aplicacion2DbContext _contexto;

            public BorrarModel(Aplicacion2DbContext contexto)
            {
                _contexto = contexto;
            }
            [BindProperty]
            public Alumno Alumno { get; set; }

            [TempData]
            public string Mensaje { get; set; }

            public async Task OnGet(int Id)
            {
                Alumno = await _contexto.Alumno.FindAsync(Id);

            }
            public async Task<IActionResult> OnPost()
            {
                if (ModelState.IsValid)
                {
                    var AlumnoBorrar = await _contexto.Alumno.FindAsync(Alumno.idAlumno);

                    if (AlumnoBorrar == null)
                    {
                        return NotFound();
                    }

                    AlumnoBorrar.Eliminado = true;
                    _contexto.SaveChangesAsync();
                    Mensaje = "Alumno eliminado correctamente";
                    return RedirectToPage("Index");
                }
                return RedirectToPage("");


            }
        }
}
