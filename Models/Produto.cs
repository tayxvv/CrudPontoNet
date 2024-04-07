namespace tarefa2.Models;

public class Produto : Entity
{
    public string? Descricao { get; set; }
    public decimal? Preco { get; set; }
    public string? NCM { get; set; }
    public int? Quantidade { get; set; }
}
