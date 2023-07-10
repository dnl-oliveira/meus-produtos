using MeusProdutos.Infra.Data.Context;
using System.Data.Entity.Migrations;
namespace MeusProdutos.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MeuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
