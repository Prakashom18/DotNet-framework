using System.ComponentModel.DataAnnotations;
namespace RegularExpression.Models

{
    public class Student
    {
        [Required]
        //[RegularExpression=]
        public string Email { get; set; }

        [Required(ErrorMessage ="Pass is must")]
        public string Password { get; set; }
      

    }
}
