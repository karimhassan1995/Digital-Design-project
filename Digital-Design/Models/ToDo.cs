using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Digital_Design.Models
{
    public class ToDo
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ToDoId { get; set; }
        [Required]
        public string ToDoTitle { get; set; }
        [Required, MaxLength(200), MinLength(5)]
        public string ToDoDescription { get; set; }

        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
