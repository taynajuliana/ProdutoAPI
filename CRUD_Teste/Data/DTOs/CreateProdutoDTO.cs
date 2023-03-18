using System.ComponentModel.DataAnnotations;

namespace CRUD_Teste.Data.DTOs;

public class CreateProdutoDTO
{
    public int Id { get; set; }
    [Required(ErrorMessage = "O Nome é obrigatório")]
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public double Preco { get; set; }
}
