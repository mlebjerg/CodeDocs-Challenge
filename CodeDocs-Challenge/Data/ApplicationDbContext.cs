using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeDocs_Challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeDocs_Challenge.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
    }
}
