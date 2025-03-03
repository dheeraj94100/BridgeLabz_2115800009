using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommonLayer
{
    public class Employee
    {
        [Key]  // Marks ID as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment ID
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
