using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using patio_back.Model;


namespace patio_back.Infra
{
    public class ConnectionDbContext : DbContext
    {
        public ConnectionDbContext(DbContextOptions<ConnectionDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Caminhao> Caminhaoes { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Movimentacao> Movimentaocoes { get; set; }
    }
}
