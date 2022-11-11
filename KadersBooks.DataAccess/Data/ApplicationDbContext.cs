using KadersBooks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaderBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
<<<<<<< HEAD
        public DbSet<Category> Categories { get; set; }
=======

       public DbSet<Category> Categories { get; set; }
>>>>>>> a2ee6a58678b3b82e265fe1c2dccabf3c4d44a79
    }
}
