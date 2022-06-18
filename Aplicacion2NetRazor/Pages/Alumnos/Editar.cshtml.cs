using Aplicacion2NetRazor.Datos;
using Aplicacion2NetRazor.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aplicacion2NetRazor.Pages.Alumnos
{
    public class EditarModel : PageModel
    {
        private readonly Aplicacion2DbContext _contexto;

        public EditarModel(Aplicacion2DbContext contexto)
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
                var AlumnoDesdeBD = await _contexto.Alumno.FindAsync(Alumno.idAlumno);

                AlumnoDesdeBD.Nombre = Alumno.Nombre;
                AlumnoDesdeBD.Apellido = Alumno.Apellido;
                AlumnoDesdeBD.Fecha_ing = Alumno.Fecha_ing;
                AlumnoDesdeBD.Hora_ing = Alumno.Hora_ing;
                AlumnoDesdeBD.Fecha_nac = Alumno.Fecha_nac;
                AlumnoDesdeBD.Cant_cursos = Alumno.Cant_cursos;
                AlumnoDesdeBD.Fecha_egr = Alumno.Fecha_egr;

                await _contexto.SaveChangesAsync();
                Mensaje = "Alumno editado exitosamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage("");


        }
    }
}
