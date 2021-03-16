using Microsoft.EntityFrameworkCore;

namespace taskManager.Models
{
    /*
        Everytime you change something on the models, run these:
            - dotnet ef migrations add <Name>
            - dotnet ef database update
    */

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        // which of my models should become tables in the DB
        public DbSet<Task> Tasks {get; set;}
    }
}