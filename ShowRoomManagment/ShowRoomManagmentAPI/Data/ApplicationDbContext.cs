using Microsoft.EntityFrameworkCore;


namespace ShowRoomManagmentAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

         public DbSet<Department> Departments { get; set; }

    }
}   
