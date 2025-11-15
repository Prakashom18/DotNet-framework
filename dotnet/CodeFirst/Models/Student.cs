using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CodeFirst.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName",TypeName ="varchar(100)")]
        public string Name { get; set; }

        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
