using System.ComponentModel.DataAnnotations;
namespace EFCore.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Semester { get; set; }
    }
}
