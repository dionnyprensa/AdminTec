using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AdminTec.MVC.Models
{
    public class UserViewModel
    {
        [DisplayName("Usuario")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Usuario requerido.")]
        [RegularExpression(@"^[A-Za-z]\w+$", ErrorMessage = "Solo letras.")]
        [StringLength(maximumLength: 16, MinimumLength = 4, ErrorMessage = "Debe tener entre 4 y 16 letras.")]
        public string UserName { get; set; }

        [DisplayName("Clave")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Clave requerida.")]
        //[PasswordPropertyText()]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,16}$", ErrorMessage = "Debe tener entre 8 y 16 letras. Al menos 1 Mayúscula y 1 Número.")]
        public string Password { get; set; }

        [DisplayName("Recordarme")]
        public bool RememberMe { get; set; }
    }
}