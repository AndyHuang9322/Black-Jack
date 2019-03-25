using System;
using Microsoft.EntityFrameworkCore;

namespace csharp_project.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
    }
}