using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokesWebApp.Models;

namespace JokesWebApp.Data
{
    public class JokesWebAppContext : DbContext
    {
        public JokesWebAppContext (DbContextOptions<JokesWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Joke> Joke { get; set; }
        public DbSet<Message> Message { get; set; }
    }
}
