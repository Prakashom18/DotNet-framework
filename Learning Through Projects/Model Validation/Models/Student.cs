using System.ComponentModel.DataAnnotations;

namespace Model_Validation.Models
{
    public class Student
    {
       [Required]
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
