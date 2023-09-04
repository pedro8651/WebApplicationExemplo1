using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using WebApplicationExemplo1.Models;

namespace WebApplicationExemplo1.Data
{
    public class ApplicationDbContext : DbContext{
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }
            public DbSet<Aluno> aluno {  get; set; }
            public DbSet<Turma> turma { get; set; }
    }
}
