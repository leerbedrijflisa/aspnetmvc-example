using System.Data.Entity;

namespace Lisa.AspNetMvc.Example
{
    public class ExampleContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}