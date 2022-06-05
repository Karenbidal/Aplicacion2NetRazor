using System.ComponentModel.DataAnnotations;

namespace Aplicacion2NetRazor.Modelos
{
    public class Profesor
    {
        [Key]
        [Required]
        public int idProf { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Especialización")]
        public int Esp { get; set; }
        [Required]
        [Display(Name = "Fecha de ingreso")]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTime Fecha_ing { get; set; }
        [Required]
        [Display(Name = "Fecha de nacimiento")]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTime Fecha_nac { get; set; }
    }
}
