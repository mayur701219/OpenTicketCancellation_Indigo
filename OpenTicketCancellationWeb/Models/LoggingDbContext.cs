using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace OpenTicketCancellationWeb.Models
{
    public class LoggingDbContext : DbContext
    {
        public DbSet<LogEntry> LogEntries { get; set; }

        public LoggingDbContext(DbContextOptions<LoggingDbContext> options) : base(options) { }
    }
}
