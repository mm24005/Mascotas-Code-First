using Microsoft.EntityFrameworkCore;

namespace CFMASCOTASNDMM.Models
{
        public class MascotasContext : DbContext
        {
            public MascotasContext(DbContextOptions<MascotasContext> options) : base(options)
            {
            }

            public DbSet<Mascotas> mascotas { get; set; }
        }
    }
