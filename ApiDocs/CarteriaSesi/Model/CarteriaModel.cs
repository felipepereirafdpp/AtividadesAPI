using System.ComponentModel.DataAnnotations;

namespace AtividadesAPI.ApiDocs.CarteriaSesi.Model;

public class CarteriaModel
{
    [Key] public Guid Id { get; set; }

    [StringLength(10)] public string? Rm { get; set; }
    [StringLength(100)] public required string Nome { get; set; }
    [StringLength(11)] public required string Cpf { get; set; }
    public required string UrlFoto { get; set; }
    public required DateOnly DataNascimento { get; set; }
    public required DateOnly DataVencimento { get; set; }


    

}
