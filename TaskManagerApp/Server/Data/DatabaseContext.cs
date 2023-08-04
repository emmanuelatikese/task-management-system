
using Microsoft.EntityFrameworkCore;

using TaskItem = TaskManagerApp.Shared.Models.TaskItem;

namespace TaskManagerApp.Server.Data
{

        public class DatabaseContext : DbContext
        {
            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
            {
            }

            public DbSet<TaskItem>? Task { get; set; }

        }
    
}
