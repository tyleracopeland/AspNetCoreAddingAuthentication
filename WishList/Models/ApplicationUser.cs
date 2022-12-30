using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace WishList.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Item> Items { get; set; }
    }
}
