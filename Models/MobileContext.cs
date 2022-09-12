using Microsoft.EntityFrameworkCore;

namespace lavAspMvclast.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<ToDoTask> ToDoTasks { get; set; }
        public MobileContext(DbContextOptions<MobileContext> options) : base(options)
        {

        }
    }
}
