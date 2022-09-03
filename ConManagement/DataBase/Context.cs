using ContactsManagementSoft.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsManagementSoft.DataBase
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ContactModel> ContactModel { get; set; }
    }
}
