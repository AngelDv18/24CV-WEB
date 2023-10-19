using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _24CV_WEB.Models
{

    [Table("Curriculums")]

    public class Curriculum
    {
        [Key]

        [Required(ErrorMessage ="El campo nombre es requerido")]
        [StringLength(50, ErrorMessage ="Maximo 50 caracteres")]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "EL CURP es Obligatorio")]
        public string CURP { get; set;}
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        public DateTime FechadeNacimiento { get; set; }
        public string Email { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Direccion { get; set; }
        [Range(0, 100)]
        public int PorcentajeIngles { get; set; }

        [NotMapped]
        public IFormFile? Foto { get; set; }

        public string RutaFoto { get; set; }

    }
}
