
using Microsoft.AspNetCore.Identity;

namespace DevBlog.Core.Entities
{
    public class User : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
