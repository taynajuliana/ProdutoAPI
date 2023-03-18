using CRUD_Teste.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Teste.Data;

public class ProdutoContext : DbContext
{
    public ProdutoContext(DbContextOptions<ProdutoContext>options)
        :base(options)
    {
    }
    public DbSet<Produto> Produtos { get; set; }
}
