using Microsoft.EntityFrameworkCore;

namespace MvcCRM.Models
{
    public class MvcCRMContext : DbContext
    {
        public MvcCRMContext (DbContextOptions<MvcCRMContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCRM.Models.User> User { get; set; }
        public DbSet<MvcCRM.Models.Client> Client { get; set; }
        public DbSet<MvcCRM.Models.Contact> Contact { get; set; }
        public DbSet<MvcCRM.Models.Meeting> Meeting { get; set; }
        public DbSet<MvcCRM.Models.SupportTicket> SupportTicket { get; set; }

    }
}