using System.ComponentModel.DataAnnotations;

namespace AtividadesAPI.ApiDocs.Rg.Model;

public class RgModel
{

    [Key] public Guid Id { get; set; }
    [StringLength(9)] public required string  Numero { get; set; }
    [StringLength(100)] public required string Nome { get; set; }
    public required string UrlFoto { get; set; }
    [StringLength(100)] public string? NomePai { get; set; }
    [StringLength(100)] public string? NomeMae { get; set; }
    public DateOnly? DataNascimento { get; set; }
    [StringLength(10)] public required string OrgaoExpedidor { get; set; }
    [StringLength(3)] public string? FatorRH { get; set; }
    public string? Naturilidade { get; set; }
    public string? Observacao { get; set; }


}
