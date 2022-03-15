using System;
using System.ComponentModel.DataAnnotations;
namespace week1.Models
{
        public class Student
        {
            // geti yazmak sorundayız ama seti yazmaya biliriz, readonly;
            //ya da private set yazabiliriz

            [Required]// girilmesi şart
            public int StudentId { get; set; }
            [Required(ErrorMessage = "Bu alan zorunlu")] // error mesajini kendimiz manuel olarak da tanımlayabiliriz
            [StringLength(10)]// 10 karakter uzunluğunda
            public string Name { get; set; }
            [Required]
            [StringLength(10, ErrorMessage = "Max karakter sayısını geçtiniz")]
            public string Province { get; set; }
            //[MaxLength(60)]
            //[MinLength(1)]
            [Range(18, 99)]
            [Display(Name = "Yas")]
            public int Age { get; set; }
        }
    

}
