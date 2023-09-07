using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_4.Models;

namespace Project_4.Data
{
    public class Project_4DbContext : DbContext
    {
        public Project_4DbContext (DbContextOptions<Project_4DbContext> options)
            : base(options)
        {
        }

        public DbSet<Project_4.Models.RainbowSchool> RainbowSchool { get; set; } = default!;
    }
}
