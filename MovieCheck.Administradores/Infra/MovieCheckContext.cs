using Microsoft.EntityFrameworkCore;
using MovieCheck.Administradores.Modeling;

namespace MovieCheck.Administradores.Infra
{
    class MovieCheckContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Dependente> Dependente { get; set; }
        public DbSet<Telefone> Telefone { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //USUARIO
            modelBuilder.Entity<Usuario>().ToTable("TB_Usuario");
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);

            //TELEFONE
            modelBuilder.Entity<Telefone>().ToTable("TB_Telefone");
            modelBuilder.Entity<UsuarioTelefone>().ToTable("TB_Usuario_Telefone");
            modelBuilder.Entity<UsuarioTelefone>().HasKey(ut => new { ut.UsuarioId, ut.TelefoneId });

            //ENDERECO
            modelBuilder.Entity<Endereco>().ToTable("TB_Endereco");
            modelBuilder.Entity<Endereco>().Property<int>("UsuarioId");
            modelBuilder.Entity<Endereco>().HasKey("UsuarioId");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=MOVIE_CHECK;Integrated Security=True");
        }
    }
}
