using System.ComponentModel.DataAnnotations;

namespace Aplicacion2NetRazor.Modelos
{
    public class Curso
    {
        //pongo los datanotations
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Nombre de curso")]
        public string NombreCurso { get; set; }
        [Display(Name = "Cantidad de clases")]
        public int CantidadClases { get; set; }
        public int Precio { get; set; }
        [Display(Name = "Fecha de creación")]
        public DateTime FechaCreacion { get; set; }


    }
}
