using System.ComponentModel.DataAnnotations;

namespace Aplicacion2NetRazor.Modelos
{
    public class Alumno
    {
        [Key]
        [Required]
        [Display(Name = "Id")]
        public int idAlumno { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Fecha de ingreso")]
        [DisplayFormat(DataFormatString ="{0: yyyy-MM-dd}")]
        public DateTime Fecha_ing { get; set; }
        [Required]
        [Display(Name = "Hora de ingreso")]
        [DisplayFormat(DataFormatString = "{0: hh:mm:ss}")]
        public DateTime Hora_ing { get; set; }
        [Required]
        [Display(Name = "Fecha de nacimiento")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime Fecha_nac { get; set; }
        [Required]
        [Display(Name = "Cantidad de cursos")]
        public int Cant_cursos { get; set; }
        [Required]
        [Display(Name = "Fecha de egreso")]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        public DateTime Fecha_egr { get; set; }
        [Required]
        public bool Eliminado { get; set; }
    }
}
