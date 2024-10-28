using System.ComponentModel.DataAnnotations;

namespace WilliamRamirez_Examen1P.Models
{
    public class WR_Sub18
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre requerido")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener mas de 100 caracteres")]
        public string WR_nombre { get; set; }
        [Required(ErrorMessage = "Apellido requerido")]
        [StringLength(50, ErrorMessage = "El apellido no puede tener mas de 100 caracteres")]
        public string WR_apellido { get; set; }
        [Required(ErrorMessage = "Edad requerida")]
        [Range(16, 18, ErrorMessage = "El jugador debe tener entre 16-18 años")]
        public int WR_edad { get; set; }
        [Required(ErrorMessage = "Dorsalrequerida")]
        [Range(1, 99, ErrorMessage = "La dorsal debe ser entre 1-99")]
        public int WR_dorsal { get; set; }
        [Required(ErrorMessage = "Se requiere estado")]
        public bool WR_activo { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime WR_fechaInscripcion { get; set; }
        [Required(ErrorMessage = "Sueldo Requerido")]
        public float WR_sueldo { get; set; }
    }
}
