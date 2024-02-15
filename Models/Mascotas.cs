using System.ComponentModel.DataAnnotations;

namespace CFMASCOTASNDMM.Models
{
    public class Mascotas
    {

        [Key]
        public int Idmascotas { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Propietario { get; set; }
    }
}
