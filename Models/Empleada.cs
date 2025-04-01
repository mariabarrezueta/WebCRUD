using System.ComponentModel.DataAnnotations;

namespace WebCRUD.Models
{
    public class Empleada
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Direccion { get; set; } = string.Empty;

        [Required]
        public string Telefono { get; set; } = string.Empty;
    }
}
