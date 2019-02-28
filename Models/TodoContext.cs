using Microsoft.EntityFrameworkCore;

namespace todoM.Models
{
    public class TodoContext: DBContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}