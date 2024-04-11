using System.ComponentModel.DataAnnotations;
namespace tarefa2.Models;

public class Pessoa : Entity
{
    [Required(ErrorMessage="O campo nome é obrigatório")]
    [Display(Name = "Nome")]
    public string? Nome { get; set; }
    [Required(ErrorMessage="O campo Idade é obrigatório")]
    [Display(Name = "Idade")]
    [Range(1,200,ErrorMessage="A idade está em um intervalo inválido")]
    public int? Idade { get; set; }
    [Required(ErrorMessage="O campo Sobrenome é obrigatório")]
    [Display(Name = "Sobrenome")]
    public string? Sobrenome { get; set; }
    [Required(ErrorMessage="O campo Endereco é obrigatório")]
    [Display(Name = "Endereco")]
    public string? Endereco { get; set; }
    [Required(ErrorMessage="O campo Cidade é obrigatório")]
    [Display(Name = "Cidade")]
    public string? Cidade { get; set; }
    [Required(ErrorMessage="O campo CEP é obrigatório")]
    [Display(Name = "CEP")]
    public long? CEP { get; set; }
    [Required(ErrorMessage="O campo Telefone é obrigatório")]
    [Display(Name = "Telefone")]
    public long? Telefone { get; set; }
}
