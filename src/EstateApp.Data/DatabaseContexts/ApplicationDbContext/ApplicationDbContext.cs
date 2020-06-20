using Microsoft.EntityFrameworkCore;

namespace EstateApp.Data.DatabaseContexts.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext  
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public Dbset<Property> Properties { get; set; }
        public Dbset<Contacts> Contacts { get; set;}
    }
}