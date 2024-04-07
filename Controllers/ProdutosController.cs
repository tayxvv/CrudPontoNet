using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tarefa2.Models;
using System.Text.Json;

namespace tarefa2.Controllers;

public class ProdutosController : Controller
{
    private readonly ILogger<ProdutosController> _logger;

    public ProdutosController(ILogger<ProdutosController> logger)
    {
        _logger = logger;
    }

    public IActionResult Produto()
    {
        return View();
    }

    public IActionResult Listar()
    {
        Repositorio<Produto> repo = new Repositorio<Produto>();
        List<Produto> lista = repo.Listar();
        return View(lista);
    }

    [HttpPost]
    public IActionResult Produto(Produto model)
    {   
        Repositorio<Produto> repo = new Repositorio<Produto>();
        repo.Adicionar(model);
        return RedirectToAction("Listar");
    }

    public IActionResult Editar(int id)
    {
        Repositorio<Produto> repo = new Repositorio<Produto>();
        Produto produto = repo.Buscar(id);
        
        if (produto == null)
        {
            return NotFound();
        }

        return View(produto);
    }

    [HttpPost]
    public IActionResult Editar(Produto produto)
    {
        Repositorio<Produto> repo = new Repositorio<Produto>();
        repo.Atualizar(produto);

        
        return RedirectToAction("Listar");
    }

    public IActionResult Apagar(int id)
    {
        Repositorio<Produto> repo = new Repositorio<Produto>();
        Produto produto = repo.Buscar(id);
        
        if (produto == null)
        {
            return NotFound();
        }

        return View(produto);
    }

    [HttpPost]
    public IActionResult Apagar(Produto produto)
    {
        Repositorio<Produto> repo = new Repositorio<Produto>();
        repo.Remover(produto.Id);
        return RedirectToAction("Listar");
    }
}
