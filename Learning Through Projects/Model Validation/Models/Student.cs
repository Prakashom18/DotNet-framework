using System.ComponentModel.DataAnnotations;

namespace Model_Validation.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(15,MinimumLength =3,ErrorMessage="Lengthe must be 3 to 15")]
     
        public string Name { get; set; }

        [Required(ErrorMessage ="Age is required")]

        public int Age { get; set; }

        [Required(ErrorMessage ="Email is Required")]
        public string Email { get; set; }

    }
}
