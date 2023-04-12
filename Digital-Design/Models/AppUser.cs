using Microsoft.AspNetCore.Identity;

namespace Digital_Design.Models
{
    public class AppUser : IdentityUser
    {
        public ICollection<ToDo> ToDos { get; set; } = new HashSet<ToDo>();
    }
}
