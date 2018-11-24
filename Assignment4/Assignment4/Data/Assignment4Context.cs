using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment4.Models
{
    public class Assignment4Context : DbContext
    {
        public Assignment4Context (DbContextOptions<Assignment4Context> options)
            : base(options)
        {
        }

        public DbSet<Assignment4.Models.Member> Member { get; set; }
    }
}
