using System;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Data
{
    public class BloggingContext : DbContext
    {
        // DbSet - para combertir nuestro modelo en una tabla
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        // Crear la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Cadena de conexión
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Blogging; Integrated Security=True");
        }

    }
}
