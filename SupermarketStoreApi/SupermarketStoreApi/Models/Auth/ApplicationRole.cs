﻿using Microsoft.AspNetCore.Identity;

namespace SupermarketStoreApi.Models.Auth
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
