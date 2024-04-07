namespace tarefa2.Models;

public class Pessoa : Entity
{
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? Endereco { get; set; }
    public string? Cidade { get; set; }
    public long? CEP { get; set; }
    public long? Telefone { get; set; }
}
