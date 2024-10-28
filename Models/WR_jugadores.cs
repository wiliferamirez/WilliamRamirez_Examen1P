using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
namespace WilliamRamirez_Examen1P.Models
{
    public class WR_jugadores
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre requerido")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener mas de 100 caracteres")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Apellido requerido")]
        [StringLength(50, ErrorMessage = "El apellido no puede tener mas de 100 caracteres")]
        public string apellido { get; set; }
        [Required(ErrorMessage = "Edad requerida")]
        [Range(16, 18, ErrorMessage = "El jugador debe tener entre 16-18 años")]
        public int edad { get; set; }
        [Required(ErrorMessage = "Dorsalrequerida")]
        [Range(1, 99, ErrorMessage = "La dorsal debe ser entre 1-99")]
        public int dorsal { get; set; }
        [Required(ErrorMessage = "Se requiere estado")]
        public bool activo { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime fechaInscripcion{ get; set; }
        [Required(ErrorMessage = "Sueldo Requerido")]
        public float sueldo { get; set; }
    }
}