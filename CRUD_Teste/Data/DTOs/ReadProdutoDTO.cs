using System.ComponentModel.DataAnnotations;

namespace CRUD_Teste.Data.DTOs;

public class ReadProdutoDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public double Preco { get; set; }
}
