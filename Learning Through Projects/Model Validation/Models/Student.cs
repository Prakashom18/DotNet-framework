using System.ComponentModel.DataAnnotations;

namespace Model_Validation.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(15,MinimumLength =3,ErrorMessage="Lengthe must be 3 to 15")]
     
        public string Name { get; set; }

        [Required]
        public string Age { get; set; }
    }
}
