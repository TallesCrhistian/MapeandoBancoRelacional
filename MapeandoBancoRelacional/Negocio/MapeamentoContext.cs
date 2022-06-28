
using MapeandoBancoRelacional.Dados;
using System.Data.Entity;


namespace MapeandoBancoRelacional.Negocio
{
    public class MapeamentoContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set;}

        public MapeamentoContext () : base("Server = DESKTOP-HGI5CK3; Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;") { }
 
    }
}
