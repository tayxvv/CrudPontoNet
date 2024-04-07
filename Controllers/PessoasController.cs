using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tarefa2.Models;

namespace tarefa2.Controllers;

public class PessoasController : Controller
{
    private readonly ILogger<Controller> _logger;

    public PessoasController(ILogger<PessoasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Pessoa()
    {
        return View();
    }

    public IActionResult Listar()
    {
        Repositorio<Pessoa> repo = new Repositorio<Pessoa>();
        List<Pessoa> lista = repo.Listar();
        return View(lista);
    }

    [HttpPost]
    public IActionResult Pessoa(Pessoa model)
    {   
        Repositorio<Pessoa> repo = new Repositorio<Pessoa>();
        repo.Adicionar(model);
        return RedirectToAction("Listar");
    }

    public IActionResult Editar(int id)
    {
        Repositorio<Pessoa> repo = new Repositorio<Pessoa>();
        Pessoa pessoa = repo.Buscar(id);
        
        if (pessoa == null)
        {
            return NotFound();
        }

        return View(pessoa);
    }

    [HttpPost]
    public IActionResult Editar(Pessoa pessoa)
    {
        Repositorio<Pessoa> repo = new Repositorio<Pessoa>();
        repo.Atualizar(pessoa);

        
        return RedirectToAction("Listar");
    }

    public IActionResult Apagar(int id)
    {
        Repositorio<Pessoa> repo = new Repositorio<Pessoa>();
        Pessoa pessoa = repo.Buscar(id);
        
        if (pessoa == null)
        {
            return NotFound();
        }

        return View(pessoa);
    }

    [HttpPost]
    public IActionResult Apagar(Pessoa pessoa)
    {
        Repositorio<Pessoa> repo = new Repositorio<Pessoa>();
        repo.Remover(pessoa.Id);
        return RedirectToAction("Listar");
    }
}
