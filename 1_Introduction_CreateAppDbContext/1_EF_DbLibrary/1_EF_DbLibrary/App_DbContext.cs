using Microsoft.EntityFrameworkCore;

namespace _1_EF_DbLibrary
{
    public class App_DbContext : DbContext
    {
        public App_DbContext() { } //For Scaffolding.
        public App_DbContext( DbContextOptions options) : base( options) //For Dependency Injection.
        { }
    }
}
