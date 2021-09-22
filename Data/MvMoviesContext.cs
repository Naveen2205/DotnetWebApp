using Microsoft.EntityFrameworkCore;
using MvMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvMovies.Data
{
    public class MvMoviesContext : DbContext
    {
        public MvMoviesContext(DbContextOptions<MvMoviesContext> options) : base(options) { }

        public DbSet<Movie> Movie { get; set; }
    }
}
