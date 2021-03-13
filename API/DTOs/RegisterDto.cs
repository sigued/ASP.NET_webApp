using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        // using System.ComponentModel.DataAnnotations;
        // annotation des donnees pour valider les attributs, notamment la longueur des string, etc. il est
        // recommande de faire la validation dans les Dto, car les controlleurs permettent de valider automatiquement les attributs
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}