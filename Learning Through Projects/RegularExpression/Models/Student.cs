using System.ComponentModel.DataAnnotations;
namespace RegularExpression.Models

{
    public class Student
    {
        [Required]
        [RegularExpression(@"^\w+@\w+\.\w+$",ErrorMessage ="Please provide valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Pass is must")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Pass should be 10 letters")]
        public string PhoneNo { get; set; }


      

    }
}
