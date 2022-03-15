using System;
using System.ComponentModel.DataAnnotations;

namespace Homework1.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Bu alan zorunludur!")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="Bu alan zorunludur!")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage = "Lütfen geçerli bir e-mail adresi giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Bu alan zorunludur!")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d\\W]{8,63}$",
            ErrorMessage = "Şifreniz En az 1 büyük karakter 1 sayı ve 8 haneyi geçmelidir")]
        [StringLength(8,ErrorMessage="Uzunluğu 8 karakter olmalıdır")]
        public string Password { get; set; }
    }
}
