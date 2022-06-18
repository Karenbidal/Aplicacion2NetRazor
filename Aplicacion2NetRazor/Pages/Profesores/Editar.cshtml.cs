using Aplicacion2NetRazor.Datos;
using Aplicacion2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplicacion2NetRazor.Pages.Profesores
{
    public class EditarModel : PageModel
    {
        private readonly Aplicacion2DbContext _contexto;

        public EditarModel(Aplicacion2DbContext contexto)
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
                var CursoDesdeBD = await _contexto.Profesor.FindAsync(Profesor.idProf);

                CursoDesdeBD.Nombre = Profesor.Nombre;
                CursoDesdeBD.Apellido = Profesor.Apellido;
                CursoDesdeBD.Esp = Profesor.Esp;
                CursoDesdeBD.Fecha_nac = Profesor.Fecha_nac;
                CursoDesdeBD.Fecha_ing = Profesor.Fecha_ing;

                await _contexto.SaveChangesAsync();
                Mensaje = "Profesor actualizado exitosamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage("");


        }
    }
}
