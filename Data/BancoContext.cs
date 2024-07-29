using Microsoft.EntityFrameworkCore;
using MVC_Asp.net_portifolio.Models;

namespace MVC_Asp.net_portifolio.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<ContatoModel> Contatos {  get; set; }
    }
}
