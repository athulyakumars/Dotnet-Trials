using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityImplemetation.Models
{
    // For implemeting the Asp .net Identity, use IdentityDbContext;
    //otherwise can be use DbContext
    //ApplicationUser user as Tclass in IdentityDbContext for adding extra fields to AspnetUsers tbl
    //otherwise the basic IdentityUser tbl created by default
    public class AppDbContext : IdentityDbContext<ApplicationUser> 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
    }
}
