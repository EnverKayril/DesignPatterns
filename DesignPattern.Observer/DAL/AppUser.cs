using Microsoft.AspNetCore.Identity;

namespace DesignPattern.Observer.DAL
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? City { get; set; } = "lorem";
        public string? District { get; set; } = "lorem";
    }
}
