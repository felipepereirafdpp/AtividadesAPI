using Microsoft.EntityFrameworkCore;
using AtividadesAPI.ApiDocs.CarteriaSesi.Model;
using AtividadesAPI.ApiDocs.Rg.Model;

namespace AtividadesAPI.ApiDocs.Data;

public class DocumentosContext : DbContext
{
    public DocumentosContext (DbContextOptions<DocumentosContext> options)
        : base(options)
    {
    }

    public DbSet<RgModel> Rgs { get; set; }

    public DbSet<CarteriaModel> Carterinhas { get; set; } 
}
