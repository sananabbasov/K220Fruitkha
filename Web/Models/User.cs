using Microsoft.AspNetCore.Identity;

namespace Web.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
