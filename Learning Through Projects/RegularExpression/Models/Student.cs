using System.ComponentModel.DataAnnotations;
namespace RegularExpression.Models

{
    public class Student
    {
        [Required]
        //[RegularExpression=]
        public string Email { get; set; }

        public string Password { get; set; }
      

    }
}
