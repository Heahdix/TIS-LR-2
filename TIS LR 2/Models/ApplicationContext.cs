using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TIS_LR_2.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :
        base(options)
        {
            Database.EnsureCreated();
        }
    }

}
