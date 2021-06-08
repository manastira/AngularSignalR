using AngularSignalR.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularSignalR.Data
{
    public class AngularSignalRContext : DbContext
    {
        public AngularSignalRContext(DbContextOptions<AngularSignalRContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Notification> Notification { get; set; }

    }
}
